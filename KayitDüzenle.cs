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
    public partial class KayitDüzenle : Form
    {
        public KayitDüzenle()
        {
            InitializeComponent();
        }

        private void KayitDüzenle_Load(object sender, EventArgs e)
        {
            string[] TumKisiler;
            Kisi Kisi1 = new Kisi();
            TumKisiler = Kisi1.TumKisileriGetir().Split('|');
            for (int t = 0; t < TumKisiler.Length; t++)
            {
                if (TumKisiler[t] != "")
                {
                    cbKisiler.Items.Add(TumKisiler[t]);
                }

            }
        }

        private void bul_Click(object sender, EventArgs e)
        {
            if (cbKisiler.Text != "")
            {


                Kisi Kisi1 = new Kisi();
                string[] DuzenlencekKisi;
                Kisi1.KisiAdi = cbKisiler.Text;
                DuzenlencekKisi = Kisi1.KisiGetir();
                textAd.Text = DuzenlencekKisi[1];
                textSoyad.Text = DuzenlencekKisi[2];
                msktextTelNo.Text = DuzenlencekKisi[3];
                textAdres.Text = DuzenlencekKisi[4];
                btnDuzenle.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Kimlik Numarası Seçiniz.");
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Kisi Kisi2 = new Kisi();
            Kisi2.KisiTc = cbKisiler.Text;
            Kisi2.SilinecekTc = cbKisiler.Text;
            Kisi2.KisiAdi = textAd.Text;
            Kisi2.KisiSoyadi = textSoyad.Text;
            Kisi2.KisiTelNo = msktextTelNo.Text;
            Kisi2.KisiAdres = textAdres.Text;

            if (Kisi2.KayitDuzenle() == true)
            {
                MessageBox.Show("Kayıt Başarıyla Düzenlendi");
            }

        }


    }
}
