namespace Algoritma_Analizi
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
            this.KullanıcıAdı = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.textKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.linkKayıt = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.AutoSize = true;
            this.KullanıcıAdı.Location = new System.Drawing.Point(113, 102);
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            this.KullanıcıAdı.Size = new System.Drawing.Size(82, 16);
            this.KullanıcıAdı.TabIndex = 0;
            this.KullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Location = new System.Drawing.Point(113, 196);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(37, 16);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Şifre:";
            // 
            // textKullanıcıAdı
            // 
            this.textKullanıcıAdı.Location = new System.Drawing.Point(302, 96);
            this.textKullanıcıAdı.Name = "textKullanıcıAdı";
            this.textKullanıcıAdı.Size = new System.Drawing.Size(136, 22);
            this.textKullanıcıAdı.TabIndex = 2;
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(302, 196);
            this.textSifre.Name = "textSifre";
            this.textSifre.PasswordChar = '*';
            this.textSifre.Size = new System.Drawing.Size(136, 22);
            this.textSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(192, 279);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(169, 39);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // linkKayıt
            // 
            this.linkKayıt.AutoSize = true;
            this.linkKayıt.Location = new System.Drawing.Point(249, 333);
            this.linkKayıt.Name = "linkKayıt";
            this.linkKayıt.Size = new System.Drawing.Size(52, 16);
            this.linkKayıt.TabIndex = 5;
            this.linkKayıt.TabStop = true;
            this.linkKayıt.Text = "Kayıt Ol";
            this.linkKayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKayıt_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkKayıt);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.textKullanıcıAdı);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullanıcıAdı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullanıcıAdı;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox textKullanıcıAdı;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel linkKayıt;
    }
}

