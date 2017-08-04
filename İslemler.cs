using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sürücü_Kursu_Otomasyonu
{
    class İslemler : Kisi
    {
        
        public string EhliyetSinifi;
        public string SabikaKaydi;
        public string SaglikRaporu;
        public string KimlikFotokopisi;
        public string OgrenciBelgesi;
        private string Tumİslemler;

        public bool VeriKaydet()
        {
            StreamReader dosyaYaz;
            string yazi;
            string[] dosyaici;
            bool kontrol;
            kontrol = false;

            dosyaYaz = File.OpenText("İslemler.txt");

            yazi = dosyaYaz.ReadLine();
            while (yazi != null)
            {
                dosyaici = yazi.Split('|');

                if (KisiTc == dosyaici[0])
                {
                    kontrol = true;
                }
                yazi = dosyaYaz.ReadLine();
            }
            dosyaYaz.Close();

            if (kontrol != true)
            {
                StreamWriter dosya;
                dosya = File.AppendText("İslemler.txt");

                dosya.WriteLine(KisiTc + "|" + EhliyetSinifi + "|" + SabikaKaydi + "|" + SaglikRaporu + "|" + KimlikFotokopisi + "|" + OgrenciBelgesi);
                dosya.Close();
                return true;

            }
            else
            {
                return false;
            }


        }

        public bool VeriSil()
        {
            StreamWriter dosyaYaz;
            string[] dosyaici;
            StreamReader dosyaOku;
            string satir;
            bool kontrol;
            kontrol = false;
            dosyaOku = File.OpenText("İslemler.txt");
            dosyaYaz = File.AppendText("Tempİslem.txt");

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

            File.Delete("İslemler.txt");
            File.Move("Tempİslem.txt", "İslemler.txt");
            return kontrol;
        }
        
        public bool VeriDuzenle()
        {

            if (VeriSil() == true)
            {
                if (VeriKaydet() == true)
                {
                    return true;
                }
            }
            return false;
        }

        public string TumİslemleriGetir()
        {
            StreamReader dosyaOku;
            string yazi;
            string[] dosyaici;
            Tumİslemler = "";
            dosyaOku = File.OpenText("İslemler.txt");

            yazi = dosyaOku.ReadLine();
            while (yazi != null)
            {

                dosyaici = yazi.Split('|');


                if (dosyaici[0] != "")
                {
                    Tumİslemler += dosyaici[0] + "|";

                }
                yazi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
            return Tumİslemler;
        }

        public string[] İslemGetir()
        {
            StreamReader dosyaOku;
            string yazi;
            string[] dosyaici, yok;
            yok = "".Split(' ');
            dosyaOku = File.OpenText("İslemler.txt");

            yazi = dosyaOku.ReadLine();
            while (yazi != null)
            {

                dosyaici = yazi.Split('|');


                if (KisiTc == dosyaici[0])
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

