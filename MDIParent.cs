using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Gentry
{
    public partial class MDIParent : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category frm = new Category();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product frm = new Product();
            frm.MdiParent = this;
            frm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer frm = new Customer();
            frm.MdiParent = this;
            frm.Show();

        }
        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleOrder frm = new SaleOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listOfCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfCustomer frm = new frmListOfCustomer();
            frm.MdiParent = this;
            frm.Show();

        }

        private void listOfCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfCategory frm = new frmListOfCategory();
            frm.MdiParent = this;
            frm.Show();

        }

        private void listOfProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfProduct frm = new frmListOfProduct();
            frm.MdiParent = this;
            frm.Show();

        }

        private void ordersDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderBetweenDates frm = new frmOrderBetweenDates();
            frm.MdiParent = this;
            frm.Show();

        }

        private void productDetailDateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDateWiseProductDetail frm = new frmDateWiseProductDetail();
            frm.MdiParent = this;
            frm.Show();

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo frm = new UserInfo();
            frm.MdiParent = this;
            frm.Show();

        }

    }
}
