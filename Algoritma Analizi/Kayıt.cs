using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma_Analizi
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (textSifre.Text.Trim() != textSifretekrar.Text.Trim())
            {
                MessageBox.Show("Girdiğiniz şifreler birbiriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSifretekrar.Focus();
                return;
            }

            // 2. Zorunlu Alan Kontrolü
            if (string.IsNullOrEmpty(textKadi.Text.Trim()) || string.IsNullOrEmpty(textSifre.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Cinsiyet Seçimi
            string Cinsiyet = "Belirtilmedi";
            if (rbKadin.Checked) Cinsiyet = "Kadın";
            if (rbErkek.Checked) Cinsiyet = "Erkek";

            // --- KAYIT BAŞARILI İŞLEMLERİ ---

            string kullaniciAdi = textKadi.Text.Trim();

            string mesaj = "Sayın " + textAd.Text + "\n" +
                           "Kullanıcı Adı: " + kullaniciAdi + "\n" +
                           "Cinsiyet: " + Cinsiyet + "\n" +
                           "Kayıt işleminiz başarıyla tamamlandı!";

            MessageBox.Show(mesaj, "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ana Sayfaya Yönlendirme
            AnaSayfa anaSayfa = new AnaSayfa(kullaniciAdi);
            anaSayfa.Show();
            this.Hide();

            // Formu Temizleme
            textAd.Clear();
            textSifre.Clear();
            textSifretekrar.Clear();
            // ... diğer kutular
        }
    }

}

