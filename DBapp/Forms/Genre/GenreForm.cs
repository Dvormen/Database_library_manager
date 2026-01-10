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

namespace DBBooks.Forms.Genre
{
    public partial class GenreForm : Form
    {
        private GenreRepository genreRepository;
        public GenreForm()
        {
            InitializeComponent();
            genreRepository = new GenreRepository();
        }
        private void GenreForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                dataGridView1.DataSource = genreRepository.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with loading genres " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var gaForm = new GenreAddForm();
            if (gaForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var guForm = new GenreUpdateForm();
            if (guForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var gdForm = new GenreDeleteForm();
            if (gdForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            var repo = new GenreRepository();
            dataGridView1.DataSource = repo.GetAll();
        }
    }
}
