namespace DBBooks.Forms.Author
{
    partial class AuthorForm
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
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            dataGridView1 = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            firstNameColumn = new DataGridViewTextBoxColumn();
            LastNameColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Location = new Point(12, 12);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 0;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(12, 41);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 1;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(12, 70);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 2;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdColumn, firstNameColumn, LastNameColumn });
            dataGridView1.Location = new Point(93, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(559, 250);
            dataGridView1.TabIndex = 3;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "Author_id";
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // firstNameColumn
            // 
            firstNameColumn.DataPropertyName = "FirstName";
            firstNameColumn.HeaderText = "First Name";
            firstNameColumn.Name = "firstNameColumn";
            firstNameColumn.ReadOnly = true;
            // 
            // LastNameColumn
            // 
            LastNameColumn.DataPropertyName = "LastName";
            LastNameColumn.HeaderText = "Last Name";
            LastNameColumn.Name = "LastNameColumn";
            LastNameColumn.ReadOnly = true;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 274);
            Controls.Add(dataGridView1);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Author";
            Load += AuthorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn firstNameColumn;
        private DataGridViewTextBoxColumn LastNameColumn;
    }
}