namespace PacMan_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            this.SuspendLayout();
            // 
            // pacman
            // 
            this.pacman.Image = ((System.Drawing.Image)(resources.GetObject("pacman.Image")));
            this.pacman.Location = new System.Drawing.Point(356, 172);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(50, 50);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pacman.TabIndex = 0;
            this.pacman.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pacman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hareket);
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman;
    }
}

