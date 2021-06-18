
namespace AT3_MediaPlayer_V1
{
    partial class Form1
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
            this.songList = new System.Windows.Forms.ListBox();
            this.songName = new System.Windows.Forms.TextBox();
            this.songGenre = new System.Windows.Forms.TextBox();
            this.songArtist = new System.Windows.Forms.TextBox();
            this.songAlbum = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SortBtn = new System.Windows.Forms.Button();
            this.prevSong = new System.Windows.Forms.Button();
            this.nextSong = new System.Windows.Forms.Button();
            this.songPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(12, 12);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(252, 381);
            this.songList.TabIndex = 0;
            // 
            // songName
            // 
            this.songName.Location = new System.Drawing.Point(270, 31);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(100, 20);
            this.songName.TabIndex = 1;
            // 
            // songGenre
            // 
            this.songGenre.Location = new System.Drawing.Point(270, 73);
            this.songGenre.Name = "songGenre";
            this.songGenre.Size = new System.Drawing.Size(100, 20);
            this.songGenre.TabIndex = 2;
            // 
            // songArtist
            // 
            this.songArtist.Location = new System.Drawing.Point(270, 115);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(100, 20);
            this.songArtist.TabIndex = 3;
            // 
            // songAlbum
            // 
            this.songAlbum.Location = new System.Drawing.Point(270, 157);
            this.songAlbum.Name = "songAlbum";
            this.songAlbum.Size = new System.Drawing.Size(100, 20);
            this.songAlbum.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(270, 183);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Album :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artist : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genre : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name : ";
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(269, 212);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(101, 23);
            this.SortBtn.TabIndex = 13;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // prevSong
            // 
            this.prevSong.BackColor = System.Drawing.Color.White;
            this.prevSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prevSong.Image = global::AT3_MediaPlayer_V1.Properties.Resources.icons8_last_track_button_48;
            this.prevSong.Location = new System.Drawing.Point(30, 399);
            this.prevSong.Name = "prevSong";
            this.prevSong.Size = new System.Drawing.Size(59, 59);
            this.prevSong.TabIndex = 12;
            this.prevSong.UseVisualStyleBackColor = false;
            // 
            // nextSong
            // 
            this.nextSong.BackColor = System.Drawing.Color.White;
            this.nextSong.Image = global::AT3_MediaPlayer_V1.Properties.Resources.icons8_next_track_button_48;
            this.nextSong.Location = new System.Drawing.Point(160, 399);
            this.nextSong.Name = "nextSong";
            this.nextSong.Size = new System.Drawing.Size(59, 59);
            this.nextSong.TabIndex = 11;
            this.nextSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nextSong.UseVisualStyleBackColor = false;
            // 
            // songPlay
            // 
            this.songPlay.BackColor = System.Drawing.Color.White;
            this.songPlay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.songPlay.Image = global::AT3_MediaPlayer_V1.Properties.Resources.icons8_play_button_48;
            this.songPlay.Location = new System.Drawing.Point(95, 399);
            this.songPlay.Name = "songPlay";
            this.songPlay.Size = new System.Drawing.Size(59, 59);
            this.songPlay.TabIndex = 10;
            this.songPlay.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.prevSong);
            this.Controls.Add(this.nextSong);
            this.Controls.Add(this.songPlay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.songAlbum);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.songGenre);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.songList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.TextBox songGenre;
        private System.Windows.Forms.TextBox songArtist;
        private System.Windows.Forms.TextBox songAlbum;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button songPlay;
        private System.Windows.Forms.Button nextSong;
        private System.Windows.Forms.Button prevSong;
        private System.Windows.Forms.Button SortBtn;
    }
}

