namespace CafeRestaurant.Forms
{
    partial class DashboardAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdminForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlWelcome = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.pnlCustomer = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.pnlOrdersCount = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlWelcome.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlOrdersCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(238, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(292, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(715, 100);
            this.pnlWelcome.TabIndex = 1;
            this.pnlWelcome.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 35);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label2";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(12, 162);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(70, 28);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "label2";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlCustomer.Controls.Add(this.guna2PictureBox1);
            this.pnlCustomer.Controls.Add(this.lblCustomerCount);
            this.pnlCustomer.Controls.Add(this.label1);
            this.pnlCustomer.Location = new System.Drawing.Point(13, 206);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(226, 111);
            this.pnlCustomer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCount.ForeColor = System.Drawing.Color.White;
            this.lblCustomerCount.Location = new System.Drawing.Point(14, 49);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(0, 30);
            this.lblCustomerCount.TabIndex = 1;
            // 
            // pnlOrdersCount
            // 
            this.pnlOrdersCount.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlOrdersCount.Controls.Add(this.guna2PictureBox2);
            this.pnlOrdersCount.Controls.Add(this.label2);
            this.pnlOrdersCount.Controls.Add(this.label3);
            this.pnlOrdersCount.Location = new System.Drawing.Point(290, 206);
            this.pnlOrdersCount.Name = "pnlOrdersCount";
            this.pnlOrdersCount.Size = new System.Drawing.Size(226, 111);
            this.pnlOrdersCount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orders";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(147, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(143, 25);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(64, 64);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.pnlOrdersCount);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pnlWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlOrdersCount.ResumeLayout(false);
            this.pnlOrdersCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Panel pnlWelcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private Guna.UI2.WinForms.Guna2Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlOrdersCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}