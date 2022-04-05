namespace MusicPlayer
{
    partial class MediaToPlay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openIt = new System.Windows.Forms.Button();
            this.playIt = new System.Windows.Forms.Button();
            this.stopIt = new System.Windows.Forms.Button();
            this.pauseIt = new System.Windows.Forms.Button();
            this.nameOf = new System.Windows.Forms.TextBox();
            this.volumeLevel = new System.Windows.Forms.TrackBar();
            this.volumeTxtBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.soundLength = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.positionofmusic = new System.Windows.Forms.TextBox();
            this.soundLength1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // openIt
            // 
            this.openIt.Location = new System.Drawing.Point(32, 225);
            this.openIt.Name = "openIt";
            this.openIt.Size = new System.Drawing.Size(75, 23);
            this.openIt.TabIndex = 0;
            this.openIt.Text = "open";
            this.openIt.UseVisualStyleBackColor = true;
            this.openIt.Click += new System.EventHandler(this.openIt_Click);
            // 
            // playIt
            // 
            this.playIt.Location = new System.Drawing.Point(225, 225);
            this.playIt.Name = "playIt";
            this.playIt.Size = new System.Drawing.Size(75, 23);
            this.playIt.TabIndex = 1;
            this.playIt.Text = "play";
            this.playIt.UseVisualStyleBackColor = true;
            this.playIt.Click += new System.EventHandler(this.playIt_Click);
            // 
            // stopIt
            // 
            this.stopIt.Location = new System.Drawing.Point(306, 225);
            this.stopIt.Name = "stopIt";
            this.stopIt.Size = new System.Drawing.Size(75, 23);
            this.stopIt.TabIndex = 2;
            this.stopIt.Text = "stop";
            this.stopIt.UseVisualStyleBackColor = true;
            this.stopIt.Click += new System.EventHandler(this.stopIt_Click);
            // 
            // pauseIt
            // 
            this.pauseIt.Location = new System.Drawing.Point(131, 225);
            this.pauseIt.Name = "pauseIt";
            this.pauseIt.Size = new System.Drawing.Size(75, 23);
            this.pauseIt.TabIndex = 3;
            this.pauseIt.Text = "pause";
            this.pauseIt.UseVisualStyleBackColor = true;
            this.pauseIt.Click += new System.EventHandler(this.pauseIt_Click);
            // 
            // nameOf
            // 
            this.nameOf.AllowDrop = true;
            this.nameOf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameOf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOf.Location = new System.Drawing.Point(32, 31);
            this.nameOf.Name = "nameOf";
            this.nameOf.ReadOnly = true;
            this.nameOf.Size = new System.Drawing.Size(349, 16);
            this.nameOf.TabIndex = 5;
            // 
            // volumeLevel
            // 
            this.volumeLevel.Location = new System.Drawing.Point(12, 279);
            this.volumeLevel.Maximum = 1000;
            this.volumeLevel.Name = "volumeLevel";
            this.volumeLevel.Size = new System.Drawing.Size(356, 45);
            this.volumeLevel.TabIndex = 8;
            this.volumeLevel.Scroll += new System.EventHandler(this.volumeLevel_Scroll);
            // 
            // volumeTxtBox
            // 
            this.volumeTxtBox.Location = new System.Drawing.Point(363, 279);
            this.volumeTxtBox.Name = "volumeTxtBox";
            this.volumeTxtBox.Size = new System.Drawing.Size(33, 23);
            this.volumeTxtBox.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 404);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(414, 23);
            this.progressBar.TabIndex = 10;
            // 
            // soundLength
            // 
            this.soundLength.Location = new System.Drawing.Point(289, 115);
            this.soundLength.Name = "soundLength";
            this.soundLength.Size = new System.Drawing.Size(32, 23);
            this.soundLength.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // positionofmusic
            // 
            this.positionofmusic.Location = new System.Drawing.Point(234, 160);
            this.positionofmusic.Name = "positionofmusic";
            this.positionofmusic.Size = new System.Drawing.Size(100, 23);
            this.positionofmusic.TabIndex = 12;
            // 
            // soundLength1
            // 
            this.soundLength1.Location = new System.Drawing.Point(319, 115);
            this.soundLength1.Name = "soundLength1";
            this.soundLength1.Size = new System.Drawing.Size(49, 23);
            this.soundLength1.TabIndex = 13;
            // 
            // MediaToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 424);
            this.Controls.Add(this.soundLength1);
            this.Controls.Add(this.positionofmusic);
            this.Controls.Add(this.soundLength);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.volumeTxtBox);
            this.Controls.Add(this.volumeLevel);
            this.Controls.Add(this.nameOf);
            this.Controls.Add(this.pauseIt);
            this.Controls.Add(this.stopIt);
            this.Controls.Add(this.playIt);
            this.Controls.Add(this.openIt);
            this.Name = "MediaToPlay";
            this.Text = "Musicplayer";
            ((System.ComponentModel.ISupportInitialize)(this.volumeLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openIt;
        private Button playIt;
        private Button stopIt;
        private Button pauseIt;
        private TextBox nameOf;
        private TrackBar volumeLevel;
        private TextBox volumeTxtBox;
        private ProgressBar progressBar;
        private TextBox soundLength;
        private System.Windows.Forms.Timer timer1;
        private TextBox positionofmusic;
        private TextBox soundLength1;
    }
}