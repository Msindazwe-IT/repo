namespace Manufacturer___Wholesaler
{
    partial class RawMaterialsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            txtName = new TextBox();
            txtSupplier = new TextBox();
            txtQuantity = new TextBox();
            txtCost = new TextBox();
            AddBtn = new Button();
            ClearBtn = new Button();
            BackBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(896, 23);
            label1.TabIndex = 0;
            label1.Text = "RAW MATERIALS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(50, 73);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.Location = new Point(50, 121);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Supplier :";
            // 
            // label4
            // 
            label4.Location = new Point(50, 173);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Quantity :";
            // 
            // label5
            // 
            label5.Location = new Point(50, 219);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Unit :";
            // 
            // label6
            // 
            label6.Location = new Point(50, 274);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "Cost :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "litres", "Kg" });
            comboBox1.Location = new Point(135, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 23);
            txtName.TabIndex = 7;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(135, 121);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(172, 23);
            txtSupplier.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(135, 173);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(172, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(135, 274);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(172, 23);
            txtCost.TabIndex = 10;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(734, 64);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(140, 38);
            AddBtn.TabIndex = 11;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(734, 121);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(140, 38);
            ClearBtn.TabIndex = 12;
            ClearBtn.Text = "CLEAR";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(734, 187);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(140, 38);
            BackBtn.TabIndex = 13;
            BackBtn.Text = "BACK";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(824, 181);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RawMaterialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 552);
            Controls.Add(dataGridView1);
            Controls.Add(BackBtn);
            Controls.Add(ClearBtn);
            Controls.Add(AddBtn);
            Controls.Add(txtCost);
            Controls.Add(txtQuantity);
            Controls.Add(txtSupplier);
            Controls.Add(txtName);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RawMaterialsForm";
            Text = "RawMaterialsForm";
            Load += RawMaterialsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox txtName;
        private TextBox txtSupplier;
        private TextBox txtQuantity;
        private TextBox txtCost;
        private Button AddBtn;
        private Button ClearBtn;
        private Button BackBtn;
        private DataGridView dataGridView1;
    }
}