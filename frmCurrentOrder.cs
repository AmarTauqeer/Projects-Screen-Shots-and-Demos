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
    public partial class frmCurrentOrder : MetroFramework.Forms.MetroForm
    {
        public frmCurrentOrder()
        {
            InitializeComponent();
        }

        private void ListOfCustomerRptForm_Load(object sender, EventArgs e)
        {
            int ordid = 0;
            if (SaleOrder.param_ordid != "")
            {
                ordid = Convert.ToInt32(SaleOrder.param_ordid);
                ReportDocument rpt = new ReportDocument();
                rpt.Load("Z:/CSharpProjects/Gentry/Gentry/Reports/RptOrder.rpt");
                crystalReportViewer.ReportSource = null;
                crystalReportViewer.ReportSource = rpt;
                rpt.SetParameterValue("ordid", ordid);
                crystalReportViewer.Refresh();
            }
            else 
            {
                MessageBox.Show("Please Select an Order First.");
            }


        }
    }
}
