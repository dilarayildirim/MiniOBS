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
    public partial class OgrenciDersIslemleri : Form
    {
        public OgrenciDersIslemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.vOgrenci where s.OgrenciNo == textBox1.Text select s;
                lblOgrenciAdsoyad.Text = liste.ToList()[0].Ad + " " + liste.ToList()[0].Soyad;
                lblOgrenciNo.Text = liste.ToList()[0].OgrenciNo;
                OgrenciID = liste.ToList()[0].OgrenciID;
            }
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.vOgrenciDers where s.OgrenciId == OgrenciID select s;
                dataGridView1.DataSource = liste.ToList();
            }
        }

        private void OgrenciDersIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.Ders select s;
                cbDers.DataSource = liste.ToList();
            }
        }

        public int OgrenciID { get; set; }
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                OgrenciDers od = new OgrenciDers();
                od.OgrenciId = OgrenciID;       
                if (cbDers.SelectedValue != null)
                    od.DersId= Convert.ToInt32(cbDers.SelectedValue);                
                context.OgrenciDers.Add(od);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydetme Başarılı!");
                    using (MiniOBSEntities c = new MiniOBSEntities())
                    {
                        var liste = from s in c.vOgrenciDers where s.OgrenciId == OgrenciID select s;
                        dataGridView1.DataSource = liste.ToList();
                    }
                }
                else
                    MessageBox.Show("Kaydetme Başarısız!");
            }
        }
    }
}
