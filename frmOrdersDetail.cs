using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Gentry
{
    public partial class frmOrdersDetail : MetroFramework.Forms.MetroForm
    {
        public frmOrdersDetail()
        {
            InitializeComponent();
        }

        private void ListOfCustomerRptForm_Load(object sender, EventArgs e)
        {
            if (frmOrderBetweenDates.param_from != "" && frmOrderBetweenDates.param_to!="")
            {
                string from = frmOrderBetweenDates.param_from;
                string to = frmOrderBetweenDates.param_to;

                ReportDocument rpt = new ReportDocument();
                rpt.Load("Z:/CSharpProjects/Gentry/Gentry/Reports/RptOrdersDetail.rpt");
                crystalReportViewer.ReportSource = null;
                crystalReportViewer.ReportSource = rpt;
                rpt.SetParameterValue("from", from);
                rpt.SetParameterValue("to", to);
                crystalReportViewer.Refresh();
            }
            else 
            {
                MessageBox.Show("Please Select an Order First.");
            }


        }
    }
}
