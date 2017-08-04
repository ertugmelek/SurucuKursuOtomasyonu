using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sürücü_Kursu_Otomasyonu
{
    public class Kisi
    {
        public string KisiAdi;
        public string KisiSoyadi;
        public string KisiTc;
        public string KisiTelNo;
        public string KisiAdres;
        private string TumKisiler;
        public string SilinecekTc;

        public bool KayitEkle()
        {
            StreamReader dosyaYaz;
            string yazi;
            string[] dosyaici;
            bool kontrol;
            kontrol = false;

            dosyaYaz = File.OpenText("Kisiler.txt");

            yazi = dosyaYaz.ReadLine();
            while (yazi != null)
            {
                dosyaici = yazi.Split('|');

                if (KisiAdi == dosyaici[0])
                {
                    kontrol = true;
                }
                yazi = dosyaYaz.ReadLine();
            }
            dosyaYaz.Close();

            if (kontrol != true)
            {
                StreamWriter dosya;
                dosya = File.AppendText("Kisiler.txt");

                dosya.WriteLine(KisiTc + "|" + KisiAdi + "|" + KisiSoyadi + "|" + KisiTelNo + "|" + KisiAdres);
                dosya.Close();
                return true;

            }
            else
            {
                return false;
            }

        }   
        
         public bool KayitSil()
        {
            StreamWriter dosyaYaz;
            string[] dosyaici;
            StreamReader dosyaOku;
            string satir;
            bool kontrol;
            kontrol = false;
            dosyaOku = File.OpenText("Kisiler.txt");
            dosyaYaz = File.AppendText("TempKisi.txt");

            satir = dosyaOku.ReadLine();
            while (satir != null)
            {

                dosyaici = satir.Split('|');


                if (SilinecekTc != dosyaici[0])
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

            File.Delete("Kisiler.txt");
            File.Move("TempKisi.txt", "Kisiler.txt");
            return kontrol;
        }

         public bool KayitDuzenle()
         {

             if (KayitSil() == true)
             {
                 if (KayitEkle() == true)
                 {
                     return true;
                 }
             }
             return false;
         }

         public string TumKisileriGetir()
         {
             StreamReader dosyaOku;
             string yazi;
             string[] dosyaici;
             TumKisiler = "";
             dosyaOku = File.OpenText("Kisiler.txt");

             yazi = dosyaOku.ReadLine();
             while (yazi != null)
             {

                 dosyaici = yazi.Split('|');


                 if (dosyaici[0] != "")
                 {
                     TumKisiler += dosyaici[0] + "|";

                 }
                 yazi = dosyaOku.ReadLine();
             }
             dosyaOku.Close();
             return TumKisiler;
         }

         public string[] KisiGetir()
         {
             StreamReader dosyaOku;
             string yazi;
             string[] dosyaici, yok;
             yok = "".Split(' ');
             dosyaOku = File.OpenText("Kisiler.txt");

             yazi = dosyaOku.ReadLine();
             while (yazi != null)
             {

                 dosyaici = yazi.Split('|');


                 if (KisiAdi == dosyaici[0])
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
