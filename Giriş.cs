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
    public partial class Giriş : Form
    {
        string[] dosyaici;
        string KullaniciGirisi(string ad, string sifre)
        {
            StreamReader dosyaOku;
            string yazi;
            dosyaOku = File.OpenText("Kullanicilar.txt");

            yazi = dosyaOku.ReadLine();
            while (yazi != null)
            {


                dosyaici = yazi.Split(' ');


                if (ad == dosyaici[0])
                {
                    if (sifre == dosyaici[1])
                    {

                        dosyaOku.Close();
                        return dosyaici[2];

                    }
                    else
                    {
                        dosyaOku.Close();
                        return "SifreHatali";

                    }
                }
                yazi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
            return "KullaniciYok";

        } 
        public Giriş()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
             Personel Kullanici1 = new Personel();
            Kullanici1.KullaniciAdi= txtKullaniciAdi.Text;
            Kullanici1.KullaniciSifre = txtKullaniciSifresi.Text; 
            

            if (Kullanici1.KullaniciGiris()=="Admin")
            {
                    PersonelEkrani admin = new PersonelEkrani();
                    admin.Show();
                    this.Hide();
            }



            if (Kullanici1.KullaniciGiris() == "KullaniciYok")
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunmamaktadır.");
                txtKullaniciAdi.Clear();
                txtKullaniciSifresi.Clear();
            }

            if (Kullanici1.KullaniciGiris() == "SifreHatali")
            {
                MessageBox.Show("Parola Hatalı!");
                txtKullaniciSifresi.Clear();
            }
        
        
        }
    
    }
}
