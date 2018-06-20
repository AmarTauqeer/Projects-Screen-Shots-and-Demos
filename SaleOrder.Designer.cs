namespace Gentry
{
    partial class SaleOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMasterOrderId = new MetroFramework.Controls.MetroTextBox();
            this.cbxCustomer = new MetroFramework.Controls.MetroComboBox();
            this.txtCustId = new MetroFramework.Controls.MetroTextBox();
            this.dgvOrderDetail = new MetroFramework.Controls.MetroGrid();
            this.txtDetailOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new Gentry.ProductDataSet();
            this.tblProductTableAdapter = new Gentry.ProductDataSetTableAdapters.tblProductTableAdapter();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalQty = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.brnClearItems = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.OrderDate);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtMasterOrderId);
            this.metroPanel1.Controls.Add(this.cbxCustomer);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(119, 98);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(602, 101);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // OrderDate
            // 
            this.OrderDate.CustomFormat = "yyyy-dd-mm";
            this.OrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrderDate.Location = new System.Drawing.Point(415, 14);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(120, 20);
            this.OrderDate.TabIndex = 1;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Order No:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(334, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Order Date:";
            // 
            // txtMasterOrderId
            // 
            // 
            // 
            // 
            this.txtMasterOrderId.CustomButton.Image = null;
            this.txtMasterOrderId.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtMasterOrderId.CustomButton.Name = "";
            this.txtMasterOrderId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMasterOrderId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasterOrderId.CustomButton.TabIndex = 1;
            this.txtMasterOrderId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasterOrderId.CustomButton.UseSelectable = true;
            this.txtMasterOrderId.CustomButton.Visible = false;
            this.txtMasterOrderId.Enabled = false;
            this.txtMasterOrderId.Lines = new string[0];
            this.txtMasterOrderId.Location = new System.Drawing.Point(113, 15);
            this.txtMasterOrderId.MaxLength = 32767;
            this.txtMasterOrderId.Name = "txtMasterOrderId";
            this.txtMasterOrderId.PasswordChar = '\0';
            this.txtMasterOrderId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterOrderId.SelectedText = "";
            this.txtMasterOrderId.SelectionLength = 0;
            this.txtMasterOrderId.SelectionStart = 0;
            this.txtMasterOrderId.ShortcutsEnabled = true;
            this.txtMasterOrderId.Size = new System.Drawing.Size(111, 23);
            this.txtMasterOrderId.TabIndex = 0;
            this.txtMasterOrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasterOrderId.UseSelectable = true;
            this.txtMasterOrderId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasterOrderId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.ItemHeight = 23;
            this.cbxCustomer.Location = new System.Drawing.Point(113, 44);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(422, 29);
            this.cbxCustomer.TabIndex = 2;
            this.cbxCustomer.UseSelectable = true;
            this.cbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cbxCustomer_SelectedIndexChanged);
            // 
            // txtCustId
            // 
            // 
            // 
            // 
            this.txtCustId.CustomButton.Image = null;
            this.txtCustId.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.txtCustId.CustomButton.Name = "";
            this.txtCustId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustId.CustomButton.TabIndex = 1;
            this.txtCustId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustId.CustomButton.UseSelectable = true;
            this.txtCustId.CustomButton.Visible = false;
            this.txtCustId.Lines = new string[0];
            this.txtCustId.Location = new System.Drawing.Point(82, 98);
            this.txtCustId.MaxLength = 32767;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.PasswordChar = '\0';
            this.txtCustId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustId.SelectedText = "";
            this.txtCustId.SelectionLength = 0;
            this.txtCustId.SelectionStart = 0;
            this.txtCustId.ShortcutsEnabled = true;
            this.txtCustId.Size = new System.Drawing.Size(31, 23);
            this.txtCustId.TabIndex = 0;
            this.txtCustId.UseSelectable = true;
            this.txtCustId.Visible = false;
            this.txtCustId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDetailOrderId,
            this.txtProdID,
            this.cbxProductName,
            this.txtUnits,
            this.txtQty,
            this.txtProductRate,
            this.txtAmount});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOrderDetail.EnableHeadersVisualStyles = false;
            this.dgvOrderDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrderDetail.GridColor = System.Drawing.Color.White;
            this.dgvOrderDetail.Location = new System.Drawing.Point(59, 205);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvOrderDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(728, 153);
            this.dgvOrderDetail.TabIndex = 2;
            this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.dgvOrderDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellEndEdit);
            this.dgvOrderDetail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellEnter);
            // 
            // txtDetailOrderId
            // 
            this.txtDetailOrderId.DataPropertyName = "OrderId";
            this.txtDetailOrderId.HeaderText = "OrderId";
            this.txtDetailOrderId.Name = "txtDetailOrderId";
            // 
            // txtProdID
            // 
            this.txtProdID.DataPropertyName = "ProdId";
            this.txtProdID.HeaderText = "Product ID";
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            // 
            // cbxProductName
            // 
            this.cbxProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbxProductName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbxProductName.HeaderText = "ProductName";
            this.cbxProductName.Name = "cbxProductName";
            // 
            // txtUnits
            // 
            this.txtUnits.HeaderText = "Units";
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.ReadOnly = true;
            this.txtUnits.Width = 50;
            // 
            // txtQty
            // 
            this.txtQty.DataPropertyName = "Qty";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtQty.DefaultCellStyle = dataGridViewCellStyle10;
            this.txtQty.HeaderText = "Qty";
            this.txtQty.Name = "txtQty";
            this.txtQty.Width = 50;
            // 
            // txtProductRate
            // 
            this.txtProductRate.DataPropertyName = "ProductRate";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.txtProductRate.DefaultCellStyle = dataGridViewCellStyle11;
            this.txtProductRate.HeaderText = "Rate";
            this.txtProductRate.Name = "txtProductRate";
            this.txtProductRate.Width = 50;
            // 
            // txtAmount
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.txtAmount.DefaultCellStyle = dataGridViewCellStyle12;
            this.txtAmount.HeaderText = "Amount";
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            // 
            // tblProductBindingSource1
            // 
            this.tblProductBindingSource1.DataMember = "tblProduct";
            this.tblProductBindingSource1.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // txtTotalAmount
            // 
            // 
            // 
            // 
            this.txtTotalAmount.CustomButton.Image = null;
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmount.CustomButton.TabIndex = 1;
            this.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmount.CustomButton.UseSelectable = true;
            this.txtTotalAmount.CustomButton.Visible = false;
            this.txtTotalAmount.Lines = new string[0];
            this.txtTotalAmount.Location = new System.Drawing.Point(703, 362);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(84, 23);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(556, 364);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Total:";
            // 
            // txtTotalQty
            // 
            // 
            // 
            // 
            this.txtTotalQty.CustomButton.Image = null;
            this.txtTotalQty.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.txtTotalQty.CustomButton.Name = "";
            this.txtTotalQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalQty.CustomButton.TabIndex = 1;
            this.txtTotalQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalQty.CustomButton.UseSelectable = true;
            this.txtTotalQty.CustomButton.Visible = false;
            this.txtTotalQty.Lines = new string[0];
            this.txtTotalQty.Location = new System.Drawing.Point(596, 362);
            this.txtTotalQty.MaxLength = 32767;
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.PasswordChar = '\0';
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalQty.SelectedText = "";
            this.txtTotalQty.SelectionLength = 0;
            this.txtTotalQty.SelectionStart = 0;
            this.txtTotalQty.ShortcutsEnabled = true;
            this.txtTotalQty.Size = new System.Drawing.Size(39, 23);
            this.txtTotalQty.TabIndex = 5;
            this.txtTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalQty.UseSelectable = true;
            this.txtTotalQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // brnClearItems
            // 
            this.brnClearItems.Location = new System.Drawing.Point(226, 364);
            this.brnClearItems.Name = "brnClearItems";
            this.brnClearItems.Size = new System.Drawing.Size(80, 23);
            this.brnClearItems.TabIndex = 4;
            this.brnClearItems.Text = "Clear Items";
            this.brnClearItems.UseSelectable = true;
            this.brnClearItems.Click += new System.EventHandler(this.brnClearItems_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 364);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Find Order";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(393, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(59, 364);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(476, 364);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(851, 397);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.brnClearItems);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalQty);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txtCustId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleOrder";
            this.Text = "Sale Order";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.SaleOrder_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtCustId;
        private MetroFramework.Controls.MetroComboBox cbxCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgvOrderDetail;
        private MetroFramework.Controls.MetroTextBox txtMasterOrderId;
        
        private System.Windows.Forms.BindingSource tblProductBindingSource;

        private System.Windows.Forms.DateTimePicker OrderDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource1;
        private ProductDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTotalQty;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton brnClearItems;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDetailOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProdID;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProductRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmount;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnPrint;
        //private System.Windows.Forms.DataGridViewTextBoxColumn txtDetailOrderId;
    }
}