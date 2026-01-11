namespace DBBooks.Forms.Loan
{
    partial class LoanForm
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
            IdColumn = new DataGridViewTextBoxColumn();
            PickUpDateColumn = new DataGridViewTextBoxColumn();
            ReturnDateColumn = new DataGridViewTextBoxColumn();
            UserColumn = new DataGridViewTextBoxColumn();
            BookColumn = new DataGridViewTextBoxColumn();
            button_pickUp = new Button();
            button_return = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdColumn, PickUpDateColumn, ReturnDateColumn, UserColumn, BookColumn });
            dataGridView1.Location = new Point(148, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(640, 247);
            dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "Loan_id";
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // PickUpDateColumn
            // 
            PickUpDateColumn.DataPropertyName = "PickUpDate";
            PickUpDateColumn.HeaderText = "Pick Up Date";
            PickUpDateColumn.Name = "PickUpDateColumn";
            PickUpDateColumn.ReadOnly = true;
            // 
            // ReturnDateColumn
            // 
            ReturnDateColumn.DataPropertyName = "ReturnDate";
            ReturnDateColumn.HeaderText = "Return Date";
            ReturnDateColumn.Name = "ReturnDateColumn";
            ReturnDateColumn.ReadOnly = true;
            // 
            // UserColumn
            // 
            UserColumn.DataPropertyName = "User_id";
            UserColumn.HeaderText = "User Id";
            UserColumn.Name = "UserColumn";
            UserColumn.ReadOnly = true;
            // 
            // BookColumn
            // 
            BookColumn.DataPropertyName = "Book_id";
            BookColumn.HeaderText = "Book ID";
            BookColumn.Name = "BookColumn";
            BookColumn.ReadOnly = true;
            // 
            // button_pickUp
            // 
            button_pickUp.Location = new Point(33, 27);
            button_pickUp.Name = "button_pickUp";
            button_pickUp.Size = new Size(75, 23);
            button_pickUp.TabIndex = 1;
            button_pickUp.Text = "Pick Up";
            button_pickUp.UseVisualStyleBackColor = true;
            button_pickUp.Click += button_pickUp_Click;
            // 
            // button_return
            // 
            button_return.Location = new Point(33, 65);
            button_return.Name = "button_return";
            button_return.Size = new Size(75, 23);
            button_return.TabIndex = 2;
            button_return.Text = "Return";
            button_return.UseVisualStyleBackColor = true;
            button_return.Click += button_return_Click;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 271);
            Controls.Add(button_return);
            Controls.Add(button_pickUp);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan";
            Load += LoanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn PickUpDateColumn;
        private DataGridViewTextBoxColumn ReturnDateColumn;
        private DataGridViewTextBoxColumn UserColumn;
        private DataGridViewTextBoxColumn BookColumn;
        private Button button_pickUp;
        private Button button_return;
    }
}