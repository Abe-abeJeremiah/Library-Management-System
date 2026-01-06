namespace LibraryManagementSystem.InterfaceAdmin
{
    partial class frmAdminDashboard
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
            this.PanelUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQntyBorrowed = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQntyOverdue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQntyReturned = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvRecentBorrow = new System.Windows.Forms.DataGridView();
            this.PanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PanelUser.Controls.Add(this.label1);
            this.PanelUser.Controls.Add(this.lblQntyBorrowed);
            this.PanelUser.Controls.Add(this.lblRole);
            this.PanelUser.Controls.Add(this.lblUserName);
            this.PanelUser.Controls.Add(this.pictureBox1);
            this.PanelUser.Location = new System.Drawing.Point(16, 32);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(269, 140);
            this.PanelUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQntyBorrowed
            // 
            this.lblQntyBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.lblQntyBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblQntyBorrowed.Location = new System.Drawing.Point(98, 64);
            this.lblQntyBorrowed.Name = "lblQntyBorrowed";
            this.lblQntyBorrowed.Size = new System.Drawing.Size(100, 34);
            this.lblQntyBorrowed.TabIndex = 1;
            this.lblQntyBorrowed.Text = "0";
            // 
            // lblRole
            // 
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblRole.Location = new System.Drawing.Point(3, 107);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(100, 23);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "System Administrator";
            // 
            // lblUserName
            // 
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(3, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(140, 29);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Book Available";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblQntyOverdue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(321, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 140);
            this.panel1.TabIndex = 1;
            // 
            // lblQntyOverdue
            // 
            this.lblQntyOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.lblQntyOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblQntyOverdue.Location = new System.Drawing.Point(99, 59);
            this.lblQntyOverdue.Name = "lblQntyOverdue";
            this.lblQntyOverdue.Size = new System.Drawing.Size(100, 43);
            this.lblQntyOverdue.TabIndex = 0;
            this.lblQntyOverdue.Text = "0";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Book Borrowed";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblQntyReturned);
            this.panel2.Location = new System.Drawing.Point(635, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 140);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(69, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "0";
            // 
            // lblQntyReturned
            // 
            this.lblQntyReturned.ForeColor = System.Drawing.Color.White;
            this.lblQntyReturned.Location = new System.Drawing.Point(21, 26);
            this.lblQntyReturned.Name = "lblQntyReturned";
            this.lblQntyReturned.Size = new System.Drawing.Size(100, 23);
            this.lblQntyReturned.TabIndex = 1;
            this.lblQntyReturned.Text = "Book Returned";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // chartDashboard
            // 
            this.chartDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.chartDashboard.Location = new System.Drawing.Point(16, 208);
            this.chartDashboard.Name = "chartDashboard";
            this.chartDashboard.Size = new System.Drawing.Size(909, 170);
            this.chartDashboard.TabIndex = 3;
            // 
            // dgvRecentBorrow
            // 
            this.dgvRecentBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentBorrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvRecentBorrow.ColumnHeadersHeight = 29;
            this.dgvRecentBorrow.Location = new System.Drawing.Point(16, 385);
            this.dgvRecentBorrow.Name = "dgvRecentBorrow";
            this.dgvRecentBorrow.ReadOnly = true;
            this.dgvRecentBorrow.RowHeadersVisible = false;
            this.dgvRecentBorrow.RowHeadersWidth = 51;
            this.dgvRecentBorrow.Size = new System.Drawing.Size(909, 177);
            this.dgvRecentBorrow.TabIndex = 4;
            // 
            // frmAdminDashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(977, 706);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartDashboard);
            this.Controls.Add(this.dgvRecentBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.PanelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Label lblQntyBorrowed;
        private System.Windows.Forms.Label lblQntyOverdue;
        private System.Windows.Forms.Label lblQntyReturned;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private System.Windows.Forms.DataGridView dgvRecentBorrow;
    }
}
