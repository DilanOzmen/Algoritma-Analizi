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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rezervasyonlar = new Rezervasyonlar();
            rezervasyonlar.Show();
            this.Hide();

        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            FilmEkle yeniForm = new FilmEkle();
            yeniForm.Show();
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle yeniForm = new KullaniciEkle();
            yeniForm.Show();
        }
    }
}
