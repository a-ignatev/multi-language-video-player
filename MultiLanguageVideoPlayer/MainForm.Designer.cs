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
            System.Windows.Forms.Label firstConfigTitle;
            System.Windows.Forms.Label secondConfigTitle;
            this.LeftAudioTrack = new System.Windows.Forms.ListBox();
            this.LeftAudioDevice = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileBrowseButton = new System.Windows.Forms.Button();
            this.SelectedFileLabel = new System.Windows.Forms.Label();
            this.ConfigurationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RightVideoRB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RightAudioDevice = new System.Windows.Forms.ListBox();
            this.RightAudioTrack = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LeftVideoRB = new System.Windows.Forms.RadioButton();
            this.PlayButton = new System.Windows.Forms.Button();
            this.VlcPathText = new System.Windows.Forms.TextBox();
            this.VlcPathBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.VideoPosition = new System.Windows.Forms.TrackBar();
            this.VideoTimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            firstConfigTitle = new System.Windows.Forms.Label();
            secondConfigTitle = new System.Windows.Forms.Label();
            this.ConfigurationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPosition)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstConfigTitle
            // 
            firstConfigTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            firstConfigTitle.AutoSize = true;
            firstConfigTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstConfigTitle.Location = new System.Drawing.Point(6, 0);
            firstConfigTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            firstConfigTitle.Name = "firstConfigTitle";
            firstConfigTitle.Size = new System.Drawing.Size(640, 36);
            firstConfigTitle.TabIndex = 5;
            firstConfigTitle.Text = "First Audio Configuration:";
            firstConfigTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondConfigTitle
            // 
            secondConfigTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            secondConfigTitle.AutoSize = true;
            secondConfigTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            secondConfigTitle.Location = new System.Drawing.Point(658, 0);
            secondConfigTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            secondConfigTitle.Name = "secondConfigTitle";
            secondConfigTitle.Size = new System.Drawing.Size(641, 36);
            secondConfigTitle.TabIndex = 6;
            secondConfigTitle.Text = "Second Audio Configuration";
            secondConfigTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftAudioTrack
            // 
            this.LeftAudioTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftAudioTrack.FormattingEnabled = true;
            this.LeftAudioTrack.ItemHeight = 24;
            this.LeftAudioTrack.Items.AddRange(new object[] {
            "Audiotracks will be shown here"});
            this.LeftAudioTrack.Location = new System.Drawing.Point(6, 138);
            this.LeftAudioTrack.Margin = new System.Windows.Forms.Padding(6);
            this.LeftAudioTrack.Name = "LeftAudioTrack";
            this.LeftAudioTrack.Size = new System.Drawing.Size(640, 148);
            this.LeftAudioTrack.TabIndex = 1;
            this.LeftAudioTrack.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // LeftAudioDevice
            // 
            this.LeftAudioDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftAudioDevice.FormattingEnabled = true;
            this.LeftAudioDevice.ItemHeight = 24;
            this.LeftAudioDevice.Items.AddRange(new object[] {
            "Audio devices will be shown here"});
            this.LeftAudioDevice.Location = new System.Drawing.Point(6, 351);
            this.LeftAudioDevice.Margin = new System.Windows.Forms.Padding(6);
            this.LeftAudioDevice.Name = "LeftAudioDevice";
            this.LeftAudioDevice.Size = new System.Drawing.Size(640, 148);
            this.LeftAudioDevice.TabIndex = 2;
            this.LeftAudioDevice.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FileBrowseButton
            // 
            this.FileBrowseButton.Location = new System.Drawing.Point(22, 84);
            this.FileBrowseButton.Margin = new System.Windows.Forms.Padding(6);
            this.FileBrowseButton.Name = "FileBrowseButton";
            this.FileBrowseButton.Size = new System.Drawing.Size(138, 42);
            this.FileBrowseButton.TabIndex = 3;
            this.FileBrowseButton.Text = "Browse file...";
            this.FileBrowseButton.UseVisualStyleBackColor = true;
            this.FileBrowseButton.Click += new System.EventHandler(this.FileBrowseButton_Click);
            // 
            // SelectedFileLabel
            // 
            this.SelectedFileLabel.AutoSize = true;
            this.SelectedFileLabel.Location = new System.Drawing.Point(171, 92);
            this.SelectedFileLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SelectedFileLabel.Name = "SelectedFileLabel";
            this.SelectedFileLabel.Size = new System.Drawing.Size(104, 25);
            this.SelectedFileLabel.TabIndex = 4;
            this.SelectedFileLabel.Text = "seleted file";
            this.SelectedFileLabel.Visible = false;
            // 
            // ConfigurationPanel
            // 
            this.ConfigurationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigurationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ConfigurationPanel.ColumnCount = 2;
            this.ConfigurationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ConfigurationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ConfigurationPanel.Controls.Add(this.RightVideoRB, 1, 1);
            this.ConfigurationPanel.Controls.Add(this.label7, 1, 4);
            this.ConfigurationPanel.Controls.Add(this.label6, 0, 4);
            this.ConfigurationPanel.Controls.Add(this.LeftAudioDevice, 0, 5);
            this.ConfigurationPanel.Controls.Add(this.RightAudioDevice, 1, 5);
            this.ConfigurationPanel.Controls.Add(this.RightAudioTrack, 1, 3);
            this.ConfigurationPanel.Controls.Add(this.LeftAudioTrack, 0, 3);
            this.ConfigurationPanel.Controls.Add(this.label4, 0, 2);
            this.ConfigurationPanel.Controls.Add(this.label5, 1, 2);
            this.ConfigurationPanel.Controls.Add(firstConfigTitle, 0, 0);
            this.ConfigurationPanel.Controls.Add(this.LeftVideoRB, 0, 1);
            this.ConfigurationPanel.Controls.Add(secondConfigTitle, 1, 0);
            this.ConfigurationPanel.Enabled = false;
            this.ConfigurationPanel.Location = new System.Drawing.Point(22, 304);
            this.ConfigurationPanel.Margin = new System.Windows.Forms.Padding(6);
            this.ConfigurationPanel.Name = "ConfigurationPanel";
            this.ConfigurationPanel.RowCount = 6;
            this.ConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ConfigurationPanel.Size = new System.Drawing.Size(1305, 522);
            this.ConfigurationPanel.TabIndex = 5;
            // 
            // RightVideoRB
            // 
            this.RightVideoRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightVideoRB.AutoSize = true;
            this.RightVideoRB.Location = new System.Drawing.Point(866, 51);
            this.RightVideoRB.Margin = new System.Windows.Forms.Padding(6);
            this.RightVideoRB.Name = "RightVideoRB";
            this.RightVideoRB.Size = new System.Drawing.Size(225, 29);
            this.RightVideoRB.TabIndex = 12;
            this.RightVideoRB.TabStop = true;
            this.RightVideoRB.Text = "100% sync with video";
            this.RightVideoRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RightVideoRB.UseVisualStyleBackColor = true;
            this.RightVideoRB.CheckedChanged += new System.EventHandler(this.VideoRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(641, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Audio device:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(640, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Audio device:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightAudioDevice
            // 
            this.RightAudioDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightAudioDevice.FormattingEnabled = true;
            this.RightAudioDevice.ItemHeight = 24;
            this.RightAudioDevice.Items.AddRange(new object[] {
            "Audio devices will be shown here"});
            this.RightAudioDevice.Location = new System.Drawing.Point(658, 351);
            this.RightAudioDevice.Margin = new System.Windows.Forms.Padding(6);
            this.RightAudioDevice.Name = "RightAudioDevice";
            this.RightAudioDevice.Size = new System.Drawing.Size(641, 148);
            this.RightAudioDevice.TabIndex = 3;
            this.RightAudioDevice.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // RightAudioTrack
            // 
            this.RightAudioTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightAudioTrack.FormattingEnabled = true;
            this.RightAudioTrack.ItemHeight = 24;
            this.RightAudioTrack.Items.AddRange(new object[] {
            "Audiotracks will be shown here"});
            this.RightAudioTrack.Location = new System.Drawing.Point(658, 138);
            this.RightAudioTrack.Margin = new System.Windows.Forms.Padding(6);
            this.RightAudioTrack.Name = "RightAudioTrack";
            this.RightAudioTrack.Size = new System.Drawing.Size(641, 148);
            this.RightAudioTrack.TabIndex = 4;
            this.RightAudioTrack.SelectedIndexChanged += new System.EventHandler(this.RefreshPlayButton_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(640, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Audio track:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(641, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Audio track:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftVideoRB
            // 
            this.LeftVideoRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftVideoRB.AutoSize = true;
            this.LeftVideoRB.Location = new System.Drawing.Point(213, 51);
            this.LeftVideoRB.Margin = new System.Windows.Forms.Padding(6);
            this.LeftVideoRB.Name = "LeftVideoRB";
            this.LeftVideoRB.Size = new System.Drawing.Size(225, 29);
            this.LeftVideoRB.TabIndex = 11;
            this.LeftVideoRB.TabStop = true;
            this.LeftVideoRB.Text = "100% sync with video";
            this.LeftVideoRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftVideoRB.UseVisualStyleBackColor = true;
            this.LeftVideoRB.CheckedChanged += new System.EventHandler(this.VideoRadioButton_CheckedChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayButton.Enabled = false;
            this.PlayButton.Location = new System.Drawing.Point(458, 228);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(6);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(138, 42);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.Text = "▷ Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // VlcPathText
            // 
            this.VlcPathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VlcPathText.Enabled = false;
            this.VlcPathText.Location = new System.Drawing.Point(150, 30);
            this.VlcPathText.Margin = new System.Windows.Forms.Padding(6);
            this.VlcPathText.Name = "VlcPathText";
            this.VlcPathText.Size = new System.Drawing.Size(1119, 29);
            this.VlcPathText.TabIndex = 7;
            // 
            // VlcPathBrowse
            // 
            this.VlcPathBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VlcPathBrowse.Location = new System.Drawing.Point(1278, 26);
            this.VlcPathBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.VlcPathBrowse.Name = "VlcPathBrowse";
            this.VlcPathBrowse.Size = new System.Drawing.Size(55, 40);
            this.VlcPathBrowse.TabIndex = 8;
            this.VlcPathBrowse.Text = "...";
            this.VlcPathBrowse.UseVisualStyleBackColor = true;
            this.VlcPathBrowse.Click += new System.EventHandler(this.VlcPathBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Path to VLC:";
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(752, 228);
            this.StopButton.Margin = new System.Windows.Forms.Padding(6);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(138, 42);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "⬜ Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(605, 228);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(6);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(138, 42);
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
            this.VideoPosition.Location = new System.Drawing.Point(22, 128);
            this.VideoPosition.Margin = new System.Windows.Forms.Padding(6);
            this.VideoPosition.Maximum = 8000;
            this.VideoPosition.Name = "VideoPosition";
            this.VideoPosition.Size = new System.Drawing.Size(1311, 80);
            this.VideoPosition.TabIndex = 12;
            this.VideoPosition.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.VideoPosition.ValueChanged += new System.EventHandler(this.VideoPosition_ValueChanged);
            this.VideoPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoPosition_MouseDown);
            this.VideoPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VideoPosition_MouseUp);
            // 
            // VideoTimeLabel
            // 
            this.VideoTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoTimeLabel.Location = new System.Drawing.Point(0, 0);
            this.VideoTimeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VideoTimeLabel.Name = "VideoTimeLabel";
            this.VideoTimeLabel.Size = new System.Drawing.Size(1305, 32);
            this.VideoTimeLabel.TabIndex = 13;
            this.VideoTimeLabel.Text = "duration";
            this.VideoTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VideoTimeLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.VideoTimeLabel);
            this.panel1.Location = new System.Drawing.Point(22, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 32);
            this.panel1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 850);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VideoPosition);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VlcPathBrowse);
            this.Controls.Add(this.VlcPathText);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.ConfigurationPanel);
            this.Controls.Add(this.SelectedFileLabel);
            this.Controls.Add(this.FileBrowseButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "MultiLanguageVideoPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ConfigurationPanel.ResumeLayout(false);
            this.ConfigurationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPosition)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftAudioTrack;
        private System.Windows.Forms.ListBox LeftAudioDevice;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button FileBrowseButton;
        private System.Windows.Forms.Label SelectedFileLabel;
        private System.Windows.Forms.TableLayoutPanel ConfigurationPanel;
        private System.Windows.Forms.ListBox RightAudioDevice;
        private System.Windows.Forms.ListBox RightAudioTrack;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox VlcPathText;
        private System.Windows.Forms.Button VlcPathBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TrackBar VideoPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VideoTimeLabel;
        private System.Windows.Forms.RadioButton RightVideoRB;
        private System.Windows.Forms.RadioButton LeftVideoRB;
    }
}

