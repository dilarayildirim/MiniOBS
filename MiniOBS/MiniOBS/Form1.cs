using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniOBS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öğrenciKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEklemeFormu ogrForm = new OgrenciEklemeFormu();
            ogrForm.MdiParent = this;
            ogrForm.Show();
        }

        private void dersEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersIslemleri dersForm = new DersIslemleri();
            dersForm.MdiParent = this;
            dersForm.Show();
        }

        private void sınıfEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinifIslemleri sinifForm = new SinifIslemleri();
            sinifForm.MdiParent = this;
            sinifForm.Show();
        }

        private void notİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListeFormu listeForm = new OgrenciListeFormu();
            listeForm.MdiParent = this;
            listeForm.Show();
        }

        private void öğrenciDersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciDersIslemleri ogr = new OgrenciDersIslemleri();
            ogr.MdiParent = this;
            ogr.Show();
        }

        private void öğrenciNotİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciNotIslemleri ogr = new OgrenciNotIslemleri();
            ogr.MdiParent = this;
            ogr.Show();
        }

        private void dersÖğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersOgrenciBilgileri ogr = new DersOgrenciBilgileri();
            ogr.MdiParent = this;
            ogr.Show();
        }
    }
}
