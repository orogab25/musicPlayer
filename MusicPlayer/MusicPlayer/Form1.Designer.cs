namespace MusicPlayer
{
    partial class f_player
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addFilePlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureB_image = new System.Windows.Forms.PictureBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.label_length = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_extension = new System.Windows.Forms.Label();
            this.check_playlist = new System.Windows.Forms.CheckBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_progress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playlistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(95, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPlaylist,
            this.savePlaylist,
            this.toolStripSeparator3,
            this.addFilePlaylist,
            this.addFolderPlaylist});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // openPlaylist
            // 
            this.openPlaylist.Name = "openPlaylist";
            this.openPlaylist.Size = new System.Drawing.Size(132, 22);
            this.openPlaylist.Text = "Open";
            this.openPlaylist.Click += new System.EventHandler(this.openPlaylist_Click);
            // 
            // savePlaylist
            // 
            this.savePlaylist.Name = "savePlaylist";
            this.savePlaylist.Size = new System.Drawing.Size(132, 22);
            this.savePlaylist.Text = "Save";
            this.savePlaylist.Click += new System.EventHandler(this.savePlaylist_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(129, 6);
            // 
            // addFilePlaylist
            // 
            this.addFilePlaylist.Name = "addFilePlaylist";
            this.addFilePlaylist.Size = new System.Drawing.Size(132, 22);
            this.addFilePlaylist.Text = "Add File";
            this.addFilePlaylist.Click += new System.EventHandler(this.addFilePlaylist_Click);
            // 
            // addFolderPlaylist
            // 
            this.addFolderPlaylist.Name = "addFolderPlaylist";
            this.addFolderPlaylist.Size = new System.Drawing.Size(132, 22);
            this.addFolderPlaylist.Text = "Add Folder";
            this.addFolderPlaylist.Click += new System.EventHandler(this.addFolderPlaylist_Click);
            // 
            // pictureB_image
            // 
            this.pictureB_image.Location = new System.Drawing.Point(12, 35);
            this.pictureB_image.Name = "pictureB_image";
            this.pictureB_image.Size = new System.Drawing.Size(90, 90);
            this.pictureB_image.TabIndex = 2;
            this.pictureB_image.TabStop = false;
            // 
            // track_volume
            // 
            this.track_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.track_volume.Location = new System.Drawing.Point(12, 129);
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(80, 45);
            this.track_volume.TabIndex = 3;
            this.track_volume.Value = 10;
            this.track_volume.ValueChanged += new System.EventHandler(this.track_volume_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar.Location = new System.Drawing.Point(47, 175);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(338, 25);
            this.progressBar.TabIndex = 4;
            this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_play.Location = new System.Drawing.Point(148, 129);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(40, 35);
            this.button_play.TabIndex = 5;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_stop.Location = new System.Drawing.Point(194, 129);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(40, 35);
            this.button_stop.TabIndex = 6;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_pause
            // 
            this.button_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_pause.Location = new System.Drawing.Point(240, 129);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(40, 35);
            this.button_pause.TabIndex = 7;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.BackColor = System.Drawing.Color.Transparent;
            this.label_length.ForeColor = System.Drawing.Color.Black;
            this.label_length.Location = new System.Drawing.Point(387, 182);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(0, 13);
            this.label_length.TabIndex = 11;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.ForeColor = System.Drawing.Color.Black;
            this.label_name.Location = new System.Drawing.Point(110, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 13);
            this.label_name.TabIndex = 12;
            // 
            // label_extension
            // 
            this.label_extension.AutoSize = true;
            this.label_extension.BackColor = System.Drawing.Color.Transparent;
            this.label_extension.ForeColor = System.Drawing.Color.Black;
            this.label_extension.Location = new System.Drawing.Point(110, 80);
            this.label_extension.Name = "label_extension";
            this.label_extension.Size = new System.Drawing.Size(0, 13);
            this.label_extension.TabIndex = 13;
            // 
            // check_playlist
            // 
            this.check_playlist.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_playlist.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.check_playlist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check_playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_playlist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.check_playlist.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.check_playlist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.check_playlist.Location = new System.Drawing.Point(332, 129);
            this.check_playlist.Name = "check_playlist";
            this.check_playlist.Size = new System.Drawing.Size(90, 35);
            this.check_playlist.TabIndex = 14;
            this.check_playlist.Text = "Playlist";
            this.check_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check_playlist.UseVisualStyleBackColor = false;
            this.check_playlist.CheckStateChanged += new System.EventHandler(this.check_playlist_CheckStateChanged);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.White;
            this.button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_next.Location = new System.Drawing.Point(286, 129);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(40, 35);
            this.button_next.TabIndex = 15;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.BackColor = System.Drawing.Color.White;
            this.button_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_prev.Location = new System.Drawing.Point(102, 129);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(40, 35);
            this.button_prev.TabIndex = 16;
            this.button_prev.Text = "Prev";
            this.button_prev.UseVisualStyleBackColor = false;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.BackColor = System.Drawing.Color.Transparent;
            this.label_progress.ForeColor = System.Drawing.Color.Black;
            this.label_progress.Location = new System.Drawing.Point(12, 182);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(0, 13);
            this.label_progress.TabIndex = 17;
            // 
            // f_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.check_playlist);
            this.Controls.Add(this.label_extension);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.pictureB_image);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_player";
            this.Text = "FreeStyle Music Player";
            this.Load += new System.EventHandler(this.f_player_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureB_image;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_extension;
        private System.Windows.Forms.CheckBox check_playlist;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlaylist;
        private System.Windows.Forms.ToolStripMenuItem savePlaylist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addFilePlaylist;
        private System.Windows.Forms.ToolStripMenuItem addFolderPlaylist;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_progress;
    }
}

