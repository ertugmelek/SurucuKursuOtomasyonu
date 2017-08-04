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
    public partial class PersonelDüzenle : Form
    {
        
        public PersonelDüzenle()
        {
            InitializeComponent();
        }

        private void PersonelDüzenle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAranan.Text != "")
            {
                Kullanici Kullanici1 = new Kullanici();
                Kullanici1.KullaniciAdi = txtAranan.Text;
                string[] BulunanKullanici;
                BulunanKullanici = Kullanici1.KullaniciAra();

                if (BulunanKullanici[0] == "")
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı.");
                }
                else
                {
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
                MessageBox.Show("Düzenlenecek Kullanıcı Adını Giriniz.");

            }
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text!="" && txtKullaniciSifresi.Text!=""){
                if (rbAdmin.Checked)
                {
                    Admin Admin1 = new Admin();
                    Admin1.KullaniciAdi = txtKullaniciAdi.Text;
                    Admin1.KullaniciSifre = txtKullaniciSifresi.Text;
                    Admin1.AdminDuzenle();
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Güncellendi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
        }
    }
}
