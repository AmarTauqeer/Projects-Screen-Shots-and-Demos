namespace Gentry
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCatId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtProdId = new MetroFramework.Controls.MetroTextBox();
            this.txtProduct = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtRate = new MetroFramework.Controls.MetroTextBox();
            this.cmbUint = new MetroFramework.Controls.MetroComboBox();
            this.dgvProduct = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatId
            // 
            // 
            // 
            // 
            this.txtCatId.CustomButton.Image = null;
            this.txtCatId.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtCatId.CustomButton.Name = "";
            this.txtCatId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCatId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCatId.CustomButton.TabIndex = 1;
            this.txtCatId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCatId.CustomButton.UseSelectable = true;
            this.txtCatId.CustomButton.Visible = false;
            this.txtCatId.Lines = new string[0];
            this.txtCatId.Location = new System.Drawing.Point(28, 269);
            this.txtCatId.MaxLength = 32767;
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.PasswordChar = '\0';
            this.txtCatId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCatId.SelectedText = "";
            this.txtCatId.SelectionLength = 0;
            this.txtCatId.SelectionStart = 0;
            this.txtCatId.ShortcutsEnabled = true;
            this.txtCatId.Size = new System.Drawing.Size(33, 23);
            this.txtCatId.TabIndex = 15;
            this.txtCatId.UseSelectable = true;
            this.txtCatId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCatId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Category:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(142, 220);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(136, 115);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(238, 29);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProdId
            // 
            // 
            // 
            // 
            this.txtProdId.CustomButton.Image = null;
            this.txtProdId.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtProdId.CustomButton.Name = "";
            this.txtProdId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProdId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProdId.CustomButton.TabIndex = 1;
            this.txtProdId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProdId.CustomButton.UseSelectable = true;
            this.txtProdId.CustomButton.Visible = false;
            this.txtProdId.Lines = new string[0];
            this.txtProdId.Location = new System.Drawing.Point(67, 269);
            this.txtProdId.MaxLength = 32767;
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.PasswordChar = '\0';
            this.txtProdId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProdId.SelectedText = "";
            this.txtProdId.SelectionLength = 0;
            this.txtProdId.SelectionStart = 0;
            this.txtProdId.ShortcutsEnabled = true;
            this.txtProdId.Size = new System.Drawing.Size(33, 23);
            this.txtProdId.TabIndex = 16;
            this.txtProdId.UseSelectable = true;
            this.txtProdId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProdId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProduct
            // 
            // 
            // 
            // 
            this.txtProduct.CustomButton.Image = null;
            this.txtProduct.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtProduct.CustomButton.Name = "";
            this.txtProduct.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProduct.CustomButton.TabIndex = 1;
            this.txtProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProduct.CustomButton.UseSelectable = true;
            this.txtProduct.CustomButton.Visible = false;
            this.txtProduct.Lines = new string[0];
            this.txtProduct.Location = new System.Drawing.Point(136, 115);
            this.txtProduct.MaxLength = 32767;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.PasswordChar = '\0';
            this.txtProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProduct.SelectedText = "";
            this.txtProduct.SelectionLength = 0;
            this.txtProduct.SelectionStart = 0;
            this.txtProduct.ShortcutsEnabled = true;
            this.txtProduct.Size = new System.Drawing.Size(238, 29);
            this.txtProduct.TabIndex = 17;
            this.txtProduct.UseSelectable = true;
            this.txtProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Product:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(136, 80);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(238, 29);
            this.cmbCategory.TabIndex = 19;
            this.cmbCategory.UseSelectable = true;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(54, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Unit:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(54, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Rate:";
            // 
            // txtRate
            // 
            // 
            // 
            // 
            this.txtRate.CustomButton.Image = null;
            this.txtRate.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtRate.CustomButton.Name = "";
            this.txtRate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRate.CustomButton.TabIndex = 1;
            this.txtRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRate.CustomButton.UseSelectable = true;
            this.txtRate.CustomButton.Visible = false;
            this.txtRate.Lines = new string[0];
            this.txtRate.Location = new System.Drawing.Point(136, 185);
            this.txtRate.MaxLength = 32767;
            this.txtRate.Name = "txtRate";
            this.txtRate.PasswordChar = '\0';
            this.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRate.SelectedText = "";
            this.txtRate.SelectionLength = 0;
            this.txtRate.SelectionStart = 0;
            this.txtRate.ShortcutsEnabled = true;
            this.txtRate.Size = new System.Drawing.Size(238, 29);
            this.txtRate.TabIndex = 22;
            this.txtRate.UseSelectable = true;
            this.txtRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbUint
            // 
            this.cmbUint.FormattingEnabled = true;
            this.cmbUint.ItemHeight = 23;
            this.cmbUint.Items.AddRange(new object[] {
            "PCS",
            "KG",
            "PACKET"});
            this.cmbUint.Location = new System.Drawing.Point(136, 150);
            this.cmbUint.Name = "cmbUint";
            this.cmbUint.Size = new System.Drawing.Size(238, 29);
            this.cmbUint.TabIndex = 24;
            this.cmbUint.UseSelectable = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(380, 80);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(445, 211);
            this.dgvProduct.TabIndex = 25;
            this.dgvProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_RowHeaderMouseClick);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 379);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.cmbUint);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.txtCatId);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCatId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtProdId;
        private MetroFramework.Controls.MetroTextBox txtProduct;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtRate;
        private MetroFramework.Controls.MetroComboBox cmbUint;
        private MetroFramework.Controls.MetroGrid dgvProduct;
    }
}