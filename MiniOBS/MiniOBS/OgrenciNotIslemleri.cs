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
    public partial class OgrenciNotIslemleri : Form
    {
        public OgrenciNotIslemleri()
        {
            InitializeComponent();
        }

        public int OgrenciID { get; set; }
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
                var liste = from s in context.vOgrenciDers where s.OgrenciId==OgrenciID select s;
                cbDers.DataSource = liste.ToList();
            }
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.vOgrenciNot where s.OgrenciId == OgrenciID select s;
                dataGridView1.DataSource = liste.ToList();
            }
        }

        private void OgrenciNotIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnNotuKaydet_Click(object sender, EventArgs e)
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                OgrenciNot od = new OgrenciNot();
                od.OgrenciId = OgrenciID;
                if (cbDers.SelectedValue != null)
                    od.DersId = Convert.ToInt32(cbDers.SelectedValue);
                od.SinavTuru = txtSinavTuru.Text;
                od.SinavNotu = txtSinavNotu.Text;
                context.OgrenciNot.Add(od);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydetme Başarılı!");
                    using (MiniOBSEntities c = new MiniOBSEntities())
                    {
                        var liste = from s in c.vOgrenciNot where s.OgrenciId == OgrenciID select s;
                        dataGridView1.DataSource = liste.ToList();
                    }
                }
                else
                    MessageBox.Show("Kaydetme Başarısız!");
            }
        }
    }
}
