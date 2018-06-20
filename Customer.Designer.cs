namespace Gentry
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomer = new MetroFramework.Controls.MetroGrid();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDesignation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCustomer,
            this.txtAddress,
            this.cmbDesignation,
            this.txtEducation,
            this.txtPhone,
            this.txtCustomerId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCustomer.GridColor = System.Drawing.Color.Silver;
            this.dgvCustomer.Location = new System.Drawing.Point(39, 86);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(702, 287);
            this.dgvCustomer.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvCustomer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(640, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCustomer.DataPropertyName = "Name";
            this.txtCustomer.HeaderText = "Name";
            this.txtCustomer.Name = "txtCustomer";
            // 
            // txtAddress
            // 
            this.txtAddress.DataPropertyName = "Address";
            this.txtAddress.HeaderText = "Address";
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Width = 150;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DataPropertyName = "DesignationId";
            this.cmbDesignation.HeaderText = "Designation";
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbDesignation.Width = 150;
            // 
            // txtEducation
            // 
            this.txtEducation.DataPropertyName = "Education";
            this.txtEducation.HeaderText = "Education";
            this.txtEducation.Name = "txtEducation";
            // 
            // txtPhone
            // 
            this.txtPhone.DataPropertyName = "Phone";
            this.txtPhone.HeaderText = "Phone#";
            this.txtPhone.Name = "txtPhone";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.DataPropertyName = "CustId";
            this.txtCustomerId.HeaderText = "CustomerId";
            this.txtCustomerId.Name = "txtCustomerId";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(764, 433);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCustomer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvCustomer;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAddress;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerId;
    }
}