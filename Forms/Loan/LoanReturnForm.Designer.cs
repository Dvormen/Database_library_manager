namespace DBBooks.Forms.Loan
{
    partial class LoanReturnForm
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
            textBox_id = new TextBox();
            button_back = new Button();
            button_return = new Button();
            SuspendLayout();
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(92, 116);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "ID to return";
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 8;
            // 
            // button_back
            // 
            button_back.Location = new Point(235, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 7;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_return
            // 
            button_return.Location = new Point(104, 145);
            button_return.Name = "button_return";
            button_return.Size = new Size(75, 23);
            button_return.TabIndex = 6;
            button_return.Text = "Return";
            button_return.UseVisualStyleBackColor = true;
            button_return.Click += button_return_Click;
            // 
            // LoanReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 234);
            Controls.Add(textBox_id);
            Controls.Add(button_back);
            Controls.Add(button_return);
            Name = "LoanReturnForm";
            Text = "Loan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_id;
        private Button button_back;
        private Button button_return;
    }
}