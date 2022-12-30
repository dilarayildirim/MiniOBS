﻿using System;
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
    public partial class SinifIslemleri : Form
    {
        public SinifIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            using (MiniOBSEntities context=new MiniOBSEntities())
            {
                Sinif sinif = new Sinif();
                sinif.SinifAd = txtSinifAd.Text;
                context.Sinif.Add(sinif);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydetme Başarılı!");
                    Listele();
                }
                else
                    MessageBox.Show("Kaydetme Başarısız!");
            }
        }

        void Listele()
        {
            using (MiniOBSEntities context = new MiniOBSEntities())
            {
                var liste = from s in context.Sinif select s;
                dataGridView1.DataSource = liste.ToList();
            }
        }

        private void SinifIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Listele();
        }
    }
}
