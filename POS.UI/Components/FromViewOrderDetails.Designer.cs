namespace POSDesignDemo.Components
{
    partial class formViewOrderDetails
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
            btnClose = new Button();
            mainProductPanel = new FlowLayoutPanel();
            panelProduct = new Panel();
            txtQty = new Label();
            txtTotal = new Label();
            txtPrice = new Label();
            txtName = new Label();
            txtBarCode = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtOrderDate = new Label();
            panel3 = new Panel();
            mainProductPanel.SuspendLayout();
            panelProduct.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(716, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 39);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.UseWaitCursor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // mainProductPanel
            // 
            mainProductPanel.AutoScroll = true;
            mainProductPanel.BackColor = Color.White;
            mainProductPanel.Controls.Add(panelProduct);
            mainProductPanel.Location = new Point(1, 48);
            mainProductPanel.Name = "mainProductPanel";
            mainProductPanel.Padding = new Padding(20, 10, 0, 0);
            mainProductPanel.Size = new Size(856, 400);
            mainProductPanel.TabIndex = 8;
            mainProductPanel.UseWaitCursor = true;
            // 
            // panelProduct
            // 
            panelProduct.BackColor = Color.White;
            panelProduct.Controls.Add(txtQty);
            panelProduct.Controls.Add(txtTotal);
            panelProduct.Controls.Add(txtPrice);
            panelProduct.Controls.Add(txtName);
            panelProduct.Controls.Add(txtBarCode);
            panelProduct.Location = new Point(23, 13);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(806, 49);
            panelProduct.TabIndex = 1;
            panelProduct.UseWaitCursor = true;
            // 
            // txtQty
            // 
            txtQty.AutoSize = true;
            txtQty.BackColor = Color.Transparent;
            txtQty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQty.ForeColor = SystemColors.ActiveCaptionText;
            txtQty.Location = new Point(596, 17);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(75, 15);
            txtQty.TabIndex = 6;
            txtQty.Text = "Order Details";
            txtQty.UseWaitCursor = true;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.BackColor = Color.Transparent;
            txtTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = SystemColors.ActiveCaptionText;
            txtTotal.Location = new Point(705, 17);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(75, 15);
            txtTotal.TabIndex = 5;
            txtTotal.Text = "Order Details";
            txtTotal.UseWaitCursor = true;
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.BackColor = Color.Transparent;
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.ForeColor = SystemColors.ActiveCaptionText;
            txtPrice.Location = new Point(467, 17);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(75, 17);
            txtPrice.TabIndex = 4;
            txtPrice.Text = "Order Details";
            txtPrice.UseWaitCursor = true;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.ActiveCaptionText;
            txtName.Location = new Point(205, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(75, 15);
            txtName.TabIndex = 3;
            txtName.Text = "Order Details";
            txtName.UseWaitCursor = true;
            // 
            // txtBarCode
            // 
            txtBarCode.AutoSize = true;
            txtBarCode.BackColor = Color.Transparent;
            txtBarCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarCode.ForeColor = SystemColors.ActiveCaptionText;
            txtBarCode.Location = new Point(28, 17);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(75, 15);
            txtBarCode.TabIndex = 0;
            txtBarCode.Text = "Order Details";
            txtBarCode.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(56, 8);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 0;
            label1.Text = "BarCode";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtOrderDate);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 37);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(733, 8);
            label6.Name = "label6";
            label6.Size = new Size(78, 17);
            label6.TabIndex = 6;
            label6.Text = "Tootal Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(624, 8);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 5;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(495, 9);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(233, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // txtOrderDate
            // 
            txtOrderDate.AutoSize = true;
            txtOrderDate.BackColor = Color.Transparent;
            txtOrderDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtOrderDate.ForeColor = SystemColors.ControlDarkDark;
            txtOrderDate.Location = new Point(121, 17);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(0, 17);
            txtOrderDate.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnClose);
            panel3.Location = new Point(-5, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 43);
            panel3.TabIndex = 7;
            panel3.UseWaitCursor = true;
            // 
            // formViewOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 490);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(mainProductPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formViewOrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FromViewOrderDetails";
            mainProductPanel.ResumeLayout(false);
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private FlowLayoutPanel mainProductPanel;
        private Panel panelProduct;
        private Label label1;
        private Panel panel1;
        private Label txtOrderDate;
        //private Panel txtImage;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label txtBarCode;
        private Label txtQty;
        private Label txtTotal;
        private Label txtPrice;
        private Label txtName;
        private Panel panel3;
    }
}