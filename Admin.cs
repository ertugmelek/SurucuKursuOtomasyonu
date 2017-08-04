using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sürücü_Kursu_Otomasyonu
{
    class Admin : Personel
    {
        public bool AdminEkle()
        {
            StreamReader dosyaYaz;
            string yazi;
            string[] dosyaici;
            bool kontrol;
            kontrol = false;

            dosyaYaz = File.OpenText("Kullanicilar.txt");

            yazi = dosyaYaz.ReadLine();
            while (yazi != null)
            {
                dosyaici = yazi.Split('|');

                if (KullaniciAdi == dosyaici[0])
                {
                    kontrol = true;

                }
                yazi = dosyaYaz.ReadLine();
            }
            dosyaYaz.Close();



            if (kontrol != true)
            {
                StreamWriter dosya;
                dosya = File.AppendText("Kullanicilar.txt");

                dosya.WriteLine(KullaniciAdi + "|" + KullaniciSifre + "|" + "Admin");
                dosya.Close();
                return true;


            }
            else
            {
                return false;
            }
        }

        public void AdminSil()
        {
            StreamWriter dosyaYaz;
            string[] dosyaici;
            StreamReader dosyaOku;
            string satir;

            dosyaOku = File.OpenText("Kullanicilar.txt");
            dosyaYaz = File.AppendText("Temp.txt");




            satir = dosyaOku.ReadLine();
            while (satir != null)
            {

                dosyaici = satir.Split('|');


                if (KullaniciAdi != dosyaici[0])
                {
                    dosyaYaz.WriteLine(dosyaici[0] + "|" + dosyaici[1] + "|" + dosyaici[2]);
                }

                satir = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
            dosyaYaz.Close();

            File.Delete("Kullanicilar.txt");
            File.Move("Temp.txt", "Kullanicilar.txt");






        }

        public void AdminDuzenle()
        {
            AdminSil();
            AdminEkle();
        }
    }
}
