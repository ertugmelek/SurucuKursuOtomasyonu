using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sürücü_Kursu_Otomasyonu
{
    public partial class VeriKaydetme : Form
    {
        public VeriKaydetme()
        {
            InitializeComponent();
        }

 
        private void VeriKaydetme_Load(object sender, EventArgs e)
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


            string[] TumKisiler;
            Kisi Kisi2 = new Kisi();
            TumKisiler = Kisi2.TumKisileriGetir().Split('|');
            for (int t = 0; t < TumKisiler.Length; t++)
            {
                if (TumKisiler[t] != "")
                {
                    cbKisiler.Items.Add(TumKisiler[t]);
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbKisiler.Text != "" || cbEhliyetSinifi.Text != "")
            {
                İslemler İslem1 = new İslemler();
                İslem1.KisiTc = cbKisiler.Text;
                İslem1.EhliyetSinifi = cbEhliyetSinifi.Text;
                İslem1.EhliyetSinifi = cbEhliyetSinifi.Text;
                İslem1.SabikaKaydi = comboBox1.Text;
                İslem1.SaglikRaporu = comboBox2.Text;
                İslem1.KimlikFotokopisi = comboBox3.Text;
                İslem1.OgrenciBelgesi = comboBox4.Text;
                if (İslem1.VeriKaydet() == true)
                {
                    MessageBox.Show("Bilgiler Başarıyla Eklendi.");

                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");

                }
                          
            }

            }

        }

        }


    
