using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;

namespace quick_music_player
{
	public partial class MainForm : Form
	{
		private struct Song
		{
			public string path;
			public int index;

			public Song(string p, int i)
			{
				path = p;
				index = i;
			}
		};

		private List<Song> songs = new List<Song>();
		private int currentSong = 0;
		private System.Timers.Timer currentSliderTimer = new System.Timers.Timer();
		private bool loopSong = false;
		private bool userAction = false;
		private WaveOutEvent waveOut = new WaveOutEvent();
		private Mp3FileReader mp3Reader;
		private bool darkMode = false;

		public MainForm()
		{
			InitializeComponent();

			listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
			listView1.HideSelection = true;
			updateLastColumnWidth();

			waveOut.PlaybackStopped += new EventHandler<StoppedEventArgs>(waveOut_PlaybackStopped);

			currentSliderTimer.Interval = 1000;
			currentSliderTimer.Elapsed += new ElapsedEventHandler(currentSliderTimer_Elapsed);

			toolStrip1.Renderer = new ToolStripOverride();

			volumeSlider.Value = Properties.Settings.Default.Volume;
			loopButton.Checked = Properties.Settings.Default.LoopSong;
		}

		private void waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
		{
			if (!userAction)
			{
				if (loopSong)
				{
					mp3Reader.Position = 0;
					play();
				}
				else
				{
					nextSong();
				}
			} 
			userAction = false;
		}

		private void currentSliderTimer_Elapsed(object sender, EventArgs e)
		{
			try
			{
				int newValue = Convert.ToInt32(mp3Reader.Position * 100 / mp3Reader.Length);

				currentSlider.Invoke((MethodInvoker)(() =>
					currentSlider.Value = newValue
				));
				currentLabel.GetCurrentParent().Invoke((MethodInvoker)(() =>
					currentLabel.Text = mp3Reader.CurrentTime.ToString(@"mm\:ss") + " / " + mp3Reader.TotalTime.ToString(@"mm\:ss")
				));
			}
			catch
			{

			}
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			openFiles(true);
		}

