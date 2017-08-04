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
    public partial class PersonelEkle : Form
    {
        
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtKullaniciSifresi.Text != "")
            {
                if (rbAdmin.Checked)
                {
                    Admin Admin1 = new Admin();
                    Admin1.KullaniciAdi = txtKullaniciAdi.Text;
                    Admin1.KullaniciSifre = txtKullaniciSifresi.Text;
                    if (Admin1.AdminEkle() == true)
                    {
                        MessageBox.Show("Admin Sisteme Başarılı Bir Şekilde Eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Eklenmek İstenen Admin Daha Önce Sisteme Eklenmiş.");
                    }
                }
            }

        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
