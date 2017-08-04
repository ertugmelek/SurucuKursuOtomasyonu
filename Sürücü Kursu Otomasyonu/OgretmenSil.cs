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
    public partial class OgretmenSil : Form
    {
        public OgretmenSil()
        {
            InitializeComponent();
        }

        private void OgretmenSil_Load(object sender, EventArgs e)
        {
            string[] TumOgretmenler;
            Ogretmen Ogrt1 = new Ogretmen();
            TumOgretmenler = Ogrt1.TumOgretmenleriGetir().Split('|');
            for (int t = 0; t < TumOgretmenler.Length; t++)
            {
                if (TumOgretmenler[t] != "")
                {
                    cbOgretmenler.Items.Add(TumOgretmenler[t]);
                }
            }
            
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (cbOgretmenler.Text != "")
            {
                Ogretmen Ogrt2 = new Ogretmen();
                Ogrt2.SilinecekOgrt = cbOgretmenler.Text;
                if (Ogrt2.OgretmenSil() == true)
                {
                    MessageBox.Show("Öğretmen Bilgileri Başarı İle Silindi.");
                    this.Hide();
                }
               
            }
        }
    }
}
