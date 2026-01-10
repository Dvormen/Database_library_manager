namespace DBBooks.Forms.Author
{
    partial class AuthorAddForm
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
            button_back = new Button();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            button_import = new Button();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Location = new Point(137, 142);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 0;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(266, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 1;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(56, 113);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.PlaceholderText = "Fisrt name";
            textBox_firstName.Size = new Size(100, 23);
            textBox_firstName.TabIndex = 2;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(195, 113);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.PlaceholderText = "Last name";
            textBox_lastName.Size = new Size(100, 23);
            textBox_lastName.TabIndex = 3;
            // 
            // button_import
            // 
            button_import.Location = new Point(137, 199);
            button_import.Name = "button_import";
            button_import.Size = new Size(75, 23);
            button_import.TabIndex = 4;
            button_import.Text = "Import";
            button_import.UseVisualStyleBackColor = true;
            button_import.Click += button_import_Click;
            // 
            // AuthorAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 234);
            Controls.Add(button_import);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_firstName);
            Controls.Add(button_back);
            Controls.Add(button_add);
            Name = "AuthorAddForm";
            Text = "Author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add;
        private Button button_back;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Button button_import;
    }
}