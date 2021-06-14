namespace Music
{
    partial class uMyplaylist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uMyplaylist));
            this.labelPlaylistName = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaylistName
            // 
            this.labelPlaylistName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlaylistName.AutoEllipsis = true;
            this.labelPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaylistName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlaylistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPlaylistName.Location = new System.Drawing.Point(0, 187);
            this.labelPlaylistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlaylistName.Name = "labelPlaylistName";
            this.labelPlaylistName.Size = new System.Drawing.Size(200, 20);
            this.labelPlaylistName.TabIndex = 63;
            this.labelPlaylistName.Text = "SaYa";
            // 
            // btnImage
            // 
            this.btnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImage.BackgroundImage")));
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Location = new System.Drawing.Point(0, 0);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(200, 185);
            this.btnImage.TabIndex = 64;
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // uMyplaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.labelPlaylistName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uMyplaylist";
            this.Size = new System.Drawing.Size(200, 209);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label labelPlaylistName;
    }
}
