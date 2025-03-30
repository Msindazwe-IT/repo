using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manufacturer___Wholesaler
{
    public partial class ProductDetailsForm : Form
    {
        private int productId;
        public ProductDetailsForm(int id)
        {
            InitializeComponent();
            productId = id;
            LoadProductDetails();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadProductDetails()
        {
            using (SQLiteConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM products WHERE id=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblProductName.Text = reader["productName"].ToString();
                            lblShortDesc.Text = reader["shortDescription"].ToString();
                            txtFullDesc.Text = reader["fullDescription"].ToString();
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenerateFormulaBtn_Click(object sender, EventArgs e)
        {

        }
    }

}
