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
    public partial class ogrenciDersSecme : Form
    {
        public ogrenciDersSecme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciDersSecme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilen_ders = "";
            if (checkBox1.Checked == true)
            {
                secilen_ders = secilen_ders + "," + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                secilen_ders = secilen_ders + "," + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                secilen_ders = secilen_ders + "," + checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                secilen_ders = secilen_ders + "," + checkBox4.Text;
            }
            if (checkBox5.Checked == true)
            {
                secilen_ders = secilen_ders + "," + checkBox5.Text;
            }
            label3.Text = secilen_ders;
        }
    }
}
