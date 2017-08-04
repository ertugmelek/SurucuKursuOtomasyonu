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
    public partial class PersonelSil : Form
    {
        public PersonelSil()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtAranan.Text != "")
            {
                Personel Kullanici1 = new Personel();
                Kullanici1.KullaniciAdi = txtAranan.Text;
                string[] BulunanKullanici;
                BulunanKullanici = Kullanici1.KullaniciAra();

                if (BulunanKullanici[0] == "")
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı.");
                }
                else
                {
                    btnSil.Enabled = true;
                    txtKullaniciAdi.Text = BulunanKullanici[0];
                    txtKullaniciSifresi.Text = BulunanKullanici[1];
                    if (BulunanKullanici[2] == "Admin")
                    {
                        rbAdmin.Checked = true;

                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek Perssonelin Kullanıcı Adını Giriniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                Admin Admin1 = new Admin();
                Admin1.KullaniciAdi = txtKullaniciAdi.Text;
                Admin1.AdminSil();
                MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Silindi.");
            }
        }
    }
}
