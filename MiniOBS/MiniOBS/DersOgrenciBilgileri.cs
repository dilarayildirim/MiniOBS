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
    public partial class DersOgrenciBilgileri : Form
    {
        public DersOgrenciBilgileri()
        {
            InitializeComponent();
        }

        private void DersOgrenciBilgileri_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;         
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.Ders select s;
                cbDers.DataSource = liste.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using (MiniOBSEntities context = new MiniOBSEntities())
            //{
            //    int secilenDersID = Convert.ToInt32(cbDers.SelectedValue);
            //    var liste = from s in context.vOgrenciDers where s.DersId ==secilenDersID select s;
            //    dataGridView1.DataSource = liste.ToList();
            //}

            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.vOgrenciDers where s.DersId == 7 && s.SinifId > 5 select s;
                dataGridView1.DataSource = liste.ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<vOgrenciDers> dersOgrenciListesi = dataGridView1.DataSource as List<vOgrenciDers>;
            OgrenciDersDokumu odk = new OgrenciDersDokumu(dersOgrenciListesi);
            odk.MdiParent = this.ParentForm;
            odk.Show();
        }
    }
}
