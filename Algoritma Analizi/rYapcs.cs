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
    public partial class rYapcs : Form
    {
        public rYapcs()
        {
            InitializeComponent();
        }

        private void rYapcs_Load(object sender, EventArgs e)
        {
            comboBoxFilmAdi.Items.Add("Uykucu");
            comboBoxFilmAdi.Items.Add("Yan Yana");
            comboBoxFilmAdi.Items.Add("Evcil Hayvanlar Yolda");
            comboBoxFilmAdi.Items.Add("İbi:Uzay Görevi");
            comboBoxFilmAdi.Items.Add("Ölüme Koşan Adam");
            comboBoxSalon.Items.Add("Salon 1");
            comboBoxSalon.Items.Add("Salon 2");
            comboBoxSalon.Items.Add("Salon 3");
            comboBoxSalon.Items.Add("Salon 4");
            comboBoxSeans.Items.Add("11:00");
            comboBoxSeans.Items.Add("13:00");
            comboBoxSeans.Items.Add("15:00");
            comboBoxSeans.Items.Add("17:00");
            comboBoxSeans.Items.Add("21:00");
        }

        private void btnRezYap_Click(object sender, EventArgs e)
        {
           

            Sinemacs s =new Sinemacs();
            s.label5.Text = comboBoxFilmAdi.SelectedItem.ToString();
            s.label6.Text = comboBoxSalon.SelectedItem.ToString();
            s.label7.Text = comboBoxSeans.SelectedItem.ToString();
            
            s.Show();
            this.Hide();
        }
    }
}
