using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniOBS
{
    public partial class OgrenciEklemeFormu : Form
    {
        public OgrenciEklemeFormu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                Ogrenci ogr = new Ogrenci();
                ogr.OgrenciNo = txtOgrenciNo.Text;
                ogr.Ad = txtOgrenciAd.Text;
                ogr.Soyad = txtOgrenciSoyad.Text;
                if (cbSinif.SelectedValue != null)
                    ogr.SinifId = Convert.ToInt32(cbSinif.SelectedValue);
                ogr.Cinsiyet = rbErkek.Checked ? "Erkek" : "Kadın";
                ogr.Telefon = txtTelefon.Text;
                ogr.DogumTarihi = dtDogumTarihi.Value;
                //MemoryStream ms = new MemoryStream();
                //pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                //ogr.Resim = ms.ToArray();
                context.Ogrenci.Add(ogr);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydetme Başarılı!");                    
                }
                else
                    MessageBox.Show("Kaydetme Başarısız!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = dlg.FileName;
            }
        }

        private void OgrenciEklemeFormu_Load(object sender, EventArgs e)
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.Sinif select s;
                cbSinif.DataSource = liste.ToList();
            }
        }
    }
}
