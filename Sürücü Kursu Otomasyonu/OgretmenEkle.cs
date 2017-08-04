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
    public partial class OgretmenEkle : Form
    {
        public OgretmenEkle()
        {
            InitializeComponent();
        }

        private void OgretmenEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textAd.Text != "" || textSoyad.Text != "" || textTc.Text != "" || textTelNo.Text != "" || textAdres.Text != "")
            {
                Ogretmen Ogrt1 = new Ogretmen();
                Ogrt1.OgrtTc = textTc.Text;
                Ogrt1.OgrtAdi = textAd.Text;
                Ogrt1.OgrtSoyadi = textSoyad.Text;
                Ogrt1.OgrtTelNo = textTelNo.Text;
                Ogrt1.OgrtAdres = textAdres.Text;
                if (Ogrt1.OgrtEkle() == true)
                {
                    MessageBox.Show("Öğretmen Bilgileri Başarıyla Eklendi.");

                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");

                }
            }
        }

    }
}
