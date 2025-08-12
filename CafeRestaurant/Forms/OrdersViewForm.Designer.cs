namespace CafeRestaurant.Forms
{
    partial class OrdersViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateSearch = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbStatusSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imgFilters = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txbCustomerNameSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFilters = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrderStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgOrdersDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdersDetails)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Order Date:";
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.Checked = true;
            this.dtpDateSearch.FillColor = System.Drawing.Color.White;
            this.dtpDateSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateSearch.Location = new System.Drawing.Point(23, 268);
            this.dtpDateSearch.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateSearch.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(252, 36);
            this.dtpDateSearch.TabIndex = 57;
            this.dtpDateSearch.Value = new System.DateTime(2025, 8, 2, 10, 48, 47, 331);
            this.dtpDateSearch.CloseUp += new System.EventHandler(this.dtpDateSearch_CloseUp);
            // 
            // cmbStatusSearch
            // 
            this.cmbStatusSearch.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatusSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatusSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatusSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatusSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatusSearch.ItemHeight = 35;
            this.cmbStatusSearch.Location = new System.Drawing.Point(23, 64);
            this.cmbStatusSearch.Name = "cmbStatusSearch";
            this.cmbStatusSearch.Size = new System.Drawing.Size(252, 41);
            this.cmbStatusSearch.TabIndex = 53;
            this.cmbStatusSearch.SelectedIndexChanged += new System.EventHandler(this.cmbStatuSearch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Customer Name:";
            // 
            // imgFilters
            // 
            this.imgFilters.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgFilters.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFilters.HoverState.ImageSize = new System.Drawing.Size(20, 30);
            this.imgFilters.Image = ((System.Drawing.Image)(resources.GetObject("imgFilters.Image")));
            this.imgFilters.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgFilters.ImageRotate = 0F;
            this.imgFilters.ImageSize = new System.Drawing.Size(12, 22);
            this.imgFilters.Location = new System.Drawing.Point(310, 404);
            this.imgFilters.Name = "imgFilters";
            this.imgFilters.PressedState.ImageSize = new System.Drawing.Size(20, 30);
            this.imgFilters.Size = new System.Drawing.Size(25, 25);
            this.imgFilters.TabIndex = 62;
            this.imgFilters.Click += new System.EventHandler(this.imgFilters_Click);
            // 
            // txbCustomerNameSearch
            // 
            this.txbCustomerNameSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCustomerNameSearch.DefaultText = "";
            this.txbCustomerNameSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCustomerNameSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCustomerNameSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerNameSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerNameSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerNameSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCustomerNameSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerNameSearch.Location = new System.Drawing.Point(23, 166);
            this.txbCustomerNameSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txbCustomerNameSearch.Multiline = true;
            this.txbCustomerNameSearch.Name = "txbCustomerNameSearch";
            this.txbCustomerNameSearch.PlaceholderText = "";
            this.txbCustomerNameSearch.SelectedText = "";
            this.txbCustomerNameSearch.Size = new System.Drawing.Size(252, 41);
            this.txbCustomerNameSearch.TabIndex = 54;
            this.txbCustomerNameSearch.TextChanged += new System.EventHandler(this.txbCustomerNameSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(81, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 63;
            this.label6.Text = "Advanced Search";
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 8;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(80, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(254, 55);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear Filters";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.label2);
            this.pnlFilters.Controls.Add(this.guna2DateTimePicker1);
            this.pnlFilters.Controls.Add(this.label1);
            this.pnlFilters.Controls.Add(this.cmbOrderStatus);
            this.pnlFilters.Controls.Add(this.label10);
            this.pnlFilters.Controls.Add(this.txbCustomerName);
            this.pnlFilters.Location = new System.Drawing.Point(61, 460);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(294, 316);
            this.pnlFilters.TabIndex = 52;
            this.pnlFilters.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Order Type:";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(22, 264);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(252, 36);
            this.guna2DateTimePicker1.TabIndex = 50;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 8, 2, 10, 48, 47, 331);
            this.guna2DateTimePicker1.CloseUp += new System.EventHandler(this.guna2DateTimePicker1_CloseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Order Date:";
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbOrderStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrderStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrderStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOrderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbOrderStatus.ItemHeight = 35;
            this.cmbOrderStatus.Location = new System.Drawing.Point(22, 56);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(252, 41);
            this.cmbOrderStatus.TabIndex = 46;
            this.cmbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cmbOrderStatus_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 23);
            this.label10.TabIndex = 49;
            this.label10.Text = "Customer Name:";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCustomerName.DefaultText = "";
            this.txbCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerName.Location = new System.Drawing.Point(22, 160);
            this.txbCustomerName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txbCustomerName.Multiline = true;
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.PlaceholderText = "";
            this.txbCustomerName.SelectedText = "";
            this.txbCustomerName.Size = new System.Drawing.Size(252, 41);
            this.txbCustomerName.TabIndex = 47;
            this.txbCustomerName.TextChanged += new System.EventHandler(this.txbCustomerName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Order Status:";
            // 
            // dgOrdersDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgOrdersDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrdersDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrdersDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrdersDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrdersDetails.ColumnHeadersHeight = 30;
            this.dgOrdersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrdersDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrdersDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgOrdersDetails.Location = new System.Drawing.Point(2, 0);
            this.dgOrdersDetails.Name = "dgOrdersDetails";
            this.dgOrdersDetails.RowHeadersVisible = false;
            this.dgOrdersDetails.RowHeadersWidth = 51;
            this.dgOrdersDetails.RowTemplate.Height = 24;
            this.dgOrdersDetails.Size = new System.Drawing.Size(1141, 751);
            this.dgOrdersDetails.TabIndex = 0;
            this.dgOrdersDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgOrdersDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgOrdersDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgOrdersDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgOrdersDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgOrdersDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgOrdersDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgOrdersDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgOrdersDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOrdersDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrdersDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgOrdersDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgOrdersDetails.ThemeStyle.HeaderStyle.Height = 30;
            this.dgOrdersDetails.ThemeStyle.ReadOnly = false;
            this.dgOrdersDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgOrdersDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgOrdersDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrdersDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgOrdersDetails.ThemeStyle.RowsStyle.Height = 24;
            this.dgOrdersDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgOrdersDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgOrdersDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdersDetails_CellClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.pnlFilters);
            this.guna2Panel2.Controls.Add(this.btnClear);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.imgFilters);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(1146, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel2.Size = new System.Drawing.Size(377, 751);
            this.guna2Panel2.TabIndex = 65;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.dtpDateSearch);
            this.guna2Panel3.Controls.Add(this.cmbStatusSearch);
            this.guna2Panel3.Controls.Add(this.txbCustomerNameSearch);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Location = new System.Drawing.Point(61, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(294, 316);
            this.guna2Panel3.TabIndex = 66;
            // 
            // OrdersViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 751);
            this.Controls.Add(this.dgOrdersDetails);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersOrdersDetailForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrdersViewForm_Load);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdersDetails)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatusSearch;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton imgFilters;
        private Guna.UI2.WinForms.Guna2TextBox txbCustomerNameSearch;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Panel pnlFilters;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrderStatus;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txbCustomerName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgOrdersDetails;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
    }
}