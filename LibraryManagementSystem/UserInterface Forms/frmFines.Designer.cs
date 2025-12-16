namespace LibraryManagementSystem.UserInterface_Forms
{
    partial class frmFines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.Label lblBorrowerId;
        private System.Windows.Forms.TextBox txtBorrowerId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDaysLate;
        private System.Windows.Forms.TextBox txtDaysLate;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Button btnCalculate;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.lblBorrowerId = new System.Windows.Forms.Label();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDaysLate = new System.Windows.Forms.Label();
            this.txtDaysLate = new System.Windows.Forms.TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Fines Management";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // dgvFines
            // 
            this.dgvFines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvFines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFines.ColumnHeadersHeight = 29;
            this.dgvFines.Location = new System.Drawing.Point(30, 80);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.Size = new System.Drawing.Size(550, 506);
            this.dgvFines.TabIndex = 1;
            // 
            // lblBorrowerId
            // 
            this.lblBorrowerId.ForeColor = System.Drawing.Color.White;
            this.lblBorrowerId.Location = new System.Drawing.Point(620, 110);
            this.lblBorrowerId.Name = "lblBorrowerId";
            this.lblBorrowerId.Size = new System.Drawing.Size(100, 23);
            this.lblBorrowerId.TabIndex = 2;
            this.lblBorrowerId.Text = "Borrower ID";
            this.lblBorrowerId.Click += new System.EventHandler(this.lblBorrowerId_Click);
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.Location = new System.Drawing.Point(620, 136);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.Size = new System.Drawing.Size(250, 22);
            this.txtBorrowerId.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(620, 184);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(620, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 5;
            // 
            // lblDaysLate
            // 
            this.lblDaysLate.ForeColor = System.Drawing.Color.White;
            this.lblDaysLate.Location = new System.Drawing.Point(620, 254);
            this.lblDaysLate.Name = "lblDaysLate";
            this.lblDaysLate.Size = new System.Drawing.Size(100, 23);
            this.lblDaysLate.TabIndex = 6;
            this.lblDaysLate.Text = "Days Late";
            // 
            // txtDaysLate
            // 
            this.txtDaysLate.Location = new System.Drawing.Point(620, 280);
            this.txtDaysLate.Name = "txtDaysLate";
            this.txtDaysLate.Size = new System.Drawing.Size(250, 22);
            this.txtDaysLate.TabIndex = 7;
            // 
            // lblFine
            // 
            this.lblFine.ForeColor = System.Drawing.Color.White;
            this.lblFine.Location = new System.Drawing.Point(620, 324);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(100, 23);
            this.lblFine.TabIndex = 8;
            this.lblFine.Text = "Fine Amount";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(620, 350);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(250, 22);
            this.txtFine.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(620, 410);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(250, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Fine";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(620, 460);
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
            this.btnClear.Location = new System.Drawing.Point(620, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(7498, 613);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvFines);
            this.Controls.Add(this.lblBorrowerId);
            this.Controls.Add(this.txtBorrowerId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDaysLate);
            this.Controls.Add(this.txtDaysLate);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFines";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