		private void playSong(int songIndex)
		{
			try
			{
				waveOut.Stop();

				if (mp3Reader != null)
				{
					mp3Reader.Dispose();
				}

				mp3Reader = new Mp3FileReader(songs[songIndex].path);
				waveOut.Init(mp3Reader);
				play();

				listView1.Invoke((MethodInvoker)(() =>
				{
					listView1.Items[currentSong].Font = new Font(listView1.Font, FontStyle.Regular);
					listView1.Items[currentSong].BackColor = listView1.BackColor;
				}));

				currentSong = songIndex;
				string fileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[currentSong]);
				this.Invoke((MethodInvoker)(() => 
				{
					this.Text = fileName + "   |   Quick Music Player";
				})); 

				listView1.Invoke((MethodInvoker)(() =>
				{
					listView1.Items[currentSong].Font = new Font(listView1.Font, FontStyle.Bold);
					listView1.Items[currentSong].BackColor = ThemeManager.AccentColorDark;
				}));
			}
			catch
			{
				MessageBox.Show("Unable to open audio file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void stop()
		{
			playButton.Visible = true;
			pauseButton.Visible = false;

			currentSliderTimer.Stop();

			waveOut.Stop();
		}

		private void nextSong()
		{
			if (currentSong == songs.Count - 1)
			{
				playSong(0);
			}
			else
			{
				playSong(currentSong + 1);
			}
		}

		private void prevSong()
		{
			if (currentSong == 0)
			{
				playSong(songs.Count - 1);
			}
			else
			{
				playSong(currentSong - 1);
			}
		}

		private void play()
		{
			try
			{
				waveOut.Play();

				playButton.Visible = false;
				pauseButton.Visible = true;

				currentSliderTimer.Start();
			}
			catch
			{
				MessageBox.Show("Unable to start playing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void pause()
		{
			waveOut.Pause();

			playButton.Visible = true;
			pauseButton.Visible = false;

			currentSliderTimer.Stop();
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			play();
		}

		private void pauseButton_Click(object sender, EventArgs e)
		{
			pause();
		}

		private void volumeButton_CheckedChanged(object sender, EventArgs e)
		{
			volumeSlider.Visible = volumeButton.Checked;

			if (volumeButton.Checked)
			{
				currentSlider.Width = listView1.Width - 122;
			}
			else
			{
				currentSlider.Width = listView1.Width - 18;
			}
		}

		private void volumeSlider_ValueChanged(object sender, EventArgs e)
		{
			waveOut.Volume = volumeSlider.Value / 100f;
			volumeLabel.Text = volumeSlider.Value + "%";

			Properties.Settings.Default.Volume = volumeSlider.Value;
			Properties.Settings.Default.Save();
		}

		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			userAction = true;

			ListViewHitTestInfo hit = listView1.HitTest(e.Location);

			if (hit.Item != null)
			{
				playSong(hit.Item.Index);
			}
		}

		private void prevButton_Click(object sender, EventArgs e)
		{
			userAction = true;
			prevSong();
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			userAction = true;
			nextSong();
		}

		private void currentSlider_Scroll(object sender, EventArgs e)
		{
			int newPosition = Convert.ToInt32(currentSlider.Value * mp3Reader.Length / 100);
			mp3Reader.Position = newPosition;
		}

		private void loopButton_CheckedChanged(object sender, EventArgs e)
		{
			loopSong = loopButton.Checked;

			Properties.Settings.Default.LoopSong = loopButton.Checked;
			Properties.Settings.Default.Save();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			darkMode = ThemeManager.isDarkTheme();
			if (darkMode)
			{
				applyDarkTheme();
			}

			checkForUpdates(false);
		}

		public async void checkForUpdates(bool showUpToDateDialog)
		{
			try
			{
				UpdateChecker checker = new UpdateChecker("ModuleArt", "quick-music-player");

				bool update = await checker.CheckUpdate();

				if (update == false)
				{
					if (showUpToDateDialog)
					{
						MessageBox.Show("Application is up to date", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					UpdateForm updateDialog = new UpdateForm(checker, "Quick Music Player");

					var result = updateDialog.ShowDialog();
					if (result == DialogResult.Yes)
					{
						checker.DownloadAsset("QuickMusicPlayer-Setup.msi");
						this.Close();
					}
					else
					{
						updateDialog.Dispose();
					}
				}
			}
			catch
			{
				if (showUpToDateDialog)
				{
					MessageBox.Show("Connection error", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void applyDarkTheme()
		{
			ThemeManager.setDarkModeToControl(listView1.Handle);
			listView1.BackColor = ThemeManager.BackColorDark;
			listView1.ForeColor = Color.White;
			listView1.OwnerDraw = true;

			this.ForeColor = Color.White;
			this.BackColor = ThemeManager.MainColorDark;
			statusStrip1.BackColor = ThemeManager.SecondColorDark;

			openButton.Image = Properties.Resources.white_open;
			addFilesButton.Image = Properties.Resources.white_addfile;

			prevButton.Image = Properties.Resources.white_prev;
			playButton.Image = Properties.Resources.white_play;
			pauseButton.Image = Properties.Resources.white_pause;
			nextButton.Image = Properties.Resources.white_next;

			loopButton.Image = Properties.Resources.white_repeat;
			shuffleButton.Image = Properties.Resources.white_shuffle;

			volumeButton.Image = Properties.Resources.white_speaker;

			aboutButton.Image = Properties.Resources.white_about;

			bitrateLabel.Image = Properties.Resources.white_speed;
			durationLabel.Image = Properties.Resources.white_length;

			ThemeManager.enableDarkTitlebar(this.Handle, true);
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutBox = new AboutForm();
			aboutBox.Owner = this;
			aboutBox.ShowDialog();
		}

		private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				string[] details = ShellManager.GetDetails(songs[listView1.SelectedItems[0].Index].path);

				//compressionLabel.Text = "Compression: " + details[0];
				bitrateLabel.Text = "Bitrate: " + details[1] + " kbps";
				//bpmLabel.Text = "BPM: " + details[2];
				//releasedLabel.Text = "Released: " + details[3];
				//releasedLabel.Text = "Released: " + details[3];
				durationLabel.Text = "Length: " + details[4];
			}
		}

		private void listView1_ItemActivate(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				userAction = true;
				playSong(listView1.SelectedIndices[0]);
			}
		}

		private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
		{
			using (SolidBrush backBrush = new SolidBrush(ThemeManager.MainColorDark))
			{
				e.Graphics.FillRectangle(backBrush, e.Bounds);
			}

			if (e.Header.Index != listView1.Columns.Count - 1)
			{
				using (Pen borderPen = new Pen(ThemeManager.SecondColorDark, 2))
				{
					e.Graphics.DrawLine(borderPen, e.Bounds.X + e.Bounds.Width - 1, e.Bounds.Y + 1, e.Bounds.X + e.Bounds.Width - 1, e.Bounds.Y + 17);
				}
			}

			using (SolidBrush foreBrush = new SolidBrush(Color.White))
			{
				Rectangle newBounds = e.Bounds;
				newBounds.X += 4;
				e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, newBounds);
			}
		}

		private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			e.DrawDefault = true;
		}

		private void updateLastColumnWidth()
		{
			listView1.Columns[listView1.Columns.Count - 1].Width = -2;
		}

		private void listView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
		{
			if (e.ColumnIndex != listView1.Columns.Count - 1)
			{
				listView1.Columns[listView1.Columns.Count - 1].Width = -2;
			}
		}

		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{
			updateLastColumnWidth();
		}

		private void shuffle()
		{
			int playingIndex = songs[currentSong].index;

			Random rng = new Random();

			int n = songs.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				Song tmp = songs[k];
				songs[k] = songs[n];
				songs[n] = tmp;
			}

			for (int i = 0; i < songs.Count; i++)
			{
				if (songs[i].index == playingIndex)
				{
					currentSong = 0;
					Song tmp = songs[0];
					songs[0] = songs[i];
					songs[i] = tmp;
					break;
				}
			}

			listView1.Items.Clear();

			ListViewItem[] lvis = new ListViewItem[songs.Count];
			for (int i = 0; i < songs.Count; i++)
			{
				string[] allInfo = ShellManager.GetAllInfo(songs[i].path);

				string fileName = Path.GetFileNameWithoutExtension(songs[i].path);

				lvis[i] = new ListViewItem(new string[] {
					songs[i].index.ToString(),
					fileName,
					allInfo[0],
					allInfo[1],
					allInfo[2],
					allInfo[3]
				});
			}
			listView1.Items.AddRange(lvis);

			listView1.Items[currentSong].Font = new Font(listView1.Font, FontStyle.Bold);
			listView1.Items[currentSong].BackColor = ThemeManager.AccentColorDark;
		}

		private void unshuffle()
		{
			int playingIndex = songs[currentSong].index;

			songs.Sort((s1, s2) => s1.index.CompareTo(s2.index));

			for (int i = 0; i < songs.Count; i++)
			{
				if (songs[i].index == playingIndex)
				{
					currentSong = i;
					break;
				}
			}

			listView1.Items.Clear();

			ListViewItem[] lvis = new ListViewItem[songs.Count];
			for (int i = 0; i < songs.Count; i++)
			{
				string[] allInfo = ShellManager.GetAllInfo(songs[i].path);

				string fileName = Path.GetFileNameWithoutExtension(songs[i].path);

				lvis[i] = new ListViewItem(new string[] {
					songs[i].index.ToString(),
					fileName,
					allInfo[0],
					allInfo[1],
					allInfo[2],
					allInfo[3]
				});
			}
			listView1.Items.AddRange(lvis);

			listView1.Items[currentSong].Font = new Font(listView1.Font, FontStyle.Bold);
			listView1.Items[currentSong].BackColor = ThemeManager.AccentColorDark;
		}

		private void shuffleButton_CheckedChanged(object sender, EventArgs e)
		{
			if (shuffleButton.Checked)
			{
				shuffle();
			}
			else
			{
				unshuffle();
			}
		}

		private void togglePlayPause()
		{
			if (waveOut.PlaybackState == PlaybackState.Paused)
			{
				playButton.PerformClick();
			}
			else if (waveOut.PlaybackState == PlaybackState.Playing)
			{
				pauseButton.PerformClick();
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if(e.KeyCode == Keys.O)
					{
					openButton.PerformClick();
				}
				else if (e.KeyCode == Keys.A)
				{
					addFilesButton.PerformClick();
				}
				else if (e.KeyCode == Keys.L)
				{
					loopButton.PerformClick();
				}
				else if (e.KeyCode == Keys.S)
				{
					shuffleButton.PerformClick();
				}
				else if (e.KeyCode == Keys.V)
				{
					volumeButton.PerformClick();
				}
				else if (e.KeyCode == Keys.N)
				{
					nextButton.PerformClick();
				}
				else if (e.KeyCode == Keys.P)
				{
					prevButton.PerformClick();
				}
			}
			else
			{
				if (e.KeyCode == Keys.Space)
				{
					togglePlayPause();
				}
				else if (e.KeyCode == Keys.F1)
				{
					aboutButton.PerformClick();
				}
			}
		}

		private void addFilesButton_Click(object sender, EventArgs e)
		{
			openFiles(false);
		}

		private void openFiles(bool clearList)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog1.FileNames.Length > 0)
				{
					stop();

					if (clearList)
					{
						songs.Clear();
						listView1.Items.Clear();
					}

					int lastCount = songs.Count;

					ListViewItem[] lvis = new ListViewItem[openFileDialog1.FileNames.Length];
					for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
					{
						int index = lastCount + i;

						songs.Add(new Song(openFileDialog1.FileNames[i], index));

						string[] allInfo = ShellManager.GetAllInfo(openFileDialog1.FileNames[i]);

						string fileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i]);

						lvis[i] = new ListViewItem(new string[] {
							index.ToString(),
							fileName,
							allInfo[0],
							allInfo[1],
							allInfo[2],
							allInfo[3]
						});
					}
					listView1.Items.AddRange(lvis);
					updateLastColumnWidth();

					prevButton.Enabled = true;
					nextButton.Enabled = true;
					playButton.Enabled = true;
					pauseButton.Enabled = true;
					currentSlider.Enabled = true;
					shuffleButton.Enabled = true;

					if (lastCount == 0)
					{
						listView1.Items[0].Selected = true;
						playSong(0);
					}
				}
			}
		}
	}
}
