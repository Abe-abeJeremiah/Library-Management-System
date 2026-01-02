namespace LibraryManagementSystem.UserInterface_Forms
{
    partial class frmFines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBorrowerId;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClear;


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
            this.lblBorrowerId = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaymentDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBorrowerId
            // 
            this.lblBorrowerId.ForeColor = System.Drawing.Color.White;
            this.lblBorrowerId.Location = new System.Drawing.Point(283, 69);
            this.lblBorrowerId.Name = "lblBorrowerId";
            this.lblBorrowerId.Size = new System.Drawing.Size(100, 23);
            this.lblBorrowerId.TabIndex = 2;
            this.lblBorrowerId.Text = "Book ID";
            this.lblBorrowerId.Click += new System.EventHandler(this.lblBorrowerId_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(283, 95);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(250, 20);
            this.txtBookID.TabIndex = 3;
            // 
            // lblFine
            // 
            this.lblFine.ForeColor = System.Drawing.Color.White;
            this.lblFine.Location = new System.Drawing.Point(283, 128);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(100, 23);
            this.lblFine.TabIndex = 8;
            this.lblFine.Text = "Fine Amount";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(283, 154);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(250, 20);
            this.txtFine.TabIndex = 9;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(286, 317);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(250, 23);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay Fine";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(286, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment Method";
            // 
            // cmbxPaymentMethod
            // 
            this.cmbxPaymentMethod.FormattingEnabled = true;
            this.cmbxPaymentMethod.Items.AddRange(new object[] {
            "Gcash",
            "Paypal",
            "Cash"});
            this.cmbxPaymentMethod.Location = new System.Drawing.Point(286, 215);
            this.cmbxPaymentMethod.Name = "cmbxPaymentMethod";
            this.cmbxPaymentMethod.Size = new System.Drawing.Size(247, 21);
            this.cmbxPaymentMethod.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment Details";
            // 
            // txtPaymentDetails
            // 
            this.txtPaymentDetails.Location = new System.Drawing.Point(283, 274);
            this.txtPaymentDetails.Name = "txtPaymentDetails";
            this.txtPaymentDetails.ReadOnly = true;
            this.txtPaymentDetails.Size = new System.Drawing.Size(250, 20);
            this.txtPaymentDetails.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(590, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 123);
            this.label3.TabIndex = 8;
            this.label3.Text = "irrelevant ang borrower id, kay naka login naman, dapat auto kabalo na";
            // 
            // frmFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1620, 613);
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
            this.Name = "frmFines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxPaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaymentDetails;
        private System.Windows.Forms.Label label3;
    }
}
