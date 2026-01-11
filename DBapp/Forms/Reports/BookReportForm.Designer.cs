namespace DBBooks.Forms.Reports
{
    partial class BookReportForm
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
            dataGridView1 = new DataGridView();
            TitleColumn = new DataGridViewTextBoxColumn();
            GenreColumn = new DataGridViewTextBoxColumn();
            LoanCountColumn = new DataGridViewTextBoxColumn();
            FirstLoanColumn = new DataGridViewTextBoxColumn();
            ReturnColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TitleColumn, GenreColumn, LoanCountColumn, FirstLoanColumn, ReturnColumn });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(663, 435);
            dataGridView1.TabIndex = 0;
            // 
            // TitleColumn
            // 
            TitleColumn.DataPropertyName = "BookTitle";
            TitleColumn.HeaderText = "Title";
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            // 
            // GenreColumn
            // 
            GenreColumn.DataPropertyName = "Genre";
            GenreColumn.HeaderText = "Genre";
            GenreColumn.Name = "GenreColumn";
            GenreColumn.ReadOnly = true;
            // 
            // LoanCountColumn
            // 
            LoanCountColumn.DataPropertyName = "LoanCount";
            LoanCountColumn.HeaderText = "Count of Loans";
            LoanCountColumn.Name = "LoanCountColumn";
            LoanCountColumn.ReadOnly = true;
            // 
            // FirstLoanColumn
            // 
            FirstLoanColumn.DataPropertyName = "FirstLoan";
            FirstLoanColumn.HeaderText = "First Loan";
            FirstLoanColumn.Name = "FirstLoanColumn";
            FirstLoanColumn.ReadOnly = true;
            // 
            // ReturnColumn
            // 
            ReturnColumn.DataPropertyName = "LastReturn";
            ReturnColumn.HeaderText = "Last Return";
            ReturnColumn.Name = "ReturnColumn";
            ReturnColumn.ReadOnly = true;
            // 
            // BookReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 442);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Report";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn GenreColumn;
        private DataGridViewTextBoxColumn LoanCountColumn;
        private DataGridViewTextBoxColumn FirstLoanColumn;
        private DataGridViewTextBoxColumn ReturnColumn;
    }
}