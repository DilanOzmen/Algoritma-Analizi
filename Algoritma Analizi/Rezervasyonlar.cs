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
    public partial class Rezervasyonlar : Form
    {
        public Rezervasyonlar()
        {
            InitializeComponent();
        }

        private void Rezervasyonlar_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Salon 1");
            comboBox1.Items.Add("Salon 2");
            comboBox1.Items.Add("Salon 3");
            comboBox1.Items.Add("Salon 4");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void gerioku_TextChanged(object sender, EventArgs e)
        {

            Admin adminSayfasi = new Admin();


            adminSayfasi.Show();


            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Admin adminSayfasi = new Admin();

            adminSayfasi.Show();

           
            this.Close();
        }
    }
}
