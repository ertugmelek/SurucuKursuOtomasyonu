using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sürücü_Kursu_Otomasyonu
{
    class Personel
    {
        public string KullaniciAdi;
        public string KullaniciSifre;

        public string KullaniciGiris()
        {
            StreamReader dosyaOku;
            string[] dosyaici;
            string yazi;
            dosyaOku = File.OpenText("Kullanicilar.txt");

            yazi = dosyaOku.ReadLine();
            while (yazi != null)
            {


                dosyaici = yazi.Split('|');


                if (KullaniciAdi == dosyaici[0])
                {
                    if (KullaniciSifre == dosyaici[1])
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

        public string[] KullaniciAra()
        {
            StreamReader dosyaOku;
            string yazi;
            string[] dosyaici, yok;
            yok = "".Split(' ');
            dosyaOku = File.OpenText("Kullanicilar.txt");

            yazi = dosyaOku.ReadLine();
            while (yazi != null)
            {

                dosyaici = yazi.Split('|');


                if (KullaniciAdi == dosyaici[0])
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
