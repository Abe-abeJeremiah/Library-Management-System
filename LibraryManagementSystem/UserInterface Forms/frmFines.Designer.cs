namespace LibraryManagementSystem.UserInterface_Forms
{
    partial class frmFines
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.lblBorrowerId = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtPaymentDetails = new System.Windows.Forms.TextBox();
            this.cmbxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Details";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.ForeColor = System.Drawing.Color.White;
            this.lblFine.Location = new System.Drawing.Point(120, 190);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(33, 16);
            this.lblFine.TabIndex = 3;
            this.lblFine.Text = "Fine";
            // 
            // lblBorrowerId
            // 
            this.lblBorrowerId.AutoSize = true;
            this.lblBorrowerId.Location = new System.Drawing.Point(0, 0);
            this.lblBorrowerId.Name = "lblBorrowerId";
            this.lblBorrowerId.Size = new System.Drawing.Size(0, 16);
            this.lblBorrowerId.TabIndex = 4;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(280, 117);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(250, 22);
            this.txtBookID.TabIndex = 5;
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(280, 187);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(250, 22);
            this.txtFine.TabIndex = 6;
            // 
            // txtPaymentDetails
            // 
            this.txtPaymentDetails.Location = new System.Drawing.Point(280, 337);
            this.txtPaymentDetails.Multiline = true;
            this.txtPaymentDetails.Name = "txtPaymentDetails";
            this.txtPaymentDetails.ReadOnly = true;
            this.txtPaymentDetails.Size = new System.Drawing.Size(250, 80);
            this.txtPaymentDetails.TabIndex = 7;
            // 
            // cmbxPaymentMethod
            // 
            this.cmbxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaymentMethod.FormattingEnabled = true;
            this.cmbxPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Gcash",
            "Paypal"});
            this.cmbxPaymentMethod.Location = new System.Drawing.Point(280, 257);
            this.cmbxPaymentMethod.Name = "cmbxPaymentMethod";
            this.cmbxPaymentMethod.Size = new System.Drawing.Size(250, 24);
            this.cmbxPaymentMethod.TabIndex = 8;
            // 
            // btnPay
            // 
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(280, 450);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 35);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(430, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1942, 754);
            this.Controls.Add(this.cmbxPaymentMethod);
            this.Controls.Add(this.lblBorrowerId);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.txtPaymentDetails);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFines";
            this.Load += new System.EventHandler(this.frmFines_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblBorrowerId;

        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtPaymentDetails;

        private System.Windows.Forms.ComboBox cmbxPaymentMethod;

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClear;
    }
}
