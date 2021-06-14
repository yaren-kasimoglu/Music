namespace Music
{
    partial class fRenamePlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRenamePlaylist));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txbNewPlaylist = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRename = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.txbNewPlaylist.Location = new System.Drawing.Point(17, 18);
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
            this.btnCancel.Location = new System.Drawing.Point(129, 143);
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
            this.btnCancel.Click += new System.EventHandler(this.bunifuFlatButton1_Click);


            this.btnRename.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRename.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRename.BorderRadius = 0;
            this.btnRename.ButtonText = "Rename playlist";
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRename.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRename.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRename.Iconimage = null;
            this.btnRename.Iconimage_right = null;
            this.btnRename.Iconimage_right_Selected = null;
            this.btnRename.Iconimage_Selected = null;
            this.btnRename.IconMarginLeft = 0;
            this.btnRename.IconMarginRight = 0;
            this.btnRename.IconRightVisible = false;
            this.btnRename.IconRightZoom = 0D;
            this.btnRename.IconVisible = true;
            this.btnRename.IconZoom = 30D;
            this.btnRename.IsTab = false;
            this.btnRename.Location = new System.Drawing.Point(129, 89);
            this.btnRename.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRename.Name = "btnRename";
            this.btnRename.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnRename.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRename.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRename.selected = false;
            this.btnRename.Size = new System.Drawing.Size(213, 43);
            this.btnRename.TabIndex = 49;
            this.btnRename.Text = "Rename playlist";
            this.btnRename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRename.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRename.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 196);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txbNewPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fRenamePlaylist";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNewPlaylist";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRename;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txbNewPlaylist;
    }
}