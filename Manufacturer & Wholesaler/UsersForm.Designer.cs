namespace Manufacturer___Wholesaler
{
    partial class UsersForm
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
            AddUserBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            BackBtn = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(944, 32);
            label1.TabIndex = 0;
            label1.Text = "All Users";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new Point(778, 79);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(140, 33);
            AddUserBtn.TabIndex = 1;
            AddUserBtn.Text = "ADD USER";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(778, 139);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(140, 33);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "EDIT USER";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(778, 195);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(140, 33);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "DELETE USER";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(803, 466);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(140, 33);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "BACK";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(771, 245);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 83);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 6;
            label2.Text = "Username :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 128);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 7;
            label3.Text = "Password :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 175);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Role :";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Operator" });
            comboBox1.Location = new Point(110, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(110, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 23);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(110, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 23);
            txtPassword.TabIndex = 11;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 511);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddUserBtn);
            Controls.Add(label1);
            Name = "UsersForm";
            Text = "Users";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddUserBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button BackBtn;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}