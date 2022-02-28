namespace MusicPlayerApp
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RohitsMusicPlayer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SongsList = new System.Windows.Forms.ListBox();
            this.SelectSong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RohitsMusicPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 0;
            // 
            // RohitsMusicPlayer
            // 
            this.RohitsMusicPlayer.AutoSize = true;
            this.RohitsMusicPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RohitsMusicPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RohitsMusicPlayer.Location = new System.Drawing.Point(21, 9);
            this.RohitsMusicPlayer.Name = "RohitsMusicPlayer";
            this.RohitsMusicPlayer.Size = new System.Drawing.Size(163, 20);
            this.RohitsMusicPlayer.TabIndex = 0;
            this.RohitsMusicPlayer.Text = "Rohit\'s Music Player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(754, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SongsList
            // 
            this.SongsList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SongsList.FormattingEnabled = true;
            this.SongsList.ItemHeight = 23;
            this.SongsList.Location = new System.Drawing.Point(552, 63);
            this.SongsList.Name = "SongsList";
            this.SongsList.Size = new System.Drawing.Size(226, 303);
            this.SongsList.TabIndex = 1;
            // 
            // SelectSong
            // 
            this.SelectSong.BackColor = System.Drawing.Color.MediumTurquoise;
            this.SelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectSong.ForeColor = System.Drawing.Color.White;
            this.SelectSong.Location = new System.Drawing.Point(550, 381);
            this.SelectSong.Name = "SelectSong";
            this.SelectSong.Size = new System.Drawing.Size(228, 47);
            this.SelectSong.TabIndex = 2;
            this.SelectSong.Text = "button1";
            this.SelectSong.UseVisualStyleBackColor = false;
            this.SelectSong.Click += new System.EventHandler(this.SelectSong_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectSong);
            this.Controls.Add(this.SongsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RohitsMusicPlayer;
        private System.Windows.Forms.ListBox SongsList;
        private System.Windows.Forms.Button SelectSong;
    }
}
