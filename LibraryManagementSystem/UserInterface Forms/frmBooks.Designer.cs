namespace LibraryManagementSystem.UserInterface_Forms
{
    partial class frmBooks
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
            this.tblBooks = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tblBooks
            // 
            this.tblBooks.AutoScroll = true;
            this.tblBooks.ColumnCount = 2;
            this.tblBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBooks.Location = new System.Drawing.Point(0, 0);
            this.tblBooks.Name = "tblBooks";
            this.tblBooks.RowCount = 2;
            this.tblBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBooks.Size = new System.Drawing.Size(749, 613);
            this.tblBooks.TabIndex = 0;
            this.tblBooks.Paint += new System.Windows.Forms.PaintEventHandler(this.tblBooks_Paint);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(749, 613);
            this.Controls.Add(this.tblBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooks";
            this.Text = "frmBooks";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBooks;
    }
}