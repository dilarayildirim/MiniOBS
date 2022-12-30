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
    public partial class YoklamaFormu : Form
    {
        public YoklamaFormu()
        {
            InitializeComponent();
        }

        public YoklamaFormu(List<vOgrenci> liste)
        {
            InitializeComponent();
            reportViewer1.RefreshReport();            
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "MiniOBS.Yoklama.rdlc"; // bind reportviewer with .rdlc            
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", liste); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);            
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }

      
    }
}
