using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SQLite;

namespace Manufacturer___Wholesaler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadProducts()
        {
            using (SQLiteConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM products";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string name = reader["productName"].ToString();
                            string shortDesc = reader["shortDescription"].ToString();
                            string imagePath = reader["imagePath"].ToString();

                            // Create a panel for each product
                            Panel panel = new Panel
                            {
                                Width = 200,
                                Height = 250,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(10),
                                Tag = id // store product id in Tag property
                            };

                            // PictureBox for the product image
                            PictureBox pb = new PictureBox
                            {
                                Width = 180,
                                Height = 150,
                                SizeMode = PictureBoxSizeMode.Zoom,
                                ImageLocation = imagePath,
                                Dock = DockStyle.Top
                            };

                            // Label for the product name and short description
                            Label lbl = new Label
                            {
                                Text = $"{name}\n{shortDesc}",
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            // Add click event handlers for the panel and its controls
                            panel.Click += Product_Click;
                            pb.Click += Product_Click;
                            lbl.Click += Product_Click;

                            panel.Controls.Add(lbl);
                            panel.Controls.Add(pb);
                            flowLayoutPanelProducts.Controls.Add(panel);
                        }
                    }
                }
            }
        }

        private void Product_Click(object sender, EventArgs e)
        {
            // Determine the panel that was clicked
            Control control = sender as Control;
            Panel panel = control is Panel ? (Panel)control : control.Parent as Panel;
            if (panel != null && panel.Tag != null)
            {
                int productId = (int)panel.Tag;
                // Open the Product Details form passing the productId
                ProductDetailsForm detailsForm = new ProductDetailsForm(productId);
                detailsForm.Show();
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
