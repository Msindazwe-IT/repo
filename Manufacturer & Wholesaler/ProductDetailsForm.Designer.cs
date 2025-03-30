namespace Manufacturer___Wholesaler
{
    partial class ProductDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtFullDesc = new Label();
            lblShortDesc = new Label();
            lblProductName = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            GenerateFormulaBtn = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(txtFullDesc);
            panel1.Controls.Add(lblShortDesc);
            panel1.Controls.Add(lblProductName);
            panel1.Location = new Point(15, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 524);
            panel1.TabIndex = 0;
            // 
            // txtFullDesc
            // 
            txtFullDesc.AutoSize = true;
            txtFullDesc.Location = new Point(14, 303);
            txtFullDesc.Name = "txtFullDesc";
            txtFullDesc.Size = new Size(88, 15);
            txtFullDesc.TabIndex = 2;
            txtFullDesc.Text = "Full description";
            // 
            // lblShortDesc
            // 
            lblShortDesc.AutoSize = true;
            lblShortDesc.Location = new Point(14, 184);
            lblShortDesc.Name = "lblShortDesc";
            lblShortDesc.Size = new Size(98, 15);
            lblShortDesc.TabIndex = 1;
            lblShortDesc.Text = "Short Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(18, 82);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(GenerateFormulaBtn);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(368, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 520);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(473, 31);
            label1.TabIndex = 0;
            label1.Text = "Create Batch";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(40, 79);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 1;
            label2.Text = "Batch Size:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 23);
            textBox1.TabIndex = 2;
            // 
            // GenerateFormulaBtn
            // 
            GenerateFormulaBtn.Location = new Point(285, 78);
            GenerateFormulaBtn.Name = "GenerateFormulaBtn";
            GenerateFormulaBtn.Size = new Size(121, 23);
            GenerateFormulaBtn.TabIndex = 3;
            GenerateFormulaBtn.Text = "Formula";
            GenerateFormulaBtn.UseVisualStyleBackColor = true;
            GenerateFormulaBtn.Click += GenerateFormulaBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(473, 409);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 544);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductDetailsForm";
            Text = "ProductDetailsForm";
            Load += ProductDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblProductName;
        private Label txtFullDesc;
        private Label lblShortDesc;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button GenerateFormulaBtn;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}