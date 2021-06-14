
namespace Music
{
    partial class adminOperation
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.upload = new System.Windows.Forms.TextBox();
            this.vName = new System.Windows.Forms.TextBox();
            this.vTel = new System.Windows.Forms.TextBox();
            this.tbposition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(146, 210);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(320, 22);
            this.upload.TabIndex = 5;
            // 
            // vName
            // 
            this.vName.Location = new System.Drawing.Point(567, 199);
            this.vName.Name = "vName";
            this.vName.Size = new System.Drawing.Size(188, 22);
            this.vName.TabIndex = 6;
            // 
            // vTel
            // 
            this.vTel.Location = new System.Drawing.Point(567, 260);
            this.vTel.Name = "vTel";
            this.vTel.Size = new System.Drawing.Size(184, 22);
            this.vTel.TabIndex = 7;
            // 
            // tbposition
            // 
            this.tbposition.Location = new System.Drawing.Point(567, 319);
            this.tbposition.Name = "tbposition";
            this.tbposition.Size = new System.Drawing.Size(185, 22);
            this.tbposition.TabIndex = 8;
            // 
            // adminOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 600);
            this.Controls.Add(this.tbposition);
            this.Controls.Add(this.vTel);
            this.Controls.Add(this.vName);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "adminOperation";
            this.Text = "adminOperation";
            this.Load += new System.EventHandler(this.adminOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox upload;
        private System.Windows.Forms.TextBox vName;
        private System.Windows.Forms.TextBox vTel;
        private System.Windows.Forms.TextBox tbposition;
    }
}