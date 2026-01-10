using DBBooks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBBooks.Forms.Loan
{
    public partial class LoanReturnForm : Form
    {
        public LoanReturnForm()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_id.Text, out int loan_id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            try
            {
                var repo = new LoanRepository();
                repo.ReturnBook(loan_id);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with returning: " + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
