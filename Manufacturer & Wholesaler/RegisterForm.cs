using Manufacturer___Wholesaler.Model;
using Manufacturer___Wholesaler.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manufacturer___Wholesaler
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string Role = label1.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
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
                MessageBox.Show("Operator Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form = new Form1();
                form.Show();
                this.Close();
               }
            catch
                 {
                        MessageBox.Show("Username already exists!");
                 }
                
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }
    }
}
