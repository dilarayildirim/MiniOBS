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
    public partial class DenemeRapor2 : Form
    {
        public DenemeRapor2()
        {
            InitializeComponent();
        }

        private void DenemeRapor2_Load(object sender, EventArgs e)
        {

            MiniOBSEntities vt = new MiniOBSEntities();
            List<vOgrenciNot> ogrenciNotListem = vt.vOgrenciNot.ToList();
            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "MiniOBS.Report2.rdlc";
            ReportDataSource dataset = new ReportDataSource("DataSetOgrenciNot", ogrenciNotListem);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
