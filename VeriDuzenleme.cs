using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sürücü_Kursu_Otomasyonu
{
    public partial class VeriDuzenleme : Form
    {
        public VeriDuzenleme()
        {
            InitializeComponent();
        }

        private void VeriDuzenleme_Load(object sender, EventArgs e)
        {
            cbEhliyetSinifi.Items.Add("A1");
            cbEhliyetSinifi.Items.Add("A2");
            cbEhliyetSinifi.Items.Add("B");
            cbEhliyetSinifi.Items.Add("C");
            cbEhliyetSinifi.Items.Add("D");
            cbEhliyetSinifi.Items.Add("E");
            cbEhliyetSinifi.Items.Add("F");
            cbEhliyetSinifi.Items.Add("G");
            cbEhliyetSinifi.Items.Add("H");

            comboBox1.Items.Add("Getirdi");
            comboBox1.Items.Add("Getirmedi");
            comboBox2.Items.Add("Getirdi");
            comboBox2.Items.Add("Getirmedi");
            comboBox3.Items.Add("Getirdi");
            comboBox3.Items.Add("Getirmedi");
            comboBox4.Items.Add("Getirdi");
            comboBox4.Items.Add("Getirmedi");

            string[] Tumİslemler;
            İslemler İslem1 = new İslemler();
            Tumİslemler = İslem1.TumİslemleriGetir().Split('|');
            for (int t = 0; t < Tumİslemler.Length; t++)
            {
                if (Tumİslemler[t] != "")
                {
                    cbKisiler.Items.Add(Tumİslemler[t]);
                }

            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
              if (cbKisiler.Text != "")
            {


                İslemler İslem1 = new İslemler();
                string[] Duzenlencekİslem;
                İslem1.KisiTc = cbKisiler.Text;
                Duzenlencekİslem = İslem1.İslemGetir();
                cbEhliyetSinifi.Text = Duzenlencekİslem[1];
                comboBox1.Text = Duzenlencekİslem[2];
                comboBox2.Text = Duzenlencekİslem[3];
                comboBox3.Text = Duzenlencekİslem[4];
                comboBox4.Text = Duzenlencekİslem[5];
                btnDuzenle.Enabled = true;
            }
              else
              {
                  MessageBox.Show("Lütfen Kimlik Numarası Seçiniz.");
              }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            İslemler İslem2 = new İslemler();
            İslem2.KisiTc = cbKisiler.Text;
            İslem2.SilinecekTc = cbKisiler.Text;
            İslem2.EhliyetSinifi = cbEhliyetSinifi.Text;
            İslem2.SabikaKaydi = comboBox1.Text;
            İslem2.SaglikRaporu = comboBox2.Text;
            İslem2.KimlikFotokopisi = comboBox3.Text;
            İslem2.OgrenciBelgesi = comboBox4.Text;

            if (İslem2.VeriDuzenle() == true)
            {
                MessageBox.Show("Kayıt Başarıyla Düzenlendi");
            }

        }
    }
}
