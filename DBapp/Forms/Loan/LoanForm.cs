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

namespace DBBooks.Forms.Loan
{
    public partial class LoanForm : Form
    {
        private LoanRepository repository;
        public LoanForm()
        {
            InitializeComponent();
            repository = new LoanRepository();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                dataGridView1.DataSource = repository.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with loading loans " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_pickUp_Click(object sender, EventArgs e)
        {
            var form = new LoanPickUpForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            var form = new LoanReturnForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            var repo = new LoanRepository();
            dataGridView1.DataSource = repo.GetAll();
        }
    }
}
