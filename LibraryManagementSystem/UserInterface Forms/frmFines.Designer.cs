using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserInterface_Forms
{
    partial class frmFines
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblOverdueTitle = new System.Windows.Forms.Label();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.labelTotalOverdue = new System.Windows.Forms.Label();
            this.txtTotalOverdue = new System.Windows.Forms.TextBox();
            this.groupCharges = new System.Windows.Forms.GroupBox();
            this.chkLostBook = new System.Windows.Forms.CheckBox();
            this.txtLostFee = new System.Windows.Forms.TextBox();
            this.chkDamagedBook = new System.Windows.Forms.CheckBox();
            this.txtDamagedFee = new System.Windows.Forms.TextBox();
            this.chkLostCard = new System.Windows.Forms.CheckBox();
            this.txtLostCardFee = new System.Windows.Forms.TextBox();
            this.groupPayment = new System.Windows.Forms.GroupBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentDetails = new System.Windows.Forms.Label();
            this.txtPaymentDetails = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupWaiver = new System.Windows.Forms.GroupBox();
            this.txtWaiverReason = new System.Windows.Forms.TextBox();
            this.btnRequestWaiver = new System.Windows.Forms.Button();
            this.dgvWaiverHistory = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherChargeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            this.groupCharges.SuspendLayout();
            this.groupPayment.SuspendLayout();
            this.groupWaiver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiverHistory)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOverdueTitle
            // 
            this.lblOverdueTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblOverdueTitle.ForeColor = System.Drawing.Color.White;
            this.lblOverdueTitle.Location = new System.Drawing.Point(40, 33);
            this.lblOverdueTitle.Name = "lblOverdueTitle";
            this.lblOverdueTitle.Size = new System.Drawing.Size(210, 38);
            this.lblOverdueTitle.TabIndex = 0;
            this.lblOverdueTitle.Text = "Overdue Fines";
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.ColumnHeadersHeight = 29;
            this.dgvOverdue.Location = new System.Drawing.Point(46, 74);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.ReadOnly = true;
            this.dgvOverdue.RowHeadersWidth = 51;
            this.dgvOverdue.Size = new System.Drawing.Size(462, 215);
            this.dgvOverdue.TabIndex = 1;
            // 
            // labelTotalOverdue
            // 
            this.labelTotalOverdue.ForeColor = System.Drawing.Color.White;
            this.labelTotalOverdue.Location = new System.Drawing.Point(43, 298);
            this.labelTotalOverdue.Name = "labelTotalOverdue";
            this.labelTotalOverdue.Size = new System.Drawing.Size(100, 23);
            this.labelTotalOverdue.TabIndex = 2;
            this.labelTotalOverdue.Text = "Total Overdue:";
            // 
            // txtTotalOverdue
            // 
            this.txtTotalOverdue.Location = new System.Drawing.Point(163, 295);
            this.txtTotalOverdue.Name = "txtTotalOverdue";
            this.txtTotalOverdue.ReadOnly = true;
            this.txtTotalOverdue.Size = new System.Drawing.Size(150, 22);
            this.txtTotalOverdue.TabIndex = 3;
            // 
            // groupCharges
            // 
            this.groupCharges.Controls.Add(this.chkLostBook);
            this.groupCharges.Controls.Add(this.txtLostFee);
            this.groupCharges.Controls.Add(this.chkDamagedBook);
            this.groupCharges.Controls.Add(this.txtDamagedFee);
            this.groupCharges.Controls.Add(this.chkLostCard);
            this.groupCharges.Controls.Add(this.txtLostCardFee);
            this.groupCharges.Font = new System.Drawing.Font("Arial", 12F);
            this.groupCharges.ForeColor = System.Drawing.Color.White;
            this.groupCharges.Location = new System.Drawing.Point(542, 33);
            this.groupCharges.Name = "groupCharges";
            this.groupCharges.Size = new System.Drawing.Size(360, 260);
            this.groupCharges.TabIndex = 4;
            this.groupCharges.TabStop = false;
            this.groupCharges.Text = "Other Charges";
            // 
            // chkLostBook
            // 
            this.chkLostBook.Location = new System.Drawing.Point(20, 40);
            this.chkLostBook.Name = "chkLostBook";
            this.chkLostBook.Size = new System.Drawing.Size(188, 24);
            this.chkLostBook.TabIndex = 0;
            this.chkLostBook.Text = "Lost Book";
            // 
            // txtLostFee
            // 
            this.txtLostFee.Location = new System.Drawing.Point(231, 34);
            this.txtLostFee.Name = "txtLostFee";
            this.txtLostFee.ReadOnly = true;
            this.txtLostFee.Size = new System.Drawing.Size(100, 30);
            this.txtLostFee.TabIndex = 1;
            // 
            // chkDamagedBook
            // 
            this.chkDamagedBook.Location = new System.Drawing.Point(20, 90);
            this.chkDamagedBook.Name = "chkDamagedBook";
            this.chkDamagedBook.Size = new System.Drawing.Size(188, 24);
            this.chkDamagedBook.TabIndex = 2;
            this.chkDamagedBook.Text = "Damaged Book";
            // 
            // txtDamagedFee
            // 
            this.txtDamagedFee.Location = new System.Drawing.Point(231, 84);
            this.txtDamagedFee.Name = "txtDamagedFee";
            this.txtDamagedFee.ReadOnly = true;
            this.txtDamagedFee.Size = new System.Drawing.Size(100, 30);
            this.txtDamagedFee.TabIndex = 3;
            // 
            // chkLostCard
            // 
            this.chkLostCard.Location = new System.Drawing.Point(20, 140);
            this.chkLostCard.Name = "chkLostCard";
            this.chkLostCard.Size = new System.Drawing.Size(188, 24);
            this.chkLostCard.TabIndex = 4;
            this.chkLostCard.Text = "Lost Library Card";
            // 
            // txtLostCardFee
            // 
            this.txtLostCardFee.Location = new System.Drawing.Point(231, 137);
            this.txtLostCardFee.Name = "txtLostCardFee";
            this.txtLostCardFee.ReadOnly = true;
            this.txtLostCardFee.Size = new System.Drawing.Size(100, 30);
            this.txtLostCardFee.TabIndex = 5;
            // 
            // groupPayment
            // 
            this.groupPayment.Controls.Add(this.lblPaymentMethod);
            this.groupPayment.Controls.Add(this.cmbPaymentMethod);
            this.groupPayment.Controls.Add(this.lblPaymentDetails);
            this.groupPayment.Controls.Add(this.txtPaymentDetails);
            this.groupPayment.Controls.Add(this.lblGrandTotal);
            this.groupPayment.Controls.Add(this.txtGrandTotal);
            this.groupPayment.Controls.Add(this.btnPay);
            this.groupPayment.Font = new System.Drawing.Font("Arial", 12F);
            this.groupPayment.ForeColor = System.Drawing.Color.White;
            this.groupPayment.Location = new System.Drawing.Point(47, 384);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.Size = new System.Drawing.Size(400, 272);
            this.groupPayment.TabIndex = 5;
            this.groupPayment.TabStop = false;
            this.groupPayment.Text = "Payment";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.lblPaymentMethod.Location = new System.Drawing.Point(20, 40);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(100, 23);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Gcash",
            "Paypal"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(160, 40);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 31);
            this.cmbPaymentMethod.TabIndex = 1;
            // 
            // lblPaymentDetails
            // 
            this.lblPaymentDetails.ForeColor = System.Drawing.Color.White;
            this.lblPaymentDetails.Location = new System.Drawing.Point(20, 100);
            this.lblPaymentDetails.Name = "lblPaymentDetails";
            this.lblPaymentDetails.Size = new System.Drawing.Size(100, 23);
            this.lblPaymentDetails.TabIndex = 2;
            this.lblPaymentDetails.Text = "Details:";
            // 
            // txtPaymentDetails
            // 
            this.txtPaymentDetails.Location = new System.Drawing.Point(160, 100);
            this.txtPaymentDetails.Name = "txtPaymentDetails";
            this.txtPaymentDetails.ReadOnly = true;
            this.txtPaymentDetails.Size = new System.Drawing.Size(200, 30);
            this.txtPaymentDetails.TabIndex = 3;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.ForeColor = System.Drawing.Color.White;
            this.lblGrandTotal.Location = new System.Drawing.Point(20, 160);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(100, 23);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(160, 160);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(100, 30);
            this.txtGrandTotal.TabIndex = 5;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(262, 226);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 31);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // groupWaiver
            // 
            this.groupWaiver.Controls.Add(this.txtWaiverReason);
            this.groupWaiver.Controls.Add(this.btnRequestWaiver);
            this.groupWaiver.Font = new System.Drawing.Font("Arial", 12F);
            this.groupWaiver.ForeColor = System.Drawing.Color.White;
            this.groupWaiver.Location = new System.Drawing.Point(492, 384);
            this.groupWaiver.Name = "groupWaiver";
            this.groupWaiver.Size = new System.Drawing.Size(410, 272);
            this.groupWaiver.TabIndex = 6;
            this.groupWaiver.TabStop = false;
            this.groupWaiver.Text = "Waiver Request";
            // 
            // txtWaiverReason
            // 
            this.txtWaiverReason.Location = new System.Drawing.Point(20, 40);
            this.txtWaiverReason.Multiline = true;
            this.txtWaiverReason.Name = "txtWaiverReason";
            this.txtWaiverReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWaiverReason.Size = new System.Drawing.Size(350, 180);
            this.txtWaiverReason.TabIndex = 0;
            this.txtWaiverReason.TextChanged += new System.EventHandler(this.txtWaiverReason_TextChanged);
            // 
            // btnRequestWaiver
            // 
            this.btnRequestWaiver.Location = new System.Drawing.Point(281, 226);
            this.btnRequestWaiver.Name = "btnRequestWaiver";
            this.btnRequestWaiver.Size = new System.Drawing.Size(89, 32);
            this.btnRequestWaiver.TabIndex = 1;
            this.btnRequestWaiver.Text = "Submit Request";
            // 
            // dgvWaiverHistory
            // 
            this.dgvWaiverHistory.AllowUserToAddRows = false;
            this.dgvWaiverHistory.AllowUserToDeleteRows = false;
            this.dgvWaiverHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWaiverHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvWaiverHistory.ColumnHeadersHeight = 29;
            this.dgvWaiverHistory.Location = new System.Drawing.Point(59, 29);
            this.dgvWaiverHistory.Name = "dgvWaiverHistory";
            this.dgvWaiverHistory.ReadOnly = true;
            this.dgvWaiverHistory.RowHeadersWidth = 51;
            this.dgvWaiverHistory.Size = new System.Drawing.Size(746, 133);
            this.dgvWaiverHistory.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvWaiverHistory);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(46, 684);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(856, 174);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Waiver History";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPaymentHistory);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(46, 920);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment History";
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaymentHistory.ColumnHeadersHeight = 29;
            this.dgvPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.FineID,
            this.OtherChargeID,
            this.AmountPaid,
            this.ChargeType,
            this.PaymentMethod,
            this.Status,
            this.PaymentDate});
            this.dgvPaymentHistory.Location = new System.Drawing.Point(25, 29);
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.RowHeadersWidth = 51;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(802, 133);
            this.dgvPaymentHistory.TabIndex = 12;
            this.dgvPaymentHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentHistory_CellContentClick);
            // 
            // PaymentID
            // 
            this.PaymentID.HeaderText = "PaymentID";
            this.PaymentID.MinimumWidth = 6;
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.ReadOnly = true;
            this.PaymentID.ToolTipText = "Unique ID of the payment";
            this.PaymentID.Visible = false;
            // 
            // FineID
            // 
            this.FineID.HeaderText = "Fine ID";
            this.FineID.MinimumWidth = 6;
            this.FineID.Name = "FineID";
            this.FineID.ReadOnly = true;
            this.FineID.ToolTipText = "Related Fine (if payment is for overdue fine)";
            this.FineID.Visible = false;
            // 
            // OtherChargeID
            // 
            this.OtherChargeID.HeaderText = "Other Charge ID";
            this.OtherChargeID.MinimumWidth = 6;
            this.OtherChargeID.Name = "OtherChargeID";
            this.OtherChargeID.ReadOnly = true;
            this.OtherChargeID.ToolTipText = "Related Other Charge (Lost/Damaged/Lost Card)";
            this.OtherChargeID.Visible = false;
            // 
            // AmountPaid
            // 
            this.AmountPaid.HeaderText = "Amount Paid (₱)";
            this.AmountPaid.MinimumWidth = 6;
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ReadOnly = true;
            this.AmountPaid.ToolTipText = "Amount submitted by the user";
            // 
            // ChargeType
            // 
            this.ChargeType.HeaderText = "Charge Type";
            this.ChargeType.MinimumWidth = 6;
            this.ChargeType.Name = "ChargeType";
            this.ChargeType.ReadOnly = true;
            this.ChargeType.ToolTipText = "Type of other charge (Lost Book / Damaged Book / Lost Card)";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.ToolTipText = "Cash / Gcash / Paypal";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.ToolTipText = "Pending / Paid (requires librarian approval)";
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.MinimumWidth = 6;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.ToolTipText = "Date when payment was submitted";
            // 
            // frmFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(999, 999);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblOverdueTitle);
            this.Controls.Add(this.dgvOverdue);
            this.Controls.Add(this.labelTotalOverdue);
            this.Controls.Add(this.txtTotalOverdue);
            this.Controls.Add(this.groupCharges);
            this.Controls.Add(this.groupPayment);
            this.Controls.Add(this.groupWaiver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFines";
            this.Load += new System.EventHandler(this.frmFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            this.groupCharges.ResumeLayout(false);
            this.groupCharges.PerformLayout();
            this.groupPayment.ResumeLayout(false);
            this.groupPayment.PerformLayout();
            this.groupWaiver.ResumeLayout(false);
            this.groupWaiver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiverHistory)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOverdueTitle;
        private System.Windows.Forms.DataGridView dgvOverdue;

        private System.Windows.Forms.Label labelTotalOverdue;
        private System.Windows.Forms.TextBox txtTotalOverdue;

        private System.Windows.Forms.GroupBox groupCharges;
        private System.Windows.Forms.CheckBox chkLostBook;
        private System.Windows.Forms.TextBox txtLostFee;
        private System.Windows.Forms.CheckBox chkDamagedBook;
        private System.Windows.Forms.TextBox txtDamagedFee;
        private System.Windows.Forms.CheckBox chkLostCard;
        private System.Windows.Forms.TextBox txtLostCardFee;

        private System.Windows.Forms.GroupBox groupPayment;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentDetails;
        private System.Windows.Forms.TextBox txtPaymentDetails;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btnPay;

        private System.Windows.Forms.GroupBox groupWaiver;
        private System.Windows.Forms.TextBox txtWaiverReason;
        private System.Windows.Forms.Button btnRequestWaiver;

        private System.Windows.Forms.DataGridView dgvWaiverHistory;
        private GroupBox groupBox5;
        private GroupBox groupBox1;
        private DataGridView dgvPaymentHistory;
        private DataGridViewTextBoxColumn PaymentID;
        private DataGridViewTextBoxColumn FineID;
        private DataGridViewTextBoxColumn OtherChargeID;
        private DataGridViewTextBoxColumn AmountPaid;
        private DataGridViewTextBoxColumn ChargeType;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn PaymentDate;
    }
}
