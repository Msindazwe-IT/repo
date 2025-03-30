using Manufacturer___Wholesaler.Model;
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

namespace Manufacturer___Wholesaler
{
    public partial class RawMaterialsForm : Form
    {
        private Database db;
        public RawMaterialsForm()
        {
            InitializeComponent();
            db = new Database();
        }
        private void RawMaterialsForm_Load(object sender, EventArgs e)
        {
            LoadRawMaterials();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RawMaterials repo = new RawMaterials();

                RawMaterial material = new RawMaterial
                {
                    Name = txtName.Text,
                    Supplier = txtSupplier.Text,
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    Cost = Convert.ToDouble(txtCost.Text),
                    Unit = comboBox1.SelectedItem?.ToString()

                };
                if (string.IsNullOrEmpty(material.Unit))
                {
                    MessageBox.Show("Please select a unit (kg or L).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                repo.AddRawMaterial(material);
                MessageBox.Show("Raw Material Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRawMaterials(); // Refresh DataGridView

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRawMaterials()
        {
            //dataGridView1.DataSource = db.GetDataTable("SELECT * FROM RawMaterials");

            DataTable dt = db.GetDataTable("SELECT * FROM raw_materials");

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;  // ? Display data in DataGridView
            }
            else
            {
                MessageBox.Show("No raw materials found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSupplier.Clear();
            txtCost.Clear();
            txtQuantity.Clear();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
