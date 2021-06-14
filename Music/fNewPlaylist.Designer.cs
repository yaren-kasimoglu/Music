namespace Music
{
    partial class fNewPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewPlaylist));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txbNewPlaylist = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewPlaylist = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();


            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;


            this.txbNewPlaylist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNewPlaylist.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbNewPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNewPlaylist.HintForeColor = System.Drawing.Color.Empty;
            this.txbNewPlaylist.HintText = "";
            this.txbNewPlaylist.isPassword = false;
            this.txbNewPlaylist.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txbNewPlaylist.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txbNewPlaylist.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txbNewPlaylist.LineThickness = 3;
            this.txbNewPlaylist.Location = new System.Drawing.Point(17, 218);
            this.txbNewPlaylist.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbNewPlaylist.Name = "txbNewPlaylist";
            this.txbNewPlaylist.Size = new System.Drawing.Size(437, 54);
            this.txbNewPlaylist.TabIndex = 0;
            this.txbNewPlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;


            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = false;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 30D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(129, 336);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(213, 43);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);


            this.pictureBox1.Image = global::Music.Properties.Resources.myMusic;
            this.pictureBox1.Location = new System.Drawing.Point(136, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;


            this.btnNewPlaylist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNewPlaylist.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPlaylist.BorderRadius = 0;
            this.btnNewPlaylist.ButtonText = "Create playlist";
            this.btnNewPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPlaylist.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNewPlaylist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewPlaylist.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewPlaylist.Iconimage")));
            this.btnNewPlaylist.Iconimage_right = null;
            this.btnNewPlaylist.Iconimage_right_Selected = null;
            this.btnNewPlaylist.Iconimage_Selected = null;
            this.btnNewPlaylist.IconMarginLeft = 0;
            this.btnNewPlaylist.IconMarginRight = 0;
            this.btnNewPlaylist.IconRightVisible = false;
            this.btnNewPlaylist.IconRightZoom = 0D;
            this.btnNewPlaylist.IconVisible = true;
            this.btnNewPlaylist.IconZoom = 30D;
            this.btnNewPlaylist.IsTab = false;
            this.btnNewPlaylist.Location = new System.Drawing.Point(129, 284);
            this.btnNewPlaylist.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnNewPlaylist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNewPlaylist.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewPlaylist.selected = false;
            this.btnNewPlaylist.Size = new System.Drawing.Size(213, 43);
            this.btnNewPlaylist.TabIndex = 49;
            this.btnNewPlaylist.Text = "Create playlist";
            this.btnNewPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewPlaylist.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnNewPlaylist.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.txbNewPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fNewPlaylist";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNewPlaylist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbNewPlaylist;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewPlaylist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
    }
}