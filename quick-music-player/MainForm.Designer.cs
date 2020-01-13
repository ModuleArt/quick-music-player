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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.prevButton = new System.Windows.Forms.ToolStripButton();
			this.playButton = new System.Windows.Forms.ToolStripButton();
			this.pauseButton = new System.Windows.Forms.ToolStripButton();
			this.nextButton = new System.Windows.Forms.ToolStripButton();
			this.volumeButton = new System.Windows.Forms.ToolStripButton();
			this.listView1 = new System.Windows.Forms.ListView();
			this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.volumeSlider = new System.Windows.Forms.TrackBar();
			this.currentSlider = new System.Windows.Forms.TrackBar();
			this.volumeLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.currentLabel = new System.Windows.Forms.ToolStripLabel();
			this.loopButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.currentSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.toolStripSeparator1,
            this.prevButton,
            this.playButton,
            this.pauseButton,
            this.nextButton,
            this.volumeButton,
            this.volumeLabel,
            this.toolStripSeparator2,
            this.loopButton,
            this.toolStripSeparator3,
            this.currentLabel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(484, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// openButton
			// 
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(23, 22);
			this.openButton.Text = "Add media";
			this.openButton.ToolTipText = "Open";
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// prevButton
			// 
			this.prevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prevButton.Enabled = false;
			this.prevButton.Image = ((System.Drawing.Image)(resources.GetObject("prevButton.Image")));
			this.prevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.prevButton.Name = "prevButton";
			this.prevButton.Size = new System.Drawing.Size(23, 22);
			this.prevButton.Text = "Prev";
			this.prevButton.ToolTipText = "Prev";
			this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
			// 
			// playButton
			// 
			this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.playButton.Enabled = false;
			this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
			this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(23, 22);
			this.playButton.Text = "Play";
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pauseButton.Enabled = false;
			this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
			this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(23, 22);
			this.pauseButton.Text = "Pause";
			this.pauseButton.Visible = false;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// nextButton
			// 
			this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nextButton.Enabled = false;
			this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
			this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(23, 22);
			this.nextButton.Text = "Next";
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			// 
			// volumeButton
			// 
			this.volumeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.volumeButton.CheckOnClick = true;
			this.volumeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.volumeButton.Image = ((System.Drawing.Image)(resources.GetObject("volumeButton.Image")));
			this.volumeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.volumeButton.Name = "volumeButton";
			this.volumeButton.Size = new System.Drawing.Size(23, 22);
			this.volumeButton.Text = "Volume";
			this.volumeButton.CheckedChanged += new System.EventHandler(this.volumeButton_CheckedChanged);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.fileName,
            this.title,
            this.artist,
            this.album,
            this.duration});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 65);
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(460, 484);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// number
			// 
			this.number.Text = "#";
			this.number.Width = 30;
			// 
			// fileName
			// 
			this.fileName.Text = "File";
			this.fileName.Width = 147;
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
			// title
			// 
			this.title.Text = "Title";
			this.title.Width = 72;
			// 
			// duration
			// 
			this.duration.Text = "Length";
			this.duration.Width = 45;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			// 
			// volumeSlider
			// 
			this.volumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.volumeSlider.AutoSize = false;
			this.volumeSlider.LargeChange = 20;
			this.volumeSlider.Location = new System.Drawing.Point(368, 28);
			this.volumeSlider.Maximum = 100;
			this.volumeSlider.Name = "volumeSlider";
			this.volumeSlider.Size = new System.Drawing.Size(104, 31);
			this.volumeSlider.SmallChange = 2;
			this.volumeSlider.TabIndex = 2;
			this.volumeSlider.TickFrequency = 10;
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
			this.currentSlider.Location = new System.Drawing.Point(12, 28);
			this.currentSlider.Maximum = 100;
			this.currentSlider.Name = "currentSlider";
			this.currentSlider.Size = new System.Drawing.Size(460, 31);
			this.currentSlider.TabIndex = 3;
			this.currentSlider.TickFrequency = 25;
			this.currentSlider.Scroll += new System.EventHandler(this.currentSlider_Scroll);
			// 
			// volumeLabel
			// 
			this.volumeLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.volumeLabel.Name = "volumeLabel";
			this.volumeLabel.Size = new System.Drawing.Size(29, 22);
			this.volumeLabel.Text = "50%";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// currentLabel
			// 
			this.currentLabel.Name = "currentLabel";
			this.currentLabel.Size = new System.Drawing.Size(72, 22);
			this.currentLabel.Text = "00:00 / 00:00";
			// 
			// loopButton
			// 
			this.loopButton.CheckOnClick = true;
			this.loopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.loopButton.Image = ((System.Drawing.Image)(resources.GetObject("loopButton.Image")));
			this.loopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.loopButton.Name = "loopButton";
			this.loopButton.Size = new System.Drawing.Size(23, 22);
			this.loopButton.Text = "Loop song";
			this.loopButton.CheckedChanged += new System.EventHandler(this.loopButton_CheckedChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 561);
			this.Controls.Add(this.volumeSlider);
			this.Controls.Add(this.currentSlider);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Music Player";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
		private System.Windows.Forms.TrackBar volumeSlider;
		private System.Windows.Forms.ColumnHeader duration;
		private System.Windows.Forms.ColumnHeader number;
		private System.Windows.Forms.ColumnHeader title;
		private System.Windows.Forms.ColumnHeader artist;
		private System.Windows.Forms.ColumnHeader album;
		private System.Windows.Forms.TrackBar currentSlider;
		private System.Windows.Forms.ToolStripLabel volumeLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel currentLabel;
		private System.Windows.Forms.ToolStripButton loopButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}

