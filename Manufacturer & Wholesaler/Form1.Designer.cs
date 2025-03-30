namespace Manufacturer___Wholesaler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            SignInLink = new LinkLabel();
            Btnlogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SignInLink);
            panel1.Controls.Add(Btnlogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(202, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 472);
            panel1.TabIndex = 0;
            // 
            // SignInLink
            // 
            SignInLink.AutoSize = true;
            SignInLink.Location = new Point(173, 333);
            SignInLink.Name = "SignInLink";
            SignInLink.Size = new Size(40, 15);
            SignInLink.TabIndex = 6;
            SignInLink.TabStop = true;
            SignInLink.Text = "SignIn";
            SignInLink.LinkClicked += SignInLink_LinkClicked;
            // 
            // Btnlogin
            // 
            Btnlogin.Location = new Point(173, 265);
            Btnlogin.Name = "Btnlogin";
            Btnlogin.Size = new Size(115, 41);
            Btnlogin.TabIndex = 5;
            Btnlogin.Text = "Login";
            Btnlogin.UseVisualStyleBackColor = true;
            Btnlogin.Click += Btnlogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(173, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(174, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(173, 138);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(174, 23);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 34);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 216);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 141);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 527);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel SignInLink;
        private Button Btnlogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
