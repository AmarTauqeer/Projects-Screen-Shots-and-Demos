using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentry
{
    public partial class UserInfo : MetroFramework.Forms.MetroForm
    {
        TestEntities test;
        public UserInfo()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtUserId.Focus();
                tblUser u = new tblUser();
                test.tblUsers.Add(u);
                tblUserBindingSource.Add(u);
                tblUserBindingSource.MoveLast();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtUserId.Focus();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            tblUserBindingSource.ResetBindings(false);
            
            foreach(DbEntityEntry entry in test.ChangeTracker.Entries())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tblUserBindingSource.EndEdit();
                test.SaveChanges();
                panel.Enabled = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tblUserBindingSource.ResetBindings(false);
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                metroGrid.DataSource = tblUserBindingSource;
            }
            else 
            {
                var query = from o in tblUserBindingSource.DataSource as List<tblUser>
                            where o.UserName == txtSearch.Text || o.FullName.Contains(txtSearch.Text)||o.Email.Contains(txtSearch.Text)
                            select o;
                metroGrid.DataSource= query.ToList();
            }

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;
            test = new TestEntities();
            tblUserBindingSource.DataSource = test.tblUsers.ToList();
        }

        private void metroGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                if(MessageBox.Show("Are you sure want to delete this record ?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    test.tblUsers.Remove(tblUserBindingSource.Current as tblUser);
                    tblUserBindingSource.RemoveCurrent();

                }
            }
        }

        private void metroGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==2)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                else
                    e.Value = null;
                
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                else
                    e.Value = null;

            }

        }

    }
}
