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
    public partial class KayitEkle : Form
    {
        public KayitEkle()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (textAd.Text != "" || textSoyad.Text != "" || textTC.Text != "" || msktextTelNo.Text != "" || textAdres.Text != "")
            {
                Kisi Kisi1 = new Kisi();
                Kisi1.KisiTc = textTC.Text;
                Kisi1.KisiAdi = textAd.Text;
                Kisi1.KisiSoyadi = textSoyad.Text;
                Kisi1.KisiTelNo = msktextTelNo.Text;
                Kisi1.KisiAdres = textAdres.Text;
                if (Kisi1.KayitEkle() == true)
                {
                    MessageBox.Show("Öğrenci Bilgileri Başarıyla Eklendi.");
                   
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");

                }
            }

        }

        private void KayitEkle_Load(object sender, EventArgs e)
        {

        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
               
                if (textTC.Text.Length > 11)
                {
                    MessageBox.Show("11 haneden uzun olamaz.");
                    textTC.Text = textTC.Text.Substring(0, (textTC.Text.Length - 1));
                }
                if (textTC.Text.Length > 0)
                {
                    int numberEntered = int.Parse(textTC.Text[textTC.Text.Length - 1].ToString());
                    if (numberEntered < 0 || numberEntered > 10)
                    {
                        MessageBox.Show("Bir sayı giriniz");
                        textTC.Text = textTC.Text.Substring(0, (textTC.Text.Length - 1));
                    }
                }
                
            }
            catch (FormatException)
            {

                MessageBox.Show("bir sayı giriniz");
                textTC.Text = textTC.Text.Substring(0, (textTC.Text.Length - 1));
            }
        }

        private void textTC_KeyPress(object sender, KeyPressEventArgs e)
        {


            
        }

  
     
    }
}
