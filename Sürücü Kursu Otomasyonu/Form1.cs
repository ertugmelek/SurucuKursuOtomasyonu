using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sinema_Otomasyon
{
    public partial class Form1 : Form
    {
string[] dosyaici;
        string KullaniciGirisi(string ad,string sifre)
        {
            StreamReader dosyaOku;
            string yazi;
            dosyaOku = File.OpenText("Kullanicilar.txt");

            yazi = dosyaOku.ReadLine();
           while(yazi!=null){
             

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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad, sifre;
            ad = txtKullaniciAdi.Text;
            sifre = txtKullaniciSifresi.Text;
            if (KullaniciGirisi(ad, sifre)=="Admin")
            {
                    AdminEkrani admin = new AdminEkrani();
                    admin.Show();
                    this.Hide();
            }

            if (KullaniciGirisi(ad, sifre) == "KullaniciYok")
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunmamaktadır.");
                txtKullaniciAdi.Clear();
                txtKullaniciSifresi.Clear();
            }

            if (KullaniciGirisi(ad, sifre) == "SifreHatali")
            {
                MessageBox.Show("Parola Hatalı!");
                txtKullaniciSifresi.Clear();
            }

        }
    }
}
