﻿namespace Music
{
    partial class fLocalFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLocalFiles));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.addLocalFiles = new Music.uAddLocalFiles();
            this.panelLocalFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;

            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addLocalFiles);
            this.panel1.Controls.Add(this.panelLocalFiles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 441);
            this.panel1.TabIndex = 0;


            this.addLocalFiles.BackColor = System.Drawing.Color.Gainsboro;
            this.addLocalFiles.Location = new System.Drawing.Point(29, 85);
            this.addLocalFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLocalFiles.Name = "addLocalFiles";
            this.addLocalFiles.Size = new System.Drawing.Size(481, 68);
            this.addLocalFiles.TabIndex = 95;
            this.addLocalFiles.LocalFiles_Click += new System.EventHandler(this.addLocalFiles1_LocalFiles_Click);

            this.panelLocalFiles.AutoScroll = true;
            this.panelLocalFiles.Location = new System.Drawing.Point(27, 156);
            this.panelLocalFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLocalFiles.Name = "panelLocalFiles";
            this.panelLocalFiles.Size = new System.Drawing.Size(504, 219);
            this.panelLocalFiles.TabIndex = 94;


            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 23);
            this.label1.TabIndex = 93;
            this.label1.Text = "Right now, we\'re watching these folders:";

            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(33, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Build your collection from your local music files";

            this.btnDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.BorderRadius = 0;
            this.btnDone.ButtonText = "Done";
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.DisabledColor = System.Drawing.Color.Gray;
            this.btnDone.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDone.Iconimage = null;
            this.btnDone.Iconimage_right = null;
            this.btnDone.Iconimage_right_Selected = null;
            this.btnDone.Iconimage_Selected = null;
            this.btnDone.IconMarginLeft = 0;
            this.btnDone.IconMarginRight = 0;
            this.btnDone.IconRightVisible = false;
            this.btnDone.IconRightZoom = 0D;
            this.btnDone.IconVisible = true;
            this.btnDone.IconZoom = 30D;
            this.btnDone.IsTab = false;
            this.btnDone.Location = new System.Drawing.Point(297, 388);
            this.btnDone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnDone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDone.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDone.selected = false;
            this.btnDone.Size = new System.Drawing.Size(213, 43);
            this.btnDone.TabIndex = 91;
            this.btnDone.Text = "Done";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDone.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnDone.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDone.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);


            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;

            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.label2;
            this.bunifuDragControl3.Vertical = true;


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(540, 446);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fLocalFiles";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLocalFiles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelLocalFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDone;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private uAddLocalFiles addLocalFiles;
    }
}