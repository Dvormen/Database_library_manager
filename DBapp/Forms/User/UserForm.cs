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

namespace DBBooks.Forms.User
{
    public partial class UserForm : Form
    {
        private UserRepository repository;
        public UserForm()
        {
            InitializeComponent();
            repository = new UserRepository();
        }

        private void LoadGrid()
        {
            try
            {
                dataGridView1.DataSource = repository.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with loading users " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var uaForm = new UserAddForm();
            if (uaForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var uuForm = new UserUpdateForm();
            if (uuForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var udForm = new UserDeleteForm();
            if (udForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            var repo = new UserRepository();
            dataGridView1.DataSource = repo.GetAll();
        }
    }
}
