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
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
        }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitEkle kytEkle = new KayitEkle();
            kytEkle.Show();
        }

        private void kayıtDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitDüzenle kytDuzenle = new KayitDüzenle();
            kytDuzenle.Show();
        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitSil kytSil = new KayitSil();
            kytSil.Show();
        }

        private void öğretmenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgretmenEkle ogrtEkle = new OgretmenEkle();
            ogrtEkle.Show();
        }


        private void öğretmenSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgretmenSil ogrtSil = new OgretmenSil();
            ogrtSil.Show();
        }

        private void dersProgramıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersProgrami dersprog = new DersProgrami();
            dersprog.Show();
        }

        private void sınavTakvimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinavTakvimi snvtakvim = new SinavTakvimi();
            snvtakvim.Show();
        }

     

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle prsEkle = new PersonelEkle();
            prsEkle.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelDüzenle prsDuzenle = new PersonelDüzenle();
            prsDuzenle.Show();
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSil prsSil = new PersonelSil();
            prsSil.Show();
        }

        private void veriKaydetmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeriKaydetme ehlytİslem = new VeriKaydetme();
            ehlytİslem.Show();
        }

        private void PersonelEkrani_Load(object sender, EventArgs e)
        {

        }

       

 
        


    
    }
}
