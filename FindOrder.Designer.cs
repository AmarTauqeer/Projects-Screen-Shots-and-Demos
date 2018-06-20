namespace Gentry
{
    partial class FindOrder
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxCustomer = new MetroFramework.Controls.MetroComboBox();
            this.dgvOrder = new MetroFramework.Controls.MetroGrid();
            this.btnSelect = new MetroFramework.Controls.MetroButton();
            this.txtCustId = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(103, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Customer:";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.ItemHeight = 23;
            this.cbxCustomer.Location = new System.Drawing.Point(201, 77);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(283, 29);
            this.cbxCustomer.TabIndex = 3;
            this.cbxCustomer.UseSelectable = true;
            this.cbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cbxCustomer_SelectedIndexChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(103, 124);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(381, 150);
            this.dgvOrder.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(409, 280);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Find";
            this.btnSelect.UseSelectable = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtCustId
            // 
            // 
            // 
            // 
            this.txtCustId.CustomButton.Image = null;
            this.txtCustId.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCustId.CustomButton.Name = "";
            this.txtCustId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustId.CustomButton.TabIndex = 1;
            this.txtCustId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustId.CustomButton.UseSelectable = true;
            this.txtCustId.CustomButton.Visible = false;
            this.txtCustId.Lines = new string[0];
            this.txtCustId.Location = new System.Drawing.Point(274, 33);
            this.txtCustId.MaxLength = 32767;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.PasswordChar = '\0';
            this.txtCustId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustId.SelectedText = "";
            this.txtCustId.SelectionLength = 0;
            this.txtCustId.SelectionStart = 0;
            this.txtCustId.ShortcutsEnabled = true;
            this.txtCustId.Size = new System.Drawing.Size(75, 23);
            this.txtCustId.TabIndex = 7;
            this.txtCustId.UseSelectable = true;
            this.txtCustId.Visible = false;
            this.txtCustId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FindOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 317);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbxCustomer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindOrder";
            this.Text = "Find Order";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FindOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbxCustomer;
        private MetroFramework.Controls.MetroGrid dgvOrder;
        private MetroFramework.Controls.MetroButton btnSelect;
        private MetroFramework.Controls.MetroTextBox txtCustId;
    }
}