namespace MusicPlayer
{
    partial class Form1
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
            this.openIt = new System.Windows.Forms.Button();
            this.playIt = new System.Windows.Forms.Button();
            this.stopIt = new System.Windows.Forms.Button();
            this.pauseIt = new System.Windows.Forms.Button();
            this.nameOf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openIt
            // 
            this.openIt.Location = new System.Drawing.Point(194, 298);
            this.openIt.Name = "openIt";
            this.openIt.Size = new System.Drawing.Size(75, 23);
            this.openIt.TabIndex = 0;
            this.openIt.Text = "open";
            this.openIt.UseVisualStyleBackColor = true;
            this.openIt.Click += new System.EventHandler(this.openIt_Click);
            // 
            // playIt
            // 
            this.playIt.Location = new System.Drawing.Point(387, 298);
            this.playIt.Name = "playIt";
            this.playIt.Size = new System.Drawing.Size(75, 23);
            this.playIt.TabIndex = 1;
            this.playIt.Text = "play";
            this.playIt.UseVisualStyleBackColor = true;
            this.playIt.Click += new System.EventHandler(this.playIt_Click);
            // 
            // stopIt
            // 
            this.stopIt.Location = new System.Drawing.Point(468, 298);
            this.stopIt.Name = "stopIt";
            this.stopIt.Size = new System.Drawing.Size(75, 23);
            this.stopIt.TabIndex = 2;
            this.stopIt.Text = "stop";
            this.stopIt.UseVisualStyleBackColor = true;
            this.stopIt.Click += new System.EventHandler(this.stopIt_Click);
            // 
            // pauseIt
            // 
            this.pauseIt.Location = new System.Drawing.Point(293, 298);
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
            this.nameOf.Location = new System.Drawing.Point(194, 155);
            this.nameOf.Name = "nameOf";
            this.nameOf.ReadOnly = true;
            this.nameOf.Size = new System.Drawing.Size(349, 16);
            this.nameOf.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameOf);
            this.Controls.Add(this.pauseIt);
            this.Controls.Add(this.stopIt);
            this.Controls.Add(this.playIt);
            this.Controls.Add(this.openIt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openIt;
        private Button playIt;
        private Button stopIt;
        private Button pauseIt;
        private TextBox nameOf;
    }
}