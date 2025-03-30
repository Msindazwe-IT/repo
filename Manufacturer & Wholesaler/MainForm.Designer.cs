namespace Manufacturer___Wholesaler
{
    partial class MainForm
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
            flowLayoutPanelProducts = new FlowLayoutPanel();
            LogoutBtn = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.BackColor = Color.White;
            flowLayoutPanelProducts.Dock = DockStyle.Right;
            flowLayoutPanelProducts.Location = new Point(352, 0);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(508, 602);
            flowLayoutPanelProducts.TabIndex = 0;
            flowLayoutPanelProducts.Paint += flowLayoutPanelProducts_Paint;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LogoutBtn.Location = new Point(12, 259);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(105, 58);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(860, 602);
            Controls.Add(LogoutBtn);
            Controls.Add(flowLayoutPanelProducts);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelProducts;
        private Button LogoutBtn;
        private VScrollBar vScrollBar1;
    }
}