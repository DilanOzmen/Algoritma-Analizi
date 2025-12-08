namespace Algoritma_Analizi
{
    partial class Admin
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
            this.btnKullanıcılar = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.btnRezervasyonlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullanıcılar
            // 
            this.btnKullanıcılar.Location = new System.Drawing.Point(98, 117);
            this.btnKullanıcılar.Name = "btnKullanıcılar";
            this.btnKullanıcılar.Size = new System.Drawing.Size(179, 70);
            this.btnKullanıcılar.TabIndex = 0;
            this.btnKullanıcılar.Text = "KULLANICILAR";
            this.btnKullanıcılar.UseVisualStyleBackColor = true;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(464, 117);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(179, 70);
            this.btnFilmEkle.TabIndex = 1;
            this.btnFilmEkle.Text = "FİLM EKLE";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnKullanıcıEkle
            // 
            this.btnKullanıcıEkle.Location = new System.Drawing.Point(98, 272);
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.Size = new System.Drawing.Size(179, 70);
            this.btnKullanıcıEkle.TabIndex = 2;
            this.btnKullanıcıEkle.Text = "KULLANICI EKLE";
            this.btnKullanıcıEkle.UseVisualStyleBackColor = true;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.btnKullanıcıEkle_Click);
            // 
            // btnRezervasyonlar
            // 
            this.btnRezervasyonlar.Location = new System.Drawing.Point(464, 272);
            this.btnRezervasyonlar.Name = "btnRezervasyonlar";
            this.btnRezervasyonlar.Size = new System.Drawing.Size(179, 70);
            this.btnRezervasyonlar.TabIndex = 3;
            this.btnRezervasyonlar.Text = "REZERVASYONLAR";
            this.btnRezervasyonlar.UseVisualStyleBackColor = true;
            this.btnRezervasyonlar.Click += new System.EventHandler(this.btnRezervasyonlar_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezervasyonlar);
            this.Controls.Add(this.btnKullanıcıEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnKullanıcılar);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullanıcılar;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.Button btnRezervasyonlar;
    }
}