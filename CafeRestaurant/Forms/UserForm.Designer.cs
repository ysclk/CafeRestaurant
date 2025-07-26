namespace CafeRestaurant.Forms
{
    partial class UserForm
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
            this.lblSifre = new System.Windows.Forms.Label();
            this.dgUserList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnProdDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdSave = new Guna.UI2.WinForms.Guna2Button();
            this.txbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbSurName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(520, 445);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 16);
            this.lblSifre.TabIndex = 29;
            this.lblSifre.Text = "label1";
            this.lblSifre.Visible = false;
            // 
            // dgUserList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgUserList.ColumnHeadersHeight = 30;
            this.dgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgUserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgUserList.Location = new System.Drawing.Point(13, 12);
            this.dgUserList.Name = "dgUserList";
            this.dgUserList.RowHeadersVisible = false;
            this.dgUserList.RowHeadersWidth = 51;
            this.dgUserList.RowTemplate.Height = 24;
            this.dgUserList.Size = new System.Drawing.Size(445, 409);
            this.dgUserList.TabIndex = 28;
            this.dgUserList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgUserList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgUserList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgUserList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgUserList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgUserList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgUserList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgUserList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgUserList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgUserList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUserList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgUserList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgUserList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgUserList.ThemeStyle.ReadOnly = false;
            this.dgUserList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgUserList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgUserList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUserList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgUserList.ThemeStyle.RowsStyle.Height = 24;
            this.dgUserList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgUserList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUserList_CellClick);
            // 
            // btnProdDelete
            // 
            this.btnProdDelete.BorderRadius = 4;
            this.btnProdDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnProdDelete.ForeColor = System.Drawing.Color.White;
            this.btnProdDelete.Location = new System.Drawing.Point(598, 445);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(180, 55);
            this.btnProdDelete.TabIndex = 27;
            this.btnProdDelete.Text = "Delete";
            this.btnProdDelete.Click += new System.EventHandler(this.btnProdDelete_Click);
            // 
            // btnProdUpdate
            // 
            this.btnProdUpdate.BorderRadius = 4;
            this.btnProdUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnProdUpdate.ForeColor = System.Drawing.Color.White;
            this.btnProdUpdate.Location = new System.Drawing.Point(319, 445);
            this.btnProdUpdate.Name = "btnProdUpdate";
            this.btnProdUpdate.Size = new System.Drawing.Size(180, 55);
            this.btnProdUpdate.TabIndex = 26;
            this.btnProdUpdate.Text = "Update";
            this.btnProdUpdate.Click += new System.EventHandler(this.btnProdUpdate_Click);
            // 
            // btnProdSave
            // 
            this.btnProdSave.BorderRadius = 4;
            this.btnProdSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnProdSave.ForeColor = System.Drawing.Color.White;
            this.btnProdSave.Location = new System.Drawing.Point(36, 445);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(180, 55);
            this.btnProdSave.TabIndex = 25;
            this.btnProdSave.Text = "Insert";
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // txbPhone
            // 
            this.txbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhone.DefaultText = "";
            this.txbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhone.Location = new System.Drawing.Point(598, 154);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.PlaceholderText = "";
            this.txbPhone.SelectedText = "";
            this.txbPhone.Size = new System.Drawing.Size(259, 48);
            this.txbPhone.TabIndex = 3;
            // 
            // txbSurName
            // 
            this.txbSurName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSurName.DefaultText = "";
            this.txbSurName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSurName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSurName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSurName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSurName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSurName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSurName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSurName.Location = new System.Drawing.Point(598, 85);
            this.txbSurName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.txbSurName.Name = "txbSurName";
            this.txbSurName.PlaceholderText = "";
            this.txbSurName.SelectedText = "";
            this.txbSurName.Size = new System.Drawing.Size(259, 48);
            this.txbSurName.TabIndex = 2;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(462, 313);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 5);
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(114, 29);
            this.guna2HtmlLabel4.TabIndex = 20;
            this.guna2HtmlLabel4.Text = "Address:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(464, 173);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 5);
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(100, 29);
            this.guna2HtmlLabel3.TabIndex = 19;
            this.guna2HtmlLabel3.Text = "Phone:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(464, 104);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 5);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(120, 29);
            this.guna2HtmlLabel2.TabIndex = 18;
            this.guna2HtmlLabel2.Text = "Surname:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(464, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 5);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 29);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Name:";
            // 
            // txbAddress
            // 
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.DefaultText = "";
            this.txbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAddress.Location = new System.Drawing.Point(598, 294);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.PlaceholderText = "";
            this.txbAddress.SelectedText = "";
            this.txbAddress.Size = new System.Drawing.Size(257, 48);
            this.txbAddress.TabIndex = 5;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(462, 385);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 5);
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(85, 29);
            this.guna2HtmlLabel5.TabIndex = 30;
            this.guna2HtmlLabel5.Text = "Role:";
            // 
            // txbName
            // 
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.DefaultText = "";
            this.txbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbName.Location = new System.Drawing.Point(598, 17);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.PlaceholderText = "";
            this.txbName.SelectedText = "";
            this.txbName.Size = new System.Drawing.Size(259, 48);
            this.txbName.TabIndex = 1;
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRole.ItemHeight = 30;
            this.cbRole.Location = new System.Drawing.Point(598, 377);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(257, 36);
            this.cbRole.TabIndex = 6;
            // 
            // txbEmail
            // 
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Location = new System.Drawing.Point(598, 229);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(259, 48);
            this.txbEmail.TabIndex = 4;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(467, 248);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 5);
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(92, 29);
            this.guna2HtmlLabel6.TabIndex = 34;
            this.guna2HtmlLabel6.Text = "Email:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 531);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.dgUserList);
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdUpdate);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbSurName);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifre;
        private Guna.UI2.WinForms.Guna2DataGridView dgUserList;
        private Guna.UI2.WinForms.Guna2Button btnProdDelete;
        private Guna.UI2.WinForms.Guna2Button btnProdUpdate;
        private Guna.UI2.WinForms.Guna2Button btnProdSave;
        private Guna.UI2.WinForms.Guna2TextBox txbPhone;
        private Guna.UI2.WinForms.Guna2TextBox txbSurName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txbAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txbName;
        private Guna.UI2.WinForms.Guna2ComboBox cbRole;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}