using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sürücü_Kursu_Otomasyonu
{
    public class Ogretmen
    
        {
        public string OgrtAdi;
        public string OgrtSoyadi;
        public string OgrtTc;
        public string OgrtTelNo;
        public string OgrtAdres;
        private string TumOgretmenler;
        public string SilinecekOgrt;

        public bool OgrtEkle()
        {
            StreamReader dosyaYaz;
            string yazi;
            string[] dosyaici;
            bool kontrol;
            kontrol = false;

            dosyaYaz = File.OpenText("Ogretmenler.txt");

            yazi = dosyaYaz.ReadLine();
            while (yazi != null)
            {
                dosyaici = yazi.Split('|');

                if (OgrtAdi == dosyaici[0])
                {
                    kontrol = true;
                }
                yazi = dosyaYaz.ReadLine();
            }
            dosyaYaz.Close();

            if (kontrol != true)
            {
                StreamWriter dosya;
                dosya = File.AppendText("Ogretmenler.txt");

                dosya.WriteLine(OgrtAdi + "|" + OgrtSoyadi + "|" + OgrtTc + "|" + OgrtTelNo + "|" + OgrtAdres);
                dosya.Close();
                return true;

            }
                
            else
            {
                return false;
            }

        }
        public bool OgretmenSil()
        {
            StreamWriter dosyaYaz;
            string[] dosyaici;
            StreamReader dosyaOku;
            string satir;
            bool kontrol;
            kontrol = false;
            dosyaOku = File.OpenText("Ogretmenler.txt");
            dosyaYaz = File.AppendText("TempOgrt.txt");

            satir = dosyaOku.ReadLine();
            while (satir != null)
            {

                dosyaici = satir.Split('|');


                if (SilinecekOgrt != dosyaici[0])
                {
                    dosyaYaz.WriteLine(satir);
                }
                else
                {
                    kontrol = true;
                }
                satir = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
            dosyaYaz.Close();

            File.Delete("Ogretmenler.txt");
            File.Move("TempOgrt.txt", "Ogretmenler.txt");
            return kontrol;
        }
        public string TumOgretmenleriGetir()
         {
             StreamReader dosyaOku;
             string yazi;
             string[] dosyaici;
             TumOgretmenler = "";
             dosyaOku = File.OpenText("Ogretmenler.txt");

             yazi = dosyaOku.ReadLine();
             while (yazi != null)
             {

                 dosyaici = yazi.Split('|');


                 if (dosyaici[0] != "")
                 {
                     TumOgretmenler += dosyaici[0] + "|";

                 }
                 yazi = dosyaOku.ReadLine();
             }
             dosyaOku.Close();
             return TumOgretmenler;
         }

         public string[] OgretmenGetir()
         {
             StreamReader dosyaOku;
             string yazi;
             string[] dosyaici, yok;
             yok = "".Split(' ');
             dosyaOku = File.OpenText("Ogretmenler.txt");

             yazi = dosyaOku.ReadLine();
             while (yazi != null)
             {

                 dosyaici = yazi.Split('|');


                 if (OgrtAdi == dosyaici[0])
                 {
                     dosyaOku.Close();
                     return dosyaici;

                 }
                 yazi = dosyaOku.ReadLine();
             }
             dosyaOku.Close();
             return yok;
         }
    }
}
