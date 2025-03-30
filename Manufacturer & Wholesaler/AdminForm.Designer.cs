namespace Manufacturer___Wholesaler
{
    partial class AdminForm
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
            RawMaterialsBtn = new Button();
            ViewProductsBtn = new Button();
            LogOutBtn = new Button();
            panel1 = new Panel();
            BatchRecordsBtn = new Button();
            ViewUsersBtn = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RawMaterialsBtn
            // 
            RawMaterialsBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RawMaterialsBtn.Location = new Point(23, 84);
            RawMaterialsBtn.Name = "RawMaterialsBtn";
            RawMaterialsBtn.Size = new Size(133, 51);
            RawMaterialsBtn.TabIndex = 0;
            RawMaterialsBtn.Text = "Raw Materials";
            RawMaterialsBtn.UseVisualStyleBackColor = true;
            RawMaterialsBtn.Click += RawMaterialsBtn_Click;
            // 
            // ViewProductsBtn
            // 
            ViewProductsBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewProductsBtn.Location = new Point(208, 84);
            ViewProductsBtn.Name = "ViewProductsBtn";
            ViewProductsBtn.Size = new Size(133, 51);
            ViewProductsBtn.TabIndex = 1;
            ViewProductsBtn.Text = "View Products";
            ViewProductsBtn.UseVisualStyleBackColor = true;
            ViewProductsBtn.Click += ViewProductsBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutBtn.Location = new Point(102, 301);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(133, 51);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "LogOut";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BatchRecordsBtn);
            panel1.Controls.Add(ViewUsersBtn);
            panel1.Controls.Add(RawMaterialsBtn);
            panel1.Controls.Add(LogOutBtn);
            panel1.Controls.Add(ViewProductsBtn);
            panel1.Location = new Point(229, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 379);
            panel1.TabIndex = 3;
            // 
            // BatchRecordsBtn
            // 
            BatchRecordsBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BatchRecordsBtn.Location = new Point(23, 188);
            BatchRecordsBtn.Name = "BatchRecordsBtn";
            BatchRecordsBtn.Size = new Size(133, 51);
            BatchRecordsBtn.TabIndex = 4;
            BatchRecordsBtn.Text = "Batch Records";
            BatchRecordsBtn.UseVisualStyleBackColor = true;
            BatchRecordsBtn.Click += BatchRecordsBtn_Click;
            // 
            // ViewUsersBtn
            // 
            ViewUsersBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewUsersBtn.Location = new Point(208, 188);
            ViewUsersBtn.Name = "ViewUsersBtn";
            ViewUsersBtn.Size = new Size(133, 51);
            ViewUsersBtn.TabIndex = 3;
            ViewUsersBtn.Text = "View Users";
            ViewUsersBtn.UseVisualStyleBackColor = true;
            ViewUsersBtn.Click += ViewUsersBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(776, 52);
            label1.TabIndex = 4;
            label1.Text = "Admin Portal";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button RawMaterialsBtn;
        private Button ViewProductsBtn;
        private Button LogOutBtn;
        private Panel panel1;
        private Button BatchRecordsBtn;
        private Button ViewUsersBtn;
        private Label label1;
    }
}