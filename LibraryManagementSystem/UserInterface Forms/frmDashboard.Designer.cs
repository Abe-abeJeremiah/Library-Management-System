namespace LibraryManagementSystem.UserInterface_Forms
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQntyBorrowed = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQntyOverdue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQntyReturned = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.grdDashboard = new System.Windows.Forms.DataGridView();
            this.grdBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPublicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPaid = new System.Windows.Forms.Label();
            this.labelUnpaid = new System.Windows.Forms.Label();
            this.lblTotalFines = new System.Windows.Forms.Label();
            this.lblUnpaidFines = new System.Windows.Forms.Label();
            this.lblPaidFines = new System.Windows.Forms.Label();
            this.PanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
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
            this.PanelUser.Location = new System.Drawing.Point(37, 15);
            this.PanelUser.Margin = new System.Windows.Forms.Padding(4);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(269, 140);
            this.PanelUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(172, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "icon ning pic ";
            // 
            // lblQntyBorrowed
            // 
            this.lblQntyBorrowed.AutoSize = true;
            this.lblQntyBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntyBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblQntyBorrowed.Location = new System.Drawing.Point(71, 64);
            this.lblQntyBorrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQntyBorrowed.Name = "lblQntyBorrowed";
            this.lblQntyBorrowed.Size = new System.Drawing.Size(37, 39);
            this.lblQntyBorrowed.TabIndex = 1;
            this.lblQntyBorrowed.Text = "1";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblRole.Location = new System.Drawing.Point(24, 103);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(134, 15);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "For the last 28 Days";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(20, 21);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 32);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Borrowed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblQntyOverdue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(343, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 140);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(172, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "icon ning pic ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQntyOverdue
            // 
            this.lblQntyOverdue.AutoSize = true;
            this.lblQntyOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntyOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lblQntyOverdue.Location = new System.Drawing.Point(71, 59);
            this.lblQntyOverdue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQntyOverdue.Name = "lblQntyOverdue";
            this.lblQntyOverdue.Size = new System.Drawing.Size(37, 39);
            this.lblQntyOverdue.TabIndex = 1;
            this.lblQntyOverdue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "For the last 28 Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Overdue";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(175, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblQntyReturned);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(656, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 140);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label6.Location = new System.Drawing.Point(172, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "icon ning pic ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(71, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 39);
            this.label7.TabIndex = 1;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(24, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "For the last 28 Days";
            // 
            // lblQntyReturned
            // 
            this.lblQntyReturned.AutoSize = true;
            this.lblQntyReturned.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntyReturned.ForeColor = System.Drawing.Color.White;
            this.lblQntyReturned.Location = new System.Drawing.Point(20, 21);
            this.lblQntyReturned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQntyReturned.Name = "lblQntyReturned";
            this.lblQntyReturned.Size = new System.Drawing.Size(119, 32);
            this.lblQntyReturned.TabIndex = 1;
            this.lblQntyReturned.Text = "Returned";
            this.lblQntyReturned.Click += new System.EventHandler(this.lblQntyReturned_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(175, 26);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // grdDashboard
            // 
            this.grdDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.grdDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdBookTitle,
            this.grdAuthor,
            this.grdPublisher,
            this.grdCategory,
            this.grdLanguage,
            this.grdPublicationYear});
            this.grdDashboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.grdDashboard.Location = new System.Drawing.Point(37, 586);
            this.grdDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.grdDashboard.Name = "grdDashboard";
            this.grdDashboard.RowHeadersWidth = 51;
            this.grdDashboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDashboard.Size = new System.Drawing.Size(945, 155);
            this.grdDashboard.TabIndex = 4;
            this.grdDashboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDashboard_CellContentClick);
            // 
            // grdBookTitle
            // 
            this.grdBookTitle.HeaderText = "Book Title";
            this.grdBookTitle.MinimumWidth = 6;
            this.grdBookTitle.Name = "grdBookTitle";
            // 
            // grdAuthor
            // 
            this.grdAuthor.HeaderText = "Author";
            this.grdAuthor.MinimumWidth = 6;
            this.grdAuthor.Name = "grdAuthor";
            // 
            // grdPublisher
            // 
            this.grdPublisher.HeaderText = "Publisher";
            this.grdPublisher.MinimumWidth = 6;
            this.grdPublisher.Name = "grdPublisher";
            // 
            // grdCategory
            // 
            this.grdCategory.HeaderText = "Category";
            this.grdCategory.MinimumWidth = 6;
            this.grdCategory.Name = "grdCategory";
            // 
            // grdLanguage
            // 
            this.grdLanguage.HeaderText = "Language";
            this.grdLanguage.MinimumWidth = 6;
            this.grdLanguage.Name = "grdLanguage";
            // 
            // grdPublicationYear
            // 
            this.grdPublicationYear.HeaderText = "Publication Year";
            this.grdPublicationYear.MinimumWidth = 6;
            this.grdPublicationYear.Name = "grdPublicationYear";
            // 
            // chartDashboard
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDashboard.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDashboard.Legends.Add(legend4);
            this.chartDashboard.Location = new System.Drawing.Point(37, 174);
            this.chartDashboard.Name = "chartDashboard";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDashboard.Series.Add(series4);
            this.chartDashboard.Size = new System.Drawing.Size(895, 300);
            this.chartDashboard.TabIndex = 5;
            this.chartDashboard.Text = "chart1";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(60, 488);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(93, 23);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total Fines:";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.BackColor = System.Drawing.Color.White;
            this.labelPaid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaid.ForeColor = System.Drawing.Color.Black;
            this.labelPaid.Location = new System.Drawing.Point(417, 488);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(46, 23);
            this.labelPaid.TabIndex = 7;
            this.labelPaid.Text = "Paid:";
            this.labelPaid.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelUnpaid
            // 
            this.labelUnpaid.AutoSize = true;
            this.labelUnpaid.BackColor = System.Drawing.Color.White;
            this.labelUnpaid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnpaid.ForeColor = System.Drawing.Color.Black;
            this.labelUnpaid.Location = new System.Drawing.Point(721, 488);
            this.labelUnpaid.Name = "labelUnpaid";
            this.labelUnpaid.Size = new System.Drawing.Size(69, 23);
            this.labelUnpaid.TabIndex = 8;
            this.labelUnpaid.Text = "Unpaid:";
            this.labelUnpaid.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblTotalFines
            // 
            this.lblTotalFines.AutoSize = true;
            this.lblTotalFines.BackColor = System.Drawing.Color.White;
            this.lblTotalFines.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFines.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFines.Location = new System.Drawing.Point(184, 488);
            this.lblTotalFines.Name = "lblTotalFines";
            this.lblTotalFines.Size = new System.Drawing.Size(62, 25);
            this.lblTotalFines.TabIndex = 9;
            this.lblTotalFines.Text = "₱ 0.00";
            // 
            // lblUnpaidFines
            // 
            this.lblUnpaidFines.AutoSize = true;
            this.lblUnpaidFines.BackColor = System.Drawing.Color.Red;
            this.lblUnpaidFines.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidFines.ForeColor = System.Drawing.Color.Black;
            this.lblUnpaidFines.Location = new System.Drawing.Point(814, 488);
            this.lblUnpaidFines.Name = "lblUnpaidFines";
            this.lblUnpaidFines.Size = new System.Drawing.Size(62, 25);
            this.lblUnpaidFines.TabIndex = 12;
            this.lblUnpaidFines.Text = "₱ 0.00";
            // 
            // lblPaidFines
            // 
            this.lblPaidFines.AutoSize = true;
            this.lblPaidFines.BackColor = System.Drawing.Color.LightGreen;
            this.lblPaidFines.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidFines.ForeColor = System.Drawing.Color.Black;
            this.lblPaidFines.Location = new System.Drawing.Point(485, 488);
            this.lblPaidFines.Name = "lblPaidFines";
            this.lblPaidFines.Size = new System.Drawing.Size(62, 25);
            this.lblPaidFines.TabIndex = 13;
            this.lblPaidFines.Text = "₱ 0.00";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(999, 754);
            this.Controls.Add(this.lblPaidFines);
            this.Controls.Add(this.lblUnpaidFines);
            this.Controls.Add(this.lblTotalFines);
            this.Controls.Add(this.labelUnpaid);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.chartDashboard);
            this.Controls.Add(this.grdDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQntyBorrowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQntyOverdue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQntyReturned;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView grdDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPublicationYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.Label labelUnpaid;
        private System.Windows.Forms.Label lblTotalFines;
        private System.Windows.Forms.Label lblUnpaidFines;
        private System.Windows.Forms.Label lblPaidFines;
    }
}
