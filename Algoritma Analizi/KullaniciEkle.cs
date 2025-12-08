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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin adminSayfasi = new Admin();

            // 2. Admin sayfasını aç
            adminSayfasi.Show();

            // 3. Şu an bulunduğun (Film Ekle) sayfasını kapat
            this.Close();
        }
    }
}
