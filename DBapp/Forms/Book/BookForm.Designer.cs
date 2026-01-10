namespace DBBooks.Forms.Book
{
    partial class BookForm
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
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            IDColumn = new DataGridViewTextBoxColumn();
            TitleColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            AvailableColumn = new DataGridViewTextBoxColumn();
            StateColumn = new DataGridViewTextBoxColumn();
            AuthorColumn = new DataGridViewTextBoxColumn();
            GenreColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDColumn, TitleColumn, PriceColumn, AvailableColumn, StateColumn, AuthorColumn, GenreColumn });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 361);
            dataGridView1.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.Location = new Point(31, 403);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(112, 403);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 2;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(193, 403);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // IDColumn
            // 
            IDColumn.DataPropertyName = "Book_id";
            IDColumn.HeaderText = "ID";
            IDColumn.Name = "IDColumn";
            IDColumn.ReadOnly = true;
            // 
            // TitleColumn
            // 
            TitleColumn.DataPropertyName = "BookTitle";
            TitleColumn.HeaderText = "Title";
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            PriceColumn.DataPropertyName = "Price";
            PriceColumn.HeaderText = "Price";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // AvailableColumn
            // 
            AvailableColumn.DataPropertyName = "Available";
            AvailableColumn.HeaderText = "Available";
            AvailableColumn.Name = "AvailableColumn";
            AvailableColumn.ReadOnly = true;
            // 
            // StateColumn
            // 
            StateColumn.DataPropertyName = "State";
            StateColumn.HeaderText = "State";
            StateColumn.Name = "StateColumn";
            StateColumn.ReadOnly = true;
            // 
            // AuthorColumn
            // 
            AuthorColumn.DataPropertyName = "Author_id";
            AuthorColumn.HeaderText = "Author";
            AuthorColumn.Name = "AuthorColumn";
            AuthorColumn.ReadOnly = true;
            // 
            // GenreColumn
            // 
            GenreColumn.DataPropertyName = "Genre_id";
            GenreColumn.HeaderText = "Genre";
            GenreColumn.Name = "GenreColumn";
            GenreColumn.ReadOnly = true;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            Name = "BookForm";
            Text = "Book";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn AvailableColumn;
        private DataGridViewTextBoxColumn StateColumn;
        private DataGridViewTextBoxColumn AuthorColumn;
        private DataGridViewTextBoxColumn GenreColumn;
    }
}