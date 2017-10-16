namespace MultiLanguageVideoPlayer
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
            this.LeftAudioTrack = new System.Windows.Forms.ListBox();
            this.LeftAudioDevice = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileBrowseButton = new System.Windows.Forms.Button();
            this.SelectedFileLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.RightAudioDevice = new System.Windows.Forms.ListBox();
            this.RightAudioTrack = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.VlcPathText = new System.Windows.Forms.TextBox();
            this.VlcPathBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.VideoPosition = new System.Windows.Forms.TrackBar();
            this.VideoTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftAudioTrack
            // 
            this.LeftAudioTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftAudioTrack.FormattingEnabled = true;
            this.LeftAudioTrack.Location = new System.Drawing.Point(3, 34);
            this.LeftAudioTrack.Name = "LeftAudioTrack";
            this.LeftAudioTrack.Size = new System.Drawing.Size(491, 108);
            this.LeftAudioTrack.TabIndex = 1;
            this.LeftAudioTrack.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // LeftAudioDevice
            // 
            this.LeftAudioDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftAudioDevice.FormattingEnabled = true;
            this.LeftAudioDevice.Location = new System.Drawing.Point(3, 160);
            this.LeftAudioDevice.Name = "LeftAudioDevice";
            this.LeftAudioDevice.Size = new System.Drawing.Size(491, 108);
            this.LeftAudioDevice.TabIndex = 2;
            this.LeftAudioDevice.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FileBrowseButton
            // 
            this.FileBrowseButton.Location = new System.Drawing.Point(431, 46);
            this.FileBrowseButton.Name = "FileBrowseButton";
            this.FileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.FileBrowseButton.TabIndex = 3;
            this.FileBrowseButton.Text = "Browse file...";
            this.FileBrowseButton.UseVisualStyleBackColor = true;
            this.FileBrowseButton.Click += new System.EventHandler(this.FileBrowseButton_Click);
            // 
            // SelectedFileLabel
            // 
            this.SelectedFileLabel.AutoSize = true;
            this.SelectedFileLabel.Location = new System.Drawing.Point(512, 51);
            this.SelectedFileLabel.Name = "SelectedFileLabel";
            this.SelectedFileLabel.Size = new System.Drawing.Size(57, 13);
            this.SelectedFileLabel.TabIndex = 4;
            this.SelectedFileLabel.Text = "seleted file";
            this.SelectedFileLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.75F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LeftAudioDevice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RightAudioDevice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RightAudioTrack, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LeftAudioTrack, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 149);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 276);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Second Audio Configuration";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightAudioDevice
            // 
            this.RightAudioDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightAudioDevice.FormattingEnabled = true;
            this.RightAudioDevice.Location = new System.Drawing.Point(500, 160);
            this.RightAudioDevice.Name = "RightAudioDevice";
            this.RightAudioDevice.Size = new System.Drawing.Size(488, 108);
            this.RightAudioDevice.TabIndex = 3;
            this.RightAudioDevice.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // RightAudioTrack
            // 
            this.RightAudioTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightAudioTrack.FormattingEnabled = true;
            this.RightAudioTrack.Location = new System.Drawing.Point(500, 34);
            this.RightAudioTrack.Name = "RightAudioTrack";
            this.RightAudioTrack.Size = new System.Drawing.Size(488, 108);
            this.RightAudioTrack.TabIndex = 4;
            this.RightAudioTrack.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Audio Configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayButton
            // 
            this.PlayButton.Enabled = false;
            this.PlayButton.Location = new System.Drawing.Point(384, 120);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.Text = "▷ Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // VlcPathText
            // 
            this.VlcPathText.Enabled = false;
            this.VlcPathText.Location = new System.Drawing.Point(80, 8);
            this.VlcPathText.Name = "VlcPathText";
            this.VlcPathText.Size = new System.Drawing.Size(394, 20);
            this.VlcPathText.TabIndex = 7;
            // 
            // VlcPathBrowse
            // 
            this.VlcPathBrowse.Location = new System.Drawing.Point(480, 7);
            this.VlcPathBrowse.Name = "VlcPathBrowse";
            this.VlcPathBrowse.Size = new System.Drawing.Size(26, 20);
            this.VlcPathBrowse.TabIndex = 8;
            this.VlcPathBrowse.Text = "...";
            this.VlcPathBrowse.UseVisualStyleBackColor = true;
            this.VlcPathBrowse.Click += new System.EventHandler(this.VlcPathBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Path to VLC:";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(546, 120);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "⬜ Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(465, 120);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 11;
            this.PauseButton.Text = "⏸Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // VideoPosition
            // 
            this.VideoPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoPosition.Enabled = false;
            this.VideoPosition.Location = new System.Drawing.Point(15, 75);
            this.VideoPosition.Maximum = 8000;
            this.VideoPosition.Name = "VideoPosition";
            this.VideoPosition.Size = new System.Drawing.Size(982, 45);
            this.VideoPosition.TabIndex = 12;
            this.VideoPosition.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.VideoPosition.ValueChanged += new System.EventHandler(this.VideoPosition_ValueChanged);
            // 
            // VideoTimeLabel
            // 
            this.VideoTimeLabel.AutoSize = true;
            this.VideoTimeLabel.Location = new System.Drawing.Point(489, 104);
            this.VideoTimeLabel.Name = "VideoTimeLabel";
            this.VideoTimeLabel.Size = new System.Drawing.Size(26, 13);
            this.VideoTimeLabel.TabIndex = 13;
            this.VideoTimeLabel.Text = "time";
            this.VideoTimeLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 437);
            this.Controls.Add(this.VideoTimeLabel);
            this.Controls.Add(this.VideoPosition);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VlcPathBrowse);
            this.Controls.Add(this.VlcPathText);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SelectedFileLabel);
            this.Controls.Add(this.FileBrowseButton);
            this.Name = "MainForm";
            this.Text = "MultiLanguageVideoPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftAudioTrack;
        private System.Windows.Forms.ListBox LeftAudioDevice;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button FileBrowseButton;
        private System.Windows.Forms.Label SelectedFileLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox RightAudioDevice;
        private System.Windows.Forms.ListBox RightAudioTrack;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VlcPathText;
        private System.Windows.Forms.Button VlcPathBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TrackBar VideoPosition;
        private System.Windows.Forms.Label VideoTimeLabel;
    }
}

