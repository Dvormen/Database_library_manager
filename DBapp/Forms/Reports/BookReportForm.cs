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
    public partial class BookReportForm : Form
    {
        private BookReportRepository repository;
        public BookReportForm()
        {
            InitializeComponent();
            repository = new BookReportRepository();
            LoadGrid();
        }
        private void LoadGrid()
        {
            try
            {
                dataGridView1.DataSource = repository.GetBookLoanStats();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading book report " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
