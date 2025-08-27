namespace CafeRestaurant.Forms
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDaylieReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonthly = new Guna.UI2.WinForms.Guna2Button();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbYears = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReport
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgReport.ColumnHeadersHeight = 30;
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReport.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgReport.Location = new System.Drawing.Point(0, 0);
            this.dgReport.Name = "dgReport";
            this.dgReport.RowHeadersVisible = false;
            this.dgReport.RowHeadersWidth = 51;
            this.dgReport.RowTemplate.Height = 24;
            this.dgReport.Size = new System.Drawing.Size(1104, 286);
            this.dgReport.TabIndex = 0;
            this.dgReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgReport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgReport.ThemeStyle.HeaderStyle.Height = 30;
            this.dgReport.ThemeStyle.ReadOnly = false;
            this.dgReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgReport.ThemeStyle.RowsStyle.Height = 24;
            this.dgReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDaylieReport
            // 
            this.btnDaylieReport.BorderRadius = 8;
            this.btnDaylieReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaylieReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaylieReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDaylieReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDaylieReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDaylieReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDaylieReport.ForeColor = System.Drawing.Color.White;
            this.btnDaylieReport.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDaylieReport.Location = new System.Drawing.Point(106, 397);
            this.btnDaylieReport.Name = "btnDaylieReport";
            this.btnDaylieReport.Size = new System.Drawing.Size(245, 41);
            this.btnDaylieReport.TabIndex = 10;
            this.btnDaylieReport.Text = "Daylie Report";
            this.btnDaylieReport.Click += new System.EventHandler(this.btnDaylieReport_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.BorderRadius = 8;
            this.btnMonthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonthly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMonthly.ForeColor = System.Drawing.Color.White;
            this.btnMonthly.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnMonthly.Location = new System.Drawing.Point(709, 397);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(242, 41);
            this.btnMonthly.TabIndex = 11;
            this.btnMonthly.Text = "Monthly Report";
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = true;
            this.dtpStart.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(12, 335);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(208, 36);
            this.dtpStart.TabIndex = 12;
            this.dtpStart.Value = new System.DateTime(2025, 8, 17, 18, 0, 20, 672);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = true;
            this.dtpEnd.FillColor = System.Drawing.Color.CornflowerBlue;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEnd.Location = new System.Drawing.Point(255, 335);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(222, 36);
            this.dtpEnd.TabIndex = 13;
            this.dtpEnd.Value = new System.DateTime(2025, 8, 17, 18, 0, 20, 672);
            // 
            // cmbYears
            // 
            this.cmbYears.BackColor = System.Drawing.Color.Transparent;
            this.cmbYears.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.FillColor = System.Drawing.Color.AliceBlue;
            this.cmbYears.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYears.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYears.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbYears.ItemHeight = 30;
            this.cmbYears.Location = new System.Drawing.Point(746, 335);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(140, 36);
            this.cmbYears.TabIndex = 14;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.cmbYears);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnDaylieReport);
            this.Controls.Add(this.dgReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgReport;
        private Guna.UI2.WinForms.Guna2Button btnDaylieReport;
        private Guna.UI2.WinForms.Guna2Button btnMonthly;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYears;
    }
}