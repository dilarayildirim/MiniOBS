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
    public partial class OgrenciListeFormu : Form
    {
        public OgrenciListeFormu()
        {
            InitializeComponent();
        }

        private void OgrenciListeFormu_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Listele();
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.Sinif select s;
                cbSinif.DataSource = liste.ToList();
            }
        }

        private void Listele()
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.vOgrenci select s;
                dataGridView1.DataSource = liste.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.vOgrenciDers where s.OgrenciNo == "1436167" || s.DersId == 2  select s;
                dataGridView1.DataSource = liste.ToList();
            }
        }

        private void yeniÖğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEklemeFormu ogr = new OgrenciEklemeFormu();
            ogr.MdiParent = this.ParentForm;
            ogr.Show();

        }


        private void öğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string secilenOgrenciId = dataGridView1.Rows[secilenSatir].Cells["OgrenciNo"].Value.ToString();
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.vOgrenci where s.OgrenciNo == secilenOgrenciId select s;
                secilenOgrenci = liste.ToList()[0];
                printDocument1.Print();
            }
        }

        vOgrenci secilenOgrenci = null;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font yaziTipi = new Font("Tahoma", 16, FontStyle.Bold);
            e.Graphics.DrawString("Ad:" + secilenOgrenci.Ad, yaziTipi, Brushes.Red, 50, 100);
            e.Graphics.DrawString("Soyad:" + secilenOgrenci.Soyad, yaziTipi, Brushes.Blue, 50, 150);
            e.Graphics.DrawString(secilenOgrenci.SinifAd, yaziTipi, Brushes.Black, 50, 200);
            e.Graphics.DrawString(secilenOgrenci.Cinsiyet, yaziTipi, Brushes.Green, 50, 250);

            Font yazitipi2 = new Font("Times New Roman", 32, FontStyle.Underline);
            e.Graphics.DrawString("Öğrenci Bilgileri", yazitipi2, Brushes.Yellow, 50, 30);

        }

        int secilenSatir = 0;



        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                secilenSatir = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             List<vOgrenci> yoklamaListesi = new List<vOgrenci>();
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                int id = Convert.ToInt32(cbSinif.SelectedValue);
                var liste = from s in context.vOgrenci where s.SinifId == id select s;
                foreach (var item in liste)
                {
                    vOgrenci vo = item as vOgrenci;
                    yoklamaListesi.Add(vo);
                }
            }
            YoklamaFormu yf = new YoklamaFormu(yoklamaListesi);
            yf.MdiParent = this.ParentForm;
            yf.Show();
        }

        private void cbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
