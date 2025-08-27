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
            this.components = new System.ComponentModel.Container();
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
            this.txbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbRoles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(619, 812);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 17);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgUserList.ColumnHeadersHeight = 30;
            this.dgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgUserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgUserList.Location = new System.Drawing.Point(0, 0);
            this.dgUserList.Name = "dgUserList";
            this.dgUserList.RowHeadersVisible = false;
            this.dgUserList.RowHeadersWidth = 51;
            this.dgUserList.RowTemplate.Height = 24;
            this.dgUserList.Size = new System.Drawing.Size(1388, 327);
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
            this.btnProdDelete.BorderRadius = 10;
            this.btnProdDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdDelete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnProdDelete.ForeColor = System.Drawing.Color.White;
            this.btnProdDelete.Location = new System.Drawing.Point(471, 549);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(157, 41);
            this.btnProdDelete.TabIndex = 27;
            this.btnProdDelete.Text = "Delete";
            this.btnProdDelete.Click += new System.EventHandler(this.btnProdDelete_Click);
            // 
            // btnProdUpdate
            // 
            this.btnProdUpdate.BorderRadius = 10;
            this.btnProdUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdUpdate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnProdUpdate.ForeColor = System.Drawing.Color.White;
            this.btnProdUpdate.Location = new System.Drawing.Point(238, 549);
            this.btnProdUpdate.Name = "btnProdUpdate";
            this.btnProdUpdate.Size = new System.Drawing.Size(157, 41);
            this.btnProdUpdate.TabIndex = 26;
            this.btnProdUpdate.Text = "Update";
            this.btnProdUpdate.Click += new System.EventHandler(this.btnProdUpdate_Click);
            // 
            // btnProdSave
            // 
            this.btnProdSave.BorderRadius = 10;
            this.btnProdSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnProdSave.ForeColor = System.Drawing.Color.White;
            this.btnProdSave.Location = new System.Drawing.Point(12, 549);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(157, 41);
            this.btnProdSave.TabIndex = 25;
            this.btnProdSave.Text = "Insert";
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // txbPhone
            // 
            this.txbPhone.BorderRadius = 8;
            this.txbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhone.DefaultText = "";
            this.txbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPhone.Location = new System.Drawing.Point(670, 350);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.PlaceholderText = "";
            this.txbPhone.SelectedText = "";
            this.txbPhone.Size = new System.Drawing.Size(153, 42);
            this.txbPhone.TabIndex = 3;
            // 
            // txbSurName
            // 
            this.txbSurName.BorderRadius = 8;
            this.txbSurName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSurName.DefaultText = "";
            this.txbSurName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSurName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSurName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSurName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSurName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSurName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSurName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSurName.Location = new System.Drawing.Point(364, 350);
            this.txbSurName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.txbSurName.Name = "txbSurName";
            this.txbSurName.PlaceholderText = "";
            this.txbSurName.SelectedText = "";
            this.txbSurName.Size = new System.Drawing.Size(153, 42);
            this.txbSurName.TabIndex = 2;
            // 
            // txbAddress
            // 
            this.txbAddress.BorderRadius = 8;
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.DefaultText = "";
            this.txbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAddress.Location = new System.Drawing.Point(92, 424);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.PlaceholderText = "";
            this.txbAddress.SelectedText = "";
            this.txbAddress.Size = new System.Drawing.Size(425, 99);
            this.txbAddress.TabIndex = 5;
            // 
            // txbName
            // 
            this.txbName.BorderRadius = 8;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.DefaultText = "";
            this.txbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbName.Location = new System.Drawing.Point(92, 350);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.PlaceholderText = "";
            this.txbName.SelectedText = "";
            this.txbName.Size = new System.Drawing.Size(153, 42);
            this.txbName.TabIndex = 1;
          
       
            // 
            // txbEmail
            // 
            this.txbEmail.BorderRadius = 8;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Location = new System.Drawing.Point(940, 350);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(153, 42);
            this.txbEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(859, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Address:";
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Role:";
            // 
            // cbRoles
            // 
            this.cbRoles.BackColor = System.Drawing.Color.Transparent;
            this.cbRoles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRoles.ItemHeight = 30;
            this.cbRoles.Location = new System.Drawing.Point(670, 450);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(140, 36);
            this.cbRoles.TabIndex = 44;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 622);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.dgUserList);
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdUpdate);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbSurName);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private Guna.UI2.WinForms.Guna2TextBox txbAddress;
        private Guna.UI2.WinForms.Guna2TextBox txbName;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoles;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label1;
  
    }
}