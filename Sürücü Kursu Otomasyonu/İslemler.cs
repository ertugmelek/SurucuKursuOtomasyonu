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
    }
 }

