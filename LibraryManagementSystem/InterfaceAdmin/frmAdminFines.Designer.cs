using System.Windows.Forms;

namespace LibraryManagementSystem.InterfaceAdmin
{
    partial class frmAdminFines
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
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFineHistory1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllPayments = new System.Windows.Forms.DataGridView();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRejectPayment = new System.Windows.Forms.Button();
            this.btnApprovePaymentGlobal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(863, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Waive Fine";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(874, 83);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Actions";
            // 
            // dgvFines
            // 
            this.dgvFines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvFines.ColumnHeadersHeight = 29;
            this.dgvFines.ColumnHeadersVisible = false;
            this.dgvFines.Location = new System.Drawing.Point(3, 123);
            this.dgvFines.MultiSelect = false;
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.ReadOnly = true;
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFines.Size = new System.Drawing.Size(853, 170);
            this.dgvFines.TabIndex = 0;
            this.dgvFines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFines_CellClick);
            this.dgvFines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFines_CellContentClick);
            // 
            // txtDeduction
            // 
            this.txtDeduction.Location = new System.Drawing.Point(787, 299);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(60, 22);
            this.txtDeduction.TabIndex = 8;
            this.txtDeduction.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(643, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deduction Amount :";
            // 
            // btnFineHistory1
            // 
            this.btnFineHistory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.btnFineHistory1.ForeColor = System.Drawing.Color.White;
            this.btnFineHistory1.Location = new System.Drawing.Point(3, 26);
            this.btnFineHistory1.Name = "btnFineHistory1";
            this.btnFineHistory1.Size = new System.Drawing.Size(113, 23);
            this.btnFineHistory1.TabIndex = 10;
            this.btnFineHistory1.Text = "📜 Fine History";
            this.btnFineHistory1.UseVisualStyleBackColor = false;
            this.btnFineHistory1.Click += new System.EventHandler(this.btnFineHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Active Fines";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAllPayments
            // 
            this.dgvAllPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvAllPayments.ColumnHeadersHeight = 29;
            this.dgvAllPayments.ColumnHeadersVisible = false;
            this.dgvAllPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colChargeID,
            this.colChargeType,
            this.colAmount,
            this.colPaymentMethod,
            this.colStatus,
            this.colPaymentDate});
            this.dgvAllPayments.Location = new System.Drawing.Point(3, 376);
            this.dgvAllPayments.MultiSelect = false;
            this.dgvAllPayments.Name = "dgvAllPayments";
            this.dgvAllPayments.ReadOnly = true;
            this.dgvAllPayments.RowHeadersWidth = 51;
            this.dgvAllPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPayments.Size = new System.Drawing.Size(853, 170);
            this.dgvAllPayments.TabIndex = 12;
            this.dgvAllPayments.AutoSizeColumnsModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventHandler(this.dgvAllPayments_AutoSizeColumnsModeChanged);
            this.dgvAllPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllPayments_CellClick);
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "User Name";
            this.colUserName.MinimumWidth = 6;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 125;
            // 
            // colChargeID
            // 
            this.colChargeID.HeaderText = "Reference ID";
            this.colChargeID.MinimumWidth = 6;
            this.colChargeID.Name = "colChargeID";
            this.colChargeID.ReadOnly = true;
            this.colChargeID.Width = 125;
            // 
            // colChargeType
            // 
            this.colChargeType.HeaderText = "Charge Type";
            this.colChargeType.MinimumWidth = 6;
            this.colChargeType.Name = "colChargeType";
            this.colChargeType.ReadOnly = true;
            this.colChargeType.Width = 125;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount (₱)";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 125;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.HeaderText = "Payment Method";
            this.colPaymentMethod.MinimumWidth = 6;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            this.colPaymentMethod.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.HeaderText = "Payment Date";
            this.colPaymentDate.MinimumWidth = 6;
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;
            this.colPaymentDate.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Payments";
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.BackColor = System.Drawing.SystemColors.Window;
            this.btnMarkPaid.Enabled = false;
            this.btnMarkPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkPaid.ForeColor = System.Drawing.Color.Black;
            this.btnMarkPaid.Location = new System.Drawing.Point(863, 173);
            this.btnMarkPaid.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(116, 30);
            this.btnMarkPaid.TabIndex = 14;
            this.btnMarkPaid.Text = "Mark as Paid";
            this.btnMarkPaid.UseVisualStyleBackColor = false;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(882, 376);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Actions";
            // 
            // btnRejectPayment
            // 
            this.btnRejectPayment.BackColor = System.Drawing.SystemColors.Window;
            this.btnRejectPayment.Enabled = false;
            this.btnRejectPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectPayment.ForeColor = System.Drawing.Color.Black;
            this.btnRejectPayment.Location = new System.Drawing.Point(863, 461);
            this.btnRejectPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnRejectPayment.Name = "btnRejectPayment";
            this.btnRejectPayment.Size = new System.Drawing.Size(116, 30);
            this.btnRejectPayment.TabIndex = 17;
            this.btnRejectPayment.Text = "Reject";
            this.btnRejectPayment.UseVisualStyleBackColor = false;
            this.btnRejectPayment.Click += new System.EventHandler(this.btnRejectPayment_Click_1);
            // 
            // btnApprovePaymentGlobal
            // 
            this.btnApprovePaymentGlobal.BackColor = System.Drawing.SystemColors.Window;
            this.btnApprovePaymentGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprovePaymentGlobal.ForeColor = System.Drawing.Color.Black;
            this.btnApprovePaymentGlobal.Location = new System.Drawing.Point(863, 412);
            this.btnApprovePaymentGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.btnApprovePaymentGlobal.Name = "btnApprovePaymentGlobal";
            this.btnApprovePaymentGlobal.Size = new System.Drawing.Size(116, 30);
            this.btnApprovePaymentGlobal.TabIndex = 16;
            this.btnApprovePaymentGlobal.Text = "Approve";
            this.btnApprovePaymentGlobal.UseVisualStyleBackColor = false;
            this.btnApprovePaymentGlobal.Click += new System.EventHandler(this.btnApprovePaymentGlobal_Click_1);
            // 
            // frmAdminFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(991, 706);
            this.Controls.Add(this.btnRejectPayment);
            this.Controls.Add(this.btnApprovePaymentGlobal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMarkPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAllPayments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFineHistory1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDeduction);
            this.Controls.Add(this.dgvFines);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminFines";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmAdminFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private TextBox txtDeduction;
        private Label label5;
        private Button btnFineHistory1;
        private Label label1;
        private DataGridView dgvAllPayments;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colChargeID;
        private DataGridViewTextBoxColumn colChargeType;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colPaymentDate;
        private Label label2;
        private Button btnMarkPaid;
        private Label label3;
        private Button btnRejectPayment;
        private Button btnApprovePaymentGlobal;
    }
}
