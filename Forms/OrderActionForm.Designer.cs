namespace CafeRestaurant.Forms
{
    partial class OrderActionForm
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
            this.btnDelivered = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelivered
            // 
            this.btnDelivered.BorderRadius = 8;
            this.btnDelivered.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivered.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelivered.ForeColor = System.Drawing.Color.White;
            this.btnDelivered.Location = new System.Drawing.Point(33, 264);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(180, 55);
            this.btnDelivered.TabIndex = 31;
            this.btnDelivered.Text = "Order Delivered";
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.BorderRadius = 8;
            this.btnOrderCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnOrderCancel.ForeColor = System.Drawing.Color.White;
            this.btnOrderCancel.Location = new System.Drawing.Point(263, 264);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(180, 55);
            this.btnOrderCancel.TabIndex = 32;
            this.btnOrderCancel.Text = "Order Canceled";
            this.btnOrderCancel.Click += new System.EventHandler(this.btnOrderCancel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DefaultAutoSize = true;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.Location = new System.Drawing.Point(428, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.Gray;
            this.btnCancel.Size = new System.Drawing.Size(46, 39);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "X";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Action";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(480, 80);
            this.guna2Panel1.TabIndex = 37;
            // 
            // OrderActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 383);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnOrderCancel);
            this.Controls.Add(this.btnDelivered);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderActionForm";
            this.Text = "OrderActionForm";
     
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelivered;
        private Guna.UI2.WinForms.Guna2Button btnOrderCancel;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}