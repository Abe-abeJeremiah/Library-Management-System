namespace LibraryManagementSystem.UserInterface_Forms
{
    partial class frmBookControler
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
            this.pnlBookDetails = new System.Windows.Forms.Panel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblPublicationYear = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPhysicalDescripton = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAccessionNumber = new System.Windows.Forms.Label();
            this.pctBook = new System.Windows.Forms.PictureBox();
            this.pnlBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBookDetails
            // 
            this.pnlBookDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlBookDetails.Controls.Add(this.btnBorrow);
            this.pnlBookDetails.Controls.Add(this.btnReserve);
            this.pnlBookDetails.Controls.Add(this.lblLocation);
            this.pnlBookDetails.Controls.Add(this.lblPages);
            this.pnlBookDetails.Controls.Add(this.lblEdition);
            this.pnlBookDetails.Controls.Add(this.lblEditor);
            this.pnlBookDetails.Controls.Add(this.lblPublicationYear);
            this.pnlBookDetails.Controls.Add(this.lblPublisher);
            this.pnlBookDetails.Controls.Add(this.lblPhysicalDescripton);
            this.pnlBookDetails.Controls.Add(this.lblAuthor);
            this.pnlBookDetails.Controls.Add(this.lblISBN);
            this.pnlBookDetails.Controls.Add(this.lblSubTitle);
            this.pnlBookDetails.Controls.Add(this.lblLanguage);
            this.pnlBookDetails.Controls.Add(this.lblCategory);
            this.pnlBookDetails.Controls.Add(this.lblTitle);
            this.pnlBookDetails.Controls.Add(this.lblAccessionNumber);
            this.pnlBookDetails.Controls.Add(this.pctBook);
            this.pnlBookDetails.Location = new System.Drawing.Point(0, 4);
            this.pnlBookDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBookDetails.Name = "pnlBookDetails";
            this.pnlBookDetails.Size = new System.Drawing.Size(445, 346);
            this.pnlBookDetails.TabIndex = 3;
            this.pnlBookDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBookDetails_Paint);
            // 
            // btnBorrow
            // 
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Location = new System.Drawing.Point(245, 305);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(160, 28);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click_1);
            // 
            // btnReserve
            // 
            this.btnReserve.ForeColor = System.Drawing.Color.Black;
            this.btnReserve.Location = new System.Drawing.Point(43, 305);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(160, 28);
            this.btnReserve.TabIndex = 3;
            this.btnReserve.Text = "Reserve This";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click_1);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(301, 102);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(80, 23);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location ";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.ForeColor = System.Drawing.Color.White;
            this.lblPages.Location = new System.Drawing.Point(296, 23);
            this.lblPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(140, 23);
            this.lblPages.TabIndex = 1;
            this.lblPages.Text = "Number of pages";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.ForeColor = System.Drawing.Color.White;
            this.lblEdition.Location = new System.Drawing.Point(336, 273);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(67, 23);
            this.lblEdition.TabIndex = 1;
            this.lblEdition.Text = "Edition";
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditor.ForeColor = System.Drawing.Color.White;
            this.lblEditor.Location = new System.Drawing.Point(169, 123);
            this.lblEditor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(59, 23);
            this.lblEditor.TabIndex = 1;
            this.lblEditor.Text = "Editor";
            // 
            // lblPublicationYear
            // 
            this.lblPublicationYear.AutoSize = true;
            this.lblPublicationYear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicationYear.ForeColor = System.Drawing.Color.White;
            this.lblPublicationYear.Location = new System.Drawing.Point(153, 273);
            this.lblPublicationYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublicationYear.Name = "lblPublicationYear";
            this.lblPublicationYear.Size = new System.Drawing.Size(139, 23);
            this.lblPublicationYear.TabIndex = 1;
            this.lblPublicationYear.Text = "Publication Year";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.White;
            this.lblPublisher.Location = new System.Drawing.Point(27, 273);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(84, 23);
            this.lblPublisher.TabIndex = 1;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblPhysicalDescripton
            // 
            this.lblPhysicalDescripton.AutoSize = true;
            this.lblPhysicalDescripton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalDescripton.ForeColor = System.Drawing.Color.White;
            this.lblPhysicalDescripton.Location = new System.Drawing.Point(39, 218);
            this.lblPhysicalDescripton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhysicalDescripton.Name = "lblPhysicalDescripton";
            this.lblPhysicalDescripton.Size = new System.Drawing.Size(263, 32);
            this.lblPhysicalDescripton.TabIndex = 1;
            this.lblPhysicalDescripton.Text = "Physical description...";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(167, 98);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(75, 25);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(51, 145);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(61, 25);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN ";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(169, 47);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(71, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "SubTitle";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(296, 68);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(85, 23);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Language";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(169, 68);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(161, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Book Title";
            // 
            // lblAccessionNumber
            // 
            this.lblAccessionNumber.AutoSize = true;
            this.lblAccessionNumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessionNumber.ForeColor = System.Drawing.Color.White;
            this.lblAccessionNumber.Location = new System.Drawing.Point(8, 170);
            this.lblAccessionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessionNumber.Name = "lblAccessionNumber";
            this.lblAccessionNumber.Size = new System.Drawing.Size(149, 23);
            this.lblAccessionNumber.TabIndex = 1;
            this.lblAccessionNumber.Text = "Accession number";
            // 
            // pctBook
            // 
            this.pctBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBook.Image = global::LibraryManagementSystem.Properties.Resources.book;
            this.pctBook.Location = new System.Drawing.Point(4, 4);
            this.pctBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctBook.Name = "pctBook";
            this.pctBook.Size = new System.Drawing.Size(154, 141);
            this.pctBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBook.TabIndex = 0;
            this.pctBook.TabStop = false;
            this.pctBook.Click += new System.EventHandler(this.pctBook_Click);
            // 
            // frmBookControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(445, 346);
            this.Controls.Add(this.pnlBookDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBookControler";
            this.Text = "frmBookControler";
            this.pnlBookDetails.ResumeLayout(false);
            this.pnlBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBookDetails;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.Label lblPublicationYear;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPhysicalDescripton;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccessionNumber;
        private System.Windows.Forms.PictureBox pctBook;
    }
}
