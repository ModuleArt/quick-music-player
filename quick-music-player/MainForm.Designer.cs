namespace quick_music_player
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.addFilesButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.prevButton = new System.Windows.Forms.ToolStripButton();
			this.playButton = new System.Windows.Forms.ToolStripButton();
			this.pauseButton = new System.Windows.Forms.ToolStripButton();
			this.nextButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.volumeButton = new System.Windows.Forms.ToolStripButton();
			this.volumeLabel = new System.Windows.Forms.ToolStripLabel();
			this.loopButton = new System.Windows.Forms.ToolStripButton();
			this.shuffleButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.currentLabel = new System.Windows.Forms.ToolStripLabel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.compressionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.bitrateLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.durationLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.bpmLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.releasedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.volumeSlider = new quick_music_player.CustomTrackBar();
			this.currentSlider = new quick_music_player.CustomTrackBar();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.currentSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.addFilesButton,
            this.toolStripSeparator1,
            this.prevButton,
            this.playButton,
            this.pauseButton,
            this.nextButton,
            this.toolStripSeparator3,
            this.aboutButton,
            this.toolStripSeparator2,
            this.volumeButton,
            this.volumeLabel,
            this.loopButton,
            this.shuffleButton,
            this.toolStripSeparator4,
            this.currentLabel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(484, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// openButton
			// 
			this.openButton.AutoSize = false;
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(24, 25);
			this.openButton.Text = "Open files | Ctrl + O";
			this.openButton.ToolTipText = "Open files | Ctrl + O";
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// addFilesButton
			// 
			this.addFilesButton.AutoSize = false;
			this.addFilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addFilesButton.Image = ((System.Drawing.Image)(resources.GetObject("addFilesButton.Image")));
			this.addFilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addFilesButton.Name = "addFilesButton";
			this.addFilesButton.Size = new System.Drawing.Size(24, 25);
			this.addFilesButton.Text = "Add files | Ctrl + A";
			this.addFilesButton.ToolTipText = "Add files | Ctrl + A";
			this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(2, 16);
			// 
			// prevButton
			// 
			this.prevButton.AutoSize = false;
			this.prevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prevButton.Enabled = false;
			this.prevButton.Image = ((System.Drawing.Image)(resources.GetObject("prevButton.Image")));
			this.prevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.prevButton.Name = "prevButton";
			this.prevButton.Size = new System.Drawing.Size(24, 25);
			this.prevButton.Text = "Prev | Ctrl + P";
			this.prevButton.ToolTipText = "Prev | Ctrl + P";
			this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
			// 
			// playButton
			// 
			this.playButton.AutoSize = false;
			this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.playButton.Enabled = false;
			this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
			this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(24, 25);
			this.playButton.Text = "Play | Space";
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.AutoSize = false;
			this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pauseButton.Enabled = false;
			this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
			this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(24, 25);
			this.pauseButton.Text = "Pause | Space";
			this.pauseButton.Visible = false;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// nextButton
			// 
			this.nextButton.AutoSize = false;
			this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nextButton.Enabled = false;
			this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
			this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(24, 25);
			this.nextButton.Text = "Next | Ctrl + N";
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AutoSize = false;
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(2, 16);
			// 
			// aboutButton
			// 
			this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.aboutButton.AutoSize = false;
			this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
			this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(24, 25);
			this.aboutButton.Text = "About | F1";
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(2, 16);
			// 
			// volumeButton
			// 
			this.volumeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.volumeButton.AutoSize = false;
			this.volumeButton.CheckOnClick = true;
			this.volumeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.volumeButton.Image = ((System.Drawing.Image)(resources.GetObject("volumeButton.Image")));
			this.volumeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.volumeButton.Name = "volumeButton";
			this.volumeButton.Size = new System.Drawing.Size(24, 25);
			this.volumeButton.Text = "Volume | Ctrl + V";
			this.volumeButton.CheckedChanged += new System.EventHandler(this.volumeButton_CheckedChanged);
			// 
			// volumeLabel
			// 
			this.volumeLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.volumeLabel.Name = "volumeLabel";
			this.volumeLabel.Size = new System.Drawing.Size(29, 25);
			this.volumeLabel.Text = "50%";
			// 
			// loopButton
			// 
			this.loopButton.CheckOnClick = true;
			this.loopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.loopButton.Image = ((System.Drawing.Image)(resources.GetObject("loopButton.Image")));
			this.loopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.loopButton.Name = "loopButton";
			this.loopButton.Size = new System.Drawing.Size(23, 25);
			this.loopButton.Text = "Loop song | Ctrl + L";
			this.loopButton.CheckedChanged += new System.EventHandler(this.loopButton_CheckedChanged);
			// 
			// shuffleButton
			// 
			this.shuffleButton.CheckOnClick = true;
			this.shuffleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.shuffleButton.Enabled = false;
			this.shuffleButton.Image = ((System.Drawing.Image)(resources.GetObject("shuffleButton.Image")));
			this.shuffleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.shuffleButton.Name = "shuffleButton";
			this.shuffleButton.Size = new System.Drawing.Size(23, 25);
			this.shuffleButton.Text = "Shuffle | Ctrl + S";
			this.shuffleButton.CheckedChanged += new System.EventHandler(this.shuffleButton_CheckedChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AutoSize = false;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(2, 16);
			// 
			// currentLabel
			// 
			this.currentLabel.Name = "currentLabel";
			this.currentLabel.Size = new System.Drawing.Size(72, 25);
			this.currentLabel.Text = "00:00 / 00:00";
			// 
			// listView1
			// 
			this.listView1.AllowColumnReorder = true;
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.AutoArrange = false;
			this.listView1.BackColor = System.Drawing.SystemColors.Control;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.fileName,
            this.title,
            this.artist,
            this.album,
            this.duration});
			this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.LabelWrap = false;
			this.listView1.Location = new System.Drawing.Point(0, 69);
			this.listView1.Margin = new System.Windows.Forms.Padding(0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(484, 466);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listView1_ColumnWidthChanged);
			this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
			this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
			this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
			this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
			// 
			// number
			// 
			this.number.Text = "#";
			this.number.Width = 30;
			// 
			// fileName
			// 
			this.fileName.Text = "File";
			this.fileName.Width = 166;
			// 
			// title
			// 
			this.title.Text = "Title";
			this.title.Width = 72;
			// 
			// artist
			// 
			this.artist.Text = "Artist";
			this.artist.Width = 72;
			// 
			// album
			// 
			this.album.Text = "Album";
			this.album.Width = 72;
			// 
			// duration
			// 
			this.duration.Text = "Length";
			this.duration.Width = 49;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressionLabel,
            this.bitrateLabel,
            this.durationLabel,
            this.bpmLabel,
            this.releasedLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 535);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(484, 26);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// compressionLabel
			// 
			this.compressionLabel.Margin = new System.Windows.Forms.Padding(5);
			this.compressionLabel.Name = "compressionLabel";
			this.compressionLabel.Size = new System.Drawing.Size(134, 16);
			this.compressionLabel.Text = "Compression: Unknown";
			this.compressionLabel.Visible = false;
			// 
			// bitrateLabel
			// 
			this.bitrateLabel.Image = ((System.Drawing.Image)(resources.GetObject("bitrateLabel.Image")));
			this.bitrateLabel.Margin = new System.Windows.Forms.Padding(5);
			this.bitrateLabel.Name = "bitrateLabel";
			this.bitrateLabel.Size = new System.Drawing.Size(114, 16);
			this.bitrateLabel.Text = "Bitrate: Unknown";
			// 
			// durationLabel
			// 
			this.durationLabel.Image = ((System.Drawing.Image)(resources.GetObject("durationLabel.Image")));
			this.durationLabel.Margin = new System.Windows.Forms.Padding(5);
			this.durationLabel.Name = "durationLabel";
			this.durationLabel.Size = new System.Drawing.Size(117, 16);
			this.durationLabel.Text = "Length: Unknown";
			// 
			// bpmLabel
			// 
			this.bpmLabel.Margin = new System.Windows.Forms.Padding(5);
			this.bpmLabel.Name = "bpmLabel";
			this.bpmLabel.Size = new System.Drawing.Size(89, 16);
			this.bpmLabel.Text = "BPM: Unknown";
			this.bpmLabel.Visible = false;
			// 
			// releasedLabel
			// 
			this.releasedLabel.Margin = new System.Windows.Forms.Padding(5);
			this.releasedLabel.Name = "releasedLabel";
			this.releasedLabel.Size = new System.Drawing.Size(110, 16);
			this.releasedLabel.Text = "Released: Unknown";
			this.releasedLabel.Visible = false;
			// 
			// volumeSlider
			// 
			this.volumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.volumeSlider.AutoSize = false;
			this.volumeSlider.LargeChange = 10;
			this.volumeSlider.Location = new System.Drawing.Point(371, 38);
			this.volumeSlider.Margin = new System.Windows.Forms.Padding(0);
			this.volumeSlider.Maximum = 100;
			this.volumeSlider.Name = "volumeSlider";
			this.volumeSlider.Size = new System.Drawing.Size(104, 31);
			this.volumeSlider.TabIndex = 2;
			this.volumeSlider.TickFrequency = 10;
			this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			this.volumeSlider.Value = 50;
			this.volumeSlider.Visible = false;
			this.volumeSlider.ValueChanged += new System.EventHandler(this.volumeSlider_ValueChanged);
			// 
			// currentSlider
			// 
			this.currentSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentSlider.AutoSize = false;
			this.currentSlider.Enabled = false;
			this.currentSlider.LargeChange = 10;
			this.currentSlider.Location = new System.Drawing.Point(9, 38);
			this.currentSlider.Margin = new System.Windows.Forms.Padding(0);
			this.currentSlider.Maximum = 100;
			this.currentSlider.Name = "currentSlider";
			this.currentSlider.Size = new System.Drawing.Size(466, 31);
			this.currentSlider.TabIndex = 3;
			this.currentSlider.TickFrequency = 25;
			this.currentSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			this.currentSlider.Scroll += new System.EventHandler(this.currentSlider_Scroll);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(484, 561);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.volumeSlider);
			this.Controls.Add(this.currentSlider);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(240, 240);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Music Player";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.currentSlider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton prevButton;
		private System.Windows.Forms.ToolStripButton playButton;
		private System.Windows.Forms.ToolStripButton nextButton;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader fileName;
		private System.Windows.Forms.ToolStripButton pauseButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripButton volumeButton;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.ColumnHeader duration;
		private System.Windows.Forms.ColumnHeader number;
		private System.Windows.Forms.ColumnHeader title;
		private System.Windows.Forms.ColumnHeader artist;
		private System.Windows.Forms.ColumnHeader album;
		private System.Windows.Forms.ToolStripLabel volumeLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel currentLabel;
		private System.Windows.Forms.ToolStripButton loopButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton aboutButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel bitrateLabel;
		private System.Windows.Forms.ToolStripStatusLabel bpmLabel;
		private System.Windows.Forms.ToolStripStatusLabel releasedLabel;
		private CustomTrackBar volumeSlider;
		private CustomTrackBar currentSlider;
		private System.Windows.Forms.ToolStripButton shuffleButton;
		private System.Windows.Forms.ToolStripButton addFilesButton;
		private System.Windows.Forms.ToolStripStatusLabel durationLabel;
		private System.Windows.Forms.ToolStripStatusLabel compressionLabel;
	}
}

