namespace DBBooks.Forms.Genre
{
    partial class GenreForm
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
            GenreColumn = new DataGridViewTextBoxColumn();
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdColumn, GenreColumn });
            dataGridView1.Location = new Point(93, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(474, 247);
            dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "Genre_id";
            IdColumn.HeaderText = "ID";
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // GenreColumn
            // 
            GenreColumn.DataPropertyName = "GenreName";
            GenreColumn.HeaderText = "Genre";
            GenreColumn.Name = "GenreColumn";
            GenreColumn.ReadOnly = true;
            // 
            // button_add
            // 
            button_add.Location = new Point(12, 12);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 1;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(12, 41);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 2;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(12, 70);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // GenreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 271);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            Name = "GenreForm";
            Text = "Genre";
            Load += GenreForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn GenreColumn;
    }
}