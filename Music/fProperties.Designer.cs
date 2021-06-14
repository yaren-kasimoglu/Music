﻿namespace Music
{
    partial class fProperties
    {


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



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProperties));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSongName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.songTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.songArtist = new System.Windows.Forms.Label();
            this.albumtitle = new System.Windows.Forms.Label();
            this.albumArtist = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.fileLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();


            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;


            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = null;
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = false;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 30D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(469, 416);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(213, 43);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnClose.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Click += new System.EventHandler(this.bunifuFlatButton1_Click);


            this.lblSongName.AutoSize = true;
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSongName.Location = new System.Drawing.Point(16, 11);
            this.lblSongName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(135, 33);
            this.lblSongName.TabIndex = 56;
            this.lblSongName.Text = "Properties";


            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 49);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(660, 12);
            this.bunifuSeparator1.TabIndex = 57;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;


            this.songTitle.AutoEllipsis = true;
            this.songTitle.AutoSize = true;
            this.songTitle.BackColor = System.Drawing.Color.Transparent;
            this.songTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.songTitle.Location = new System.Drawing.Point(184, 85);
            this.songTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(112, 21);
            this.songTitle.TabIndex = 58;
            this.songTitle.Text = "Charlie Puth";


            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Song title      :";


            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Song artist    :";


            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Album title   :";


            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(43, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Album artist :";



            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(41, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Genre           :";



            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(43, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "Length          :";



            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(43, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 65;
            this.label7.Text = "Year              :";



            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(44, 341);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Copyright    :";


            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(43, 378);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 23);
            this.label9.TabIndex = 67;
            this.label9.Text = "File location:";


            this.songArtist.AutoEllipsis = true;
            this.songArtist.AutoSize = true;
            this.songArtist.BackColor = System.Drawing.Color.Transparent;
            this.songArtist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.songArtist.Location = new System.Drawing.Point(184, 122);
            this.songArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(112, 21);
            this.songArtist.TabIndex = 68;
            this.songArtist.Text = "Charlie Puth";


            this.albumtitle.AutoEllipsis = true;
            this.albumtitle.AutoSize = true;
            this.albumtitle.BackColor = System.Drawing.Color.Transparent;
            this.albumtitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.albumtitle.Location = new System.Drawing.Point(184, 159);
            this.albumtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumtitle.Name = "albumtitle";
            this.albumtitle.Size = new System.Drawing.Size(112, 21);
            this.albumtitle.TabIndex = 69;
            this.albumtitle.Text = "Charlie Puth";



            this.albumArtist.AutoEllipsis = true;
            this.albumArtist.AutoSize = true;
            this.albumArtist.BackColor = System.Drawing.Color.Transparent;
            this.albumArtist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.albumArtist.Location = new System.Drawing.Point(184, 196);
            this.albumArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumArtist.Name = "albumArtist";
            this.albumArtist.Size = new System.Drawing.Size(112, 21);
            this.albumArtist.TabIndex = 70;
            this.albumArtist.Text = "Charlie Puth";



            this.genre.AutoEllipsis = true;
            this.genre.AutoSize = true;
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.genre.Location = new System.Drawing.Point(184, 233);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(112, 21);
            this.genre.TabIndex = 71;
            this.genre.Text = "Charlie Puth";


            this.length.AutoEllipsis = true;
            this.length.AutoSize = true;
            this.length.BackColor = System.Drawing.Color.Transparent;
            this.length.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.length.Location = new System.Drawing.Point(184, 270);
            this.length.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(112, 21);
            this.length.TabIndex = 72;
            this.length.Text = "Charlie Puth";


            this.year.AutoEllipsis = true;
            this.year.AutoSize = true;
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.year.Location = new System.Drawing.Point(184, 306);
            this.year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(112, 21);
            this.year.TabIndex = 73;
            this.year.Text = "Charlie Puth";


            this.copyright.AutoEllipsis = true;
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.Color.Transparent;
            this.copyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.copyright.Location = new System.Drawing.Point(184, 343);
            this.copyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(112, 21);
            this.copyright.TabIndex = 74;
            this.copyright.Text = "Charlie Puth";


            this.fileLocation.AutoEllipsis = true;
            this.fileLocation.BackColor = System.Drawing.Color.Transparent;
            this.fileLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.fileLocation.Location = new System.Drawing.Point(184, 380);
            this.fileLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(499, 20);
            this.fileLocation.TabIndex = 75;
            this.fileLocation.Text = "Charlie Puth";


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 468);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.year);
            this.Controls.Add(this.length);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.albumArtist);
            this.Controls.Add(this.albumtitle);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songTitle);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private System.Windows.Forms.Label lblSongName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label songTitle;
        private System.Windows.Forms.Label fileLocation;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label albumArtist;
        private System.Windows.Forms.Label albumtitle;
        private System.Windows.Forms.Label songArtist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}