using Microsoft.Reporting.WinForms;
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
    public partial class OgrenciDersDokumu : Form
    {
        public OgrenciDersDokumu()
        {
            InitializeComponent();
        }
        public OgrenciDersDokumu(List<vOgrenciDers> Liste)
        {
            InitializeComponent();
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear(); //clear report   
            ReportParameter rp = new ReportParameter("OgrenciSayisi", Liste.Count.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
            reportViewer1.LocalReport.ReportEmbeddedResource = "MiniOBS.DersOgrenciDokumu.rdlc"; // bind reportviewer with .rdlc            
            ReportDataSource dataset = new ReportDataSource("DersOgrenciDS", Liste); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }

        private void OgrenciDersDokumu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
