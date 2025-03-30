using Manufacturer___Wholesaler.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manufacturer___Wholesaler.Model;

namespace Manufacturer___Wholesaler
{
    public partial class UsersForm : Form
    {
        private Database db;
        public UsersForm()
        {
            InitializeComponent();
            db = new Database();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string Role = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;

                
            } 
            if (string.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Please select a Role (Admin or Operator).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {

                Users repo = new Users();

                User person = new User()
                {
                    Username = username,
                    password = password,
                    role = Role
                };

                repo.AddUser(person);
                MessageBox.Show("User Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch
            {
                MessageBox.Show("Username already exists!");
            }

        }

        private void LoadUsers()
        {
            //dataGridView1.DataSource = db.GetDataTable("SELECT * FROM RawMaterials");

            DataTable dt = db.GetDataTable("SELECT * FROM users");

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;  // ? Display data in DataGridView
            }
            else
            {
                MessageBox.Show("No users found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
