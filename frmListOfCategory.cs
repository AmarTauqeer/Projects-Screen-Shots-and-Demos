﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Gentry
{
    public partial class frmListOfCategory : MetroFramework.Forms.MetroForm
    {
        public frmListOfCategory()
        {
            InitializeComponent();
        }

        private void ListOfCustomerRptForm_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load("Z:/CSharpProjects/Gentry/Gentry/Reports/RptListofCategory.rpt");
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.ReportSource = rpt;
            crystalReportViewer.Refresh();


        }
    }
}
