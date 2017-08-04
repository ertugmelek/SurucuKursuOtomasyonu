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
    public partial class KayitSil : Form
    {
        public KayitSil()
        {
            InitializeComponent();
        }

        private void KayitSil_Load(object sender, EventArgs e)
        {
             string[] TumKisiler;
            Kisi Kisi1 = new Kisi();
            TumKisiler = Kisi1.TumKisileriGetir().Split('|');
            for (int t = 0; t < TumKisiler.Length; t++)
            {
                if (TumKisiler[t] != "")
                {
                    cbKisiler.Items.Add(TumKisiler[t]);
                }
            }
            
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (cbKisiler.Text != "")
            {
                Kisi Kisi2 = new Kisi();
                Kisi2.SilinecekTc = cbKisiler.Text;
             if (Kisi2.KayitSil() == true)
                {
                    
                    MessageBox.Show("Kişi Başarı İle Silindi.");
                    this.Hide();
                }
                
            }

        }
    }
}
