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

namespace DBBooks.Forms.Reports
{
    public partial class AuthorReportForm : Form
    {
        private AuthorReportRepository repository;
        public AuthorReportForm()
        {
            InitializeComponent();
            repository = new AuthorReportRepository();
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                dataGridView1.DataSource = repository.GetAuthorLoanStats();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with loading author report " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
