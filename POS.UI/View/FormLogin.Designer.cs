using POSDesignDemo.Components;

namespace POSDesignDemo.View
{
    partial class FormLogin
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
        private async void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            productPanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_Eye = new Button();
            txtPassword = new TextBox();
            panelUserName = new Panel();
            txtUserName = new TextBox();
            spanUserName = new Label();
            spanPassword = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            productPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelUserName.SuspendLayout();
            SuspendLayout();
            // 
            // productPanel
            // 
            productPanel.AutoScroll = true;
            productPanel.BackColor = Color.White;
            productPanel.Controls.Add(flowLayoutPanel1);
            productPanel.Controls.Add(panel2);
            productPanel.Location = new Point(2, 2);
            productPanel.Name = "productPanel";
            productPanel.Padding = new Padding(20, 10, 0, 0);
            productPanel.Size = new Size(690, 441);
            productPanel.TabIndex = 8;
            productPanel.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            flowLayoutPanel1.Location = new Point(23, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 10, 0, 0);
            flowLayoutPanel1.Size = new Size(313, 413);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panelUserName);
            panel2.Controls.Add(spanUserName);
            panel2.Controls.Add(spanPassword);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(342, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 413);
            panel2.TabIndex = 10;
            panel2.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btn_Eye);
            panel3.Controls.Add(txtPassword);
            panel3.Location = new Point(29, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 30);
            panel3.TabIndex = 17;
            panel3.UseWaitCursor = true;
            // 
            // btn_Eye
            // 
            btn_Eye.BackColor = Color.White;
            btn_Eye.FlatAppearance.BorderSize = 0;
            btn_Eye.FlatStyle = FlatStyle.Flat;
            btn_Eye.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eye.ForeColor = Color.Gray;
            btn_Eye.Location = new Point(231, 0);
            btn_Eye.Name = "btn_Eye";
            btn_Eye.Size = new Size(38, 28);
            btn_Eye.TabIndex = 0;
            btn_Eye.UseVisualStyleBackColor = false;
            btn_Eye.UseWaitCursor = true;
            btn_Eye.Click += BtnEye_Click;
            btn_Eye.MouseLeave += BtnShowText_MouseLeave;
            btn_Eye.MouseHover += BtnHideText_MouseHover;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(3, 3);
            txtPassword.Margin = new Padding(0, 10, 0, 0);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseWaitCursor = true;
            // 
            // panelUserName
            // 
            panelUserName.BackColor = Color.White;
            panelUserName.BorderStyle = BorderStyle.FixedSingle;
            panelUserName.Controls.Add(txtUserName);
            panelUserName.Location = new Point(29, 138);
            panelUserName.Name = "panelUserName";
            panelUserName.Size = new Size(270, 30);
            panelUserName.TabIndex = 16;
            panelUserName.UseWaitCursor = true;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(3, 6);
            txtUserName.Margin = new Padding(0, 2, 0, 0);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(270, 18);
            txtUserName.TabIndex = 11;
            txtUserName.UseWaitCursor = true;
            // 
            // spanUserName
            // 
            spanUserName.AutoSize = true;
            spanUserName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            spanUserName.ForeColor = Color.Red;
            spanUserName.Location = new Point(35, 171);
            spanUserName.Name = "spanUserName";
            spanUserName.Size = new Size(0, 17);
            spanUserName.TabIndex = 14;
            spanUserName.UseWaitCursor = true;
            // 
            // spanPassword
            // 
            spanPassword.AutoSize = true;
            spanPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            spanPassword.ForeColor = Color.Red;
            spanPassword.Location = new Point(32, 275);
            spanPassword.Name = "spanPassword";
            spanPassword.Size = new Size(0, 17);
            spanPassword.TabIndex = 13;
            spanPassword.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(29, 171);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 12;
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(29, 209);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 10;
            label1.Text = "Password";
            label1.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(29, 102);
            label9.Name = "label9";
            label9.Size = new Size(73, 17);
            label9.TabIndex = 9;
            label9.Text = "User name";
            label9.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(122, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.UseWaitCursor = true;
            btnLogin.Click += BtnLogin_Click;
            btnLogin.MouseLeave += BtnLogin_MouseLeave;
            btnLogin.MouseHover += BtnLogin_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(124, 41);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 0;
            label3.Text = "LOGIN";
            label3.UseWaitCursor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 443);
            Controls.Add(productPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Padding = new Padding(10, 60, 10, 10);
            Text = "FormLogin";
            productPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelUserName.ResumeLayout(false);
            panelUserName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel productPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label3;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtUserName;
        private Label label1;
        private Label spanPassword;
        private Label label2;
        private Label spanUserName;
        private Panel panelUserName;
        private Panel panel3;
        private Button btn_Eye;
    }
}