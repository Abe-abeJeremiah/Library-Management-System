
namespace LibraryManagementSystem.InterfaceAdmin
{
    partial class frmFineHistory
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
            this.dgvFineHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFineHistory
            // 
            this.dgvFineHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFineHistory.Location = new System.Drawing.Point(36, 63);
            this.dgvFineHistory.Name = "dgvFineHistory";
            this.dgvFineHistory.RowHeadersWidth = 51;
            this.dgvFineHistory.RowTemplate.Height = 24;
            this.dgvFineHistory.Size = new System.Drawing.Size(734, 224);
            this.dgvFineHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fine Audit History";
            // 
            // frmFineHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFineHistory);
            this.Name = "frmFineHistory";
            this.Text = "frmFineHistory";
            this.Load += new System.EventHandler(this.frmFineHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFineHistory;
        private System.Windows.Forms.Label label1;
    }
}
