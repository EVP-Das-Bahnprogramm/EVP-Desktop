namespace EVP.src.subpages
{
    partial class startPage
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPage));
            this.POTD_Pic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.POTD_Pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // POTD_Pic
            // 
            this.POTD_Pic.Image = ((System.Drawing.Image)(resources.GetObject("POTD_Pic.Image")));
            this.POTD_Pic.Location = new System.Drawing.Point(12, 21);
            this.POTD_Pic.Name = "POTD_Pic";
            this.POTD_Pic.Size = new System.Drawing.Size(329, 228);
            this.POTD_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.POTD_Pic.TabIndex = 0;
            this.POTD_Pic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.POTD_Pic);
            this.groupBox1.Location = new System.Drawing.Point(434, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Name = "startPage";
            this.Size = new System.Drawing.Size(958, 489);
            ((System.ComponentModel.ISupportInitialize)(this.POTD_Pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox POTD_Pic;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
