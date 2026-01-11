namespace DBBooks.Forms.User
{
    partial class UserForm
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
            UsernameColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdColumn, UsernameColumn, EmailColumn });
            dataGridView1.Location = new Point(88, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(415, 215);
            dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "User_id";
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // UsernameColumn
            // 
            UsernameColumn.DataPropertyName = "Username";
            UsernameColumn.HeaderText = "Username";
            UsernameColumn.Name = "UsernameColumn";
            UsernameColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            EmailColumn.DataPropertyName = "Email";
            EmailColumn.HeaderText = "Email";
            EmailColumn.Name = "EmailColumn";
            EmailColumn.ReadOnly = true;
            // 
            // button_add
            // 
            button_add.Location = new Point(7, 12);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(7, 41);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 2;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(7, 70);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 239);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn UsernameColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private Button button_add;
        private Button button_update;
        private Button button_delete;
    }
}