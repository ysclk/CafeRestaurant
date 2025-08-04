namespace CafeRestaurant.Forms
{
    partial class OrderForm
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
            this.cmbCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbProducts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ndQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbOrdertype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderlistForDay = new Guna.UI2.WinForms.Guna2Button();
            this.btnCatSave = new Guna.UI2.WinForms.Guna2Button();
            this.ndPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ndSubtotal = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txbOrdernote = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnInsertOrderList = new Guna.UI2.WinForms.Guna2Button();
            this.ndCurrent = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbCustomerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCurrent)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cmbCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCustomer.ItemHeight = 35;
            this.cmbCustomer.Location = new System.Drawing.Point(14, 133);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(235, 41);
            this.cmbCustomer.TabIndex = 8;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategories.ItemHeight = 35;
            this.cmbCategories.Location = new System.Drawing.Point(306, 133);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(235, 41);
            this.cmbCategories.TabIndex = 9;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // cmbProducts
            // 
            this.cmbProducts.BackColor = System.Drawing.Color.Transparent;
            this.cmbProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProducts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProducts.ItemHeight = 35;
            this.cmbProducts.Location = new System.Drawing.Point(597, 133);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(235, 41);
            this.cmbProducts.TabIndex = 10;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // ndQuantity
            // 
            this.ndQuantity.BackColor = System.Drawing.Color.Transparent;
            this.ndQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ndQuantity.Location = new System.Drawing.Point(18, 53);
            this.ndQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ndQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndQuantity.Name = "ndQuantity";
            this.ndQuantity.Size = new System.Drawing.Size(86, 41);
            this.ndQuantity.TabIndex = 12;
            this.ndQuantity.ValueChanged += new System.EventHandler(this.ndQuantity_ValueChanged);
            // 
            // cmbOrdertype
            // 
            this.cmbOrdertype.BackColor = System.Drawing.Color.Transparent;
            this.cmbOrdertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrdertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdertype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrdertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrdertype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOrdertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbOrdertype.ItemHeight = 35;
            this.cmbOrdertype.Location = new System.Drawing.Point(311, 238);
            this.cmbOrdertype.Name = "cmbOrdertype";
            this.cmbOrdertype.Size = new System.Drawing.Size(235, 41);
            this.cmbOrdertype.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(941, 639);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 55);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Cancel Order";
            // 
            // btnOrderlistForDay
            // 
            this.btnOrderlistForDay.BorderRadius = 8;
            this.btnOrderlistForDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderlistForDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderlistForDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderlistForDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderlistForDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrderlistForDay.ForeColor = System.Drawing.Color.White;
            this.btnOrderlistForDay.Location = new System.Drawing.Point(689, 639);
            this.btnOrderlistForDay.Name = "btnOrderlistForDay";
            this.btnOrderlistForDay.Size = new System.Drawing.Size(180, 55);
            this.btnOrderlistForDay.TabIndex = 17;
            this.btnOrderlistForDay.Text = "Daily Orders";
            this.btnOrderlistForDay.Click += new System.EventHandler(this.btnOrderlistForDay_Click);
            // 
            // btnCatSave
            // 
            this.btnCatSave.BorderRadius = 8;
            this.btnCatSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCatSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCatSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCatSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCatSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCatSave.ForeColor = System.Drawing.Color.White;
            this.btnCatSave.Location = new System.Drawing.Point(241, 639);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(180, 55);
            this.btnCatSave.TabIndex = 16;
            this.btnCatSave.Text = "Save Order";
            this.btnCatSave.Click += new System.EventHandler(this.btnCatSave_Click);
            // 
            // ndPrice
            // 
            this.ndPrice.BackColor = System.Drawing.Color.Transparent;
            this.ndPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndPrice.DecimalPlaces = 2;
            this.ndPrice.Enabled = false;
            this.ndPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ndPrice.Location = new System.Drawing.Point(18, 136);
            this.ndPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ndPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndPrice.Name = "ndPrice";
            this.ndPrice.Size = new System.Drawing.Size(86, 41);
            this.ndPrice.TabIndex = 22;
            // 
            // ndSubtotal
            // 
            this.ndSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.ndSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndSubtotal.DecimalPlaces = 2;
            this.ndSubtotal.Enabled = false;
            this.ndSubtotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ndSubtotal.Location = new System.Drawing.Point(150, 53);
            this.ndSubtotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ndSubtotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndSubtotal.Name = "ndSubtotal";
            this.ndSubtotal.Size = new System.Drawing.Size(86, 41);
            this.ndSubtotal.TabIndex = 24;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(552, 247);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(44, 16);
            this.lblTarih.TabIndex = 26;
            this.lblTarih.Text = "label1";
            this.lblTarih.Visible = false;
            // 
            // txbOrdernote
            // 
            this.txbOrdernote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbOrdernote.DefaultText = "";
            this.txbOrdernote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbOrdernote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbOrdernote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbOrdernote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbOrdernote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbOrdernote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbOrdernote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbOrdernote.Location = new System.Drawing.Point(20, 238);
            this.txbOrdernote.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txbOrdernote.Multiline = true;
            this.txbOrdernote.Name = "txbOrdernote";
            this.txbOrdernote.PlaceholderText = "";
            this.txbOrdernote.SelectedText = "";
            this.txbOrdernote.Size = new System.Drawing.Size(235, 41);
            this.txbOrdernote.TabIndex = 28;
            // 
            // dgOrders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrders.ColumnHeadersHeight = 30;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgOrders.Location = new System.Drawing.Point(0, 350);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.RowHeadersVisible = false;
            this.dgOrders.RowHeadersWidth = 51;
            this.dgOrders.RowTemplate.Height = 24;
            this.dgOrders.Size = new System.Drawing.Size(1135, 256);
            this.dgOrders.TabIndex = 29;
            this.dgOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgOrders.ThemeStyle.HeaderStyle.Height = 30;
            this.dgOrders.ThemeStyle.ReadOnly = false;
            this.dgOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgOrders.ThemeStyle.RowsStyle.Height = 24;
            this.dgOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellClick);
            // 
            // btnInsertOrderList
            // 
            this.btnInsertOrderList.BorderRadius = 8;
            this.btnInsertOrderList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertOrderList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertOrderList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertOrderList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnInsertOrderList.ForeColor = System.Drawing.Color.White;
            this.btnInsertOrderList.Location = new System.Drawing.Point(12, 639);
            this.btnInsertOrderList.Name = "btnInsertOrderList";
            this.btnInsertOrderList.Size = new System.Drawing.Size(180, 55);
            this.btnInsertOrderList.TabIndex = 30;
            this.btnInsertOrderList.Text = "Insert To List";
            this.btnInsertOrderList.Click += new System.EventHandler(this.btnInsertOrderList_Click);
            // 
            // ndCurrent
            // 
            this.ndCurrent.BackColor = System.Drawing.Color.Transparent;
            this.ndCurrent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndCurrent.DecimalPlaces = 2;
            this.ndCurrent.Enabled = false;
            this.ndCurrent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ndCurrent.Location = new System.Drawing.Point(150, 136);
            this.ndCurrent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ndCurrent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndCurrent.Name = "ndCurrent";
            this.ndCurrent.Size = new System.Drawing.Size(86, 41);
            this.ndCurrent.TabIndex = 35;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnCancel.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DefaultAutoSize = true;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(1089, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.Gray;
            this.btnCancel.Size = new System.Drawing.Size(46, 39);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "X";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1135, 80);
            this.guna2Panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(503, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Categories:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Products:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Unit Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Subtotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Order Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 45;
            this.label10.Text = "Order Note:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(593, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 23);
            this.label11.TabIndex = 46;
            this.label11.Text = "Total Amount Order:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(611, 247);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(20, 23);
            this.lblTotalAmount.TabIndex = 47;
            this.lblTotalAmount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(146, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 48;
            this.label12.Text = "Current:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.ndQuantity);
            this.guna2Panel2.Controls.Add(this.label12);
            this.guna2Panel2.Controls.Add(this.ndSubtotal);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.ndPrice);
            this.guna2Panel2.Controls.Add(this.ndCurrent);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Location = new System.Drawing.Point(860, 86);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(261, 204);
            this.guna2Panel2.TabIndex = 49;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(477, 639);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 55);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update Order";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Customer Phone: ";
            // 
            // txbCustomerPhone
            // 
            this.txbCustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCustomerPhone.DefaultText = "";
            this.txbCustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerPhone.Location = new System.Drawing.Point(195, 301);
            this.txbCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txbCustomerPhone.Multiline = true;
            this.txbCustomerPhone.Name = "txbCustomerPhone";
            this.txbCustomerPhone.PlaceholderText = "";
            this.txbCustomerPhone.SelectedText = "";
            this.txbCustomerPhone.Size = new System.Drawing.Size(235, 41);
            this.txbCustomerPhone.TabIndex = 52;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 714);
            this.Controls.Add(this.txbCustomerPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnInsertOrderList);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.txbOrdernote);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOrderlistForDay);
            this.Controls.Add(this.btnCatSave);
            this.Controls.Add(this.cmbOrdertype);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.cmbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndCurrent)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategories;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProducts;
        private Guna.UI2.WinForms.Guna2NumericUpDown ndQuantity;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrdertype;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnOrderlistForDay;
        private Guna.UI2.WinForms.Guna2Button btnCatSave;
        private Guna.UI2.WinForms.Guna2NumericUpDown ndPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown ndSubtotal;
        private System.Windows.Forms.Label lblTarih;
        private Guna.UI2.WinForms.Guna2TextBox txbOrdernote;
        private Guna.UI2.WinForms.Guna2DataGridView dgOrders;
        private Guna.UI2.WinForms.Guna2Button btnInsertOrderList;
        private Guna.UI2.WinForms.Guna2NumericUpDown ndCurrent;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txbCustomerPhone;
    }
}