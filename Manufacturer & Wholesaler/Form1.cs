using System.Data.SQLite;

namespace Manufacturer___Wholesaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database.InitializeDatabase();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SQLiteConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT role FROM users WHERE username=@username AND password=@password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);


                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show("Login Successful!");

                        if (role == "Admin")
                        {
                            // Open Admin Panel
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else
                        {
                            // Open User Dashboard
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }

        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
