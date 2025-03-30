using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manufacturer___Wholesaler
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void RawMaterialsBtn_Click(object sender, EventArgs e)
        {
            RawMaterialsForm raw = new RawMaterialsForm();
            raw.Show();
            this.Hide();
        }

        private void ViewProductsBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }

        private void ViewUsersBtn_Click(object sender, EventArgs e)
        {

        }

        private void BatchRecordsBtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
};
