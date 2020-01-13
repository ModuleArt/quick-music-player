using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using WMPLib;

namespace quick_music_player
{
	public partial class MainForm : Form
	{
		private List<string> songs = new List<string>();
		private int currentSong = 0;
		private WindowsMediaPlayer wmplayer = new WindowsMediaPlayer();
		private System.Timers.Timer currentSliderTimer = new System.Timers.Timer();
		private int nextReadyCounter = 0;
		private bool loopSong = false;

		public MainForm()
		{
			InitializeComponent();

			listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);

			wmplayer.PositionChange += new _WMPOCXEvents_PositionChangeEventHandler(wmplayer_PositionChange);
			wmplayer.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(wmplayer_PlayStateChange);

			currentSliderTimer.Interval = 1000;
			currentSliderTimer.Elapsed += new ElapsedEventHandler(currentSliderTimer_Elapsed);

			volumeSlider.Value = Properties.Settings.Default.Volume;
		}

		private void wmplayer_PlayStateChange(int newState)
		{
			if (wmplayer.playState == WMPPlayState.wmppsPaused || wmplayer.playState == WMPPlayState.wmppsStopped)
			{
				pauseButton.Visible = false;
				playButton.Visible = true;
				currentSliderTimer.Stop();
			}
			else if (wmplayer.playState == WMPPlayState.wmppsPlaying)
			{
				pauseButton.Visible = true;
				playButton.Visible = false;
				currentSliderTimer.Start();
			}
			else if (wmplayer.playState == WMPPlayState.wmppsMediaEnded)
			{
				nextReadyCounter = 0;
				if (loopSong)
				{
					playSong(currentSong);
				}
				else
				{
					nextSong();
				}
			}
			else if (wmplayer.playState == WMPPlayState.wmppsReady)
			{
				nextReadyCounter++;
				if (nextReadyCounter == 2)
				{
					play();
				}
			}
		}

		private void currentSliderTimer_Elapsed(object sender, EventArgs e)
		{
			int newValue = 0;
			try
			{
				newValue = Convert.ToInt32(wmplayer.controls.currentPosition * 100 / wmplayer.currentMedia.duration);
			}
			catch
			{

			}

			currentSlider.Invoke((MethodInvoker)(() =>
				currentSlider.Value = newValue
			));
			currentLabel.GetCurrentParent().Invoke((MethodInvoker)(() =>
				currentLabel.Text = wmplayer.controls.currentPositionString + " / " + wmplayer.currentMedia.durationString
			));
		}

		private void wmplayer_PositionChange(double oldPosition, double newPosition)
		{
			int newValue = Convert.ToInt32(newPosition * 100 / wmplayer.currentMedia.duration);
			currentSlider.Value = newValue; 
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog1.FileNames.Length > 0)
				{
					stop();

					int lastCount = songs.Count;

					ListViewItem[] lvis = new ListViewItem[openFileDialog1.FileNames.Length];
					for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
					{
						songs.Add(openFileDialog1.FileNames[i]);

						IWMPMedia mediaInfo = wmplayer.newMedia(openFileDialog1.FileNames[i]);

						string fileName = Path.GetFileName(openFileDialog1.FileNames[i]);

						int index = lastCount + i;

						lvis[i] = new ListViewItem(new string[] {
							index.ToString(),
							fileName,
							mediaInfo.getItemInfo("Title"),
							mediaInfo.getItemInfo("Artist"),
							mediaInfo.getItemInfo("Album"),
							mediaInfo.durationString
						});
					}
					listView1.Items.AddRange(lvis);
					playSong(0);

					prevButton.Enabled = true;
					nextButton.Enabled = true;
					playButton.Enabled = true;
					pauseButton.Enabled = true;
					currentSlider.Enabled = true;
				}
			}
		}

		private void playSong(int songIndex)
		{
			listView1.Items[currentSong].Font = new Font(listView1.Font, FontStyle.Regular);
			currentSong = songIndex;
			listView1.Items[currentSong].Font = new Font(listView1.Font, FontStyle.Bold);

			wmplayer.URL = songs[songIndex];
			play();
		}

		private void stop()
		{
			wmplayer.controls.stop();
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
			wmplayer.controls.play();
		}

		private void pause()
		{
			wmplayer.controls.pause();
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
				currentSlider.Width = 350;
			}
			else
			{
				currentSlider.Width = listView1.Width;
			}
		}

		private void volumeSlider_ValueChanged(object sender, EventArgs e)
		{
			wmplayer.settings.volume = volumeSlider.Value;
			volumeLabel.Text = volumeSlider.Value + "%";

			Properties.Settings.Default.Volume = volumeSlider.Value;
			Properties.Settings.Default.Save();
		}

		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListViewHitTestInfo hit = listView1.HitTest(e.Location);

			if (hit.Item != null)
			{
				playSong(hit.Item.Index);
			}
		}

		private void prevButton_Click(object sender, EventArgs e)
		{
			prevSong();
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			nextSong();
		}

		private void currentSlider_Scroll(object sender, EventArgs e)
		{
			double newPosition = Convert.ToDouble(currentSlider.Value * wmplayer.currentMedia.duration / 100);
			wmplayer.controls.currentPosition = newPosition;
		}

		private void loopButton_CheckedChanged(object sender, EventArgs e)
		{
			loopSong = loopButton.Checked;
		}
	}
}
