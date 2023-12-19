namespace POSDesignDemo.View
{
    partial class SaleDetailView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CenterPanel = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            dataGridViewOrder = new DataGridView();
            label1 = new Label();
            CenterPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // CenterPanel
            // 
            CenterPanel.AutoScroll = true;
            CenterPanel.BackColor = Color.White;
            CenterPanel.Controls.Add(panel1);
            CenterPanel.Controls.Add(dataGridViewOrder);
            CenterPanel.Controls.Add(label1);
            CenterPanel.Location = new Point(2, 0);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(1100, 540);
            CenterPanel.TabIndex = 1;
            CenterPanel.UseWaitCursor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(50, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 30);
            panel1.TabIndex = 9;
            panel1.UseWaitCursor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(768, 7);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 7;
            label6.Text = "Received";
            label6.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 7);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Order Date";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 7);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Cashier";
            label3.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(649, 7);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 4;
            label8.Text = "Total";
            label8.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 7);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 2;
            label5.Text = "Discount Price";
            label5.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 7);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Order ID";
            label2.UseWaitCursor = true;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AllowUserToResizeColumns = false;
            dataGridViewOrder.AllowUserToResizeRows = false;
            dataGridViewOrder.BackgroundColor = Color.White;
            dataGridViewOrder.BorderStyle = BorderStyle.None;
            dataGridViewOrder.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOrder.ColumnHeadersHeight = 30;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewOrder.ColumnHeadersVisible = false;
            dataGridViewOrder.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrder.Location = new Point(50, 95);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOrder.RowHeadersVisible = false;
            dataGridViewOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewOrder.RowTemplate.Height = 25;
            dataGridViewOrder.ScrollBars = ScrollBars.Vertical;
            dataGridViewOrder.Size = new Size(1000, 433);
            dataGridViewOrder.TabIndex = 8;
            dataGridViewOrder.UseWaitCursor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 0;
            label1.Text = "Sale Order Details";
            label1.UseWaitCursor = true;
            // 
            // SaleDetailView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 540);
            Controls.Add(CenterPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SaleDetailView";
            Text = "SaleDetailView";
            CenterPanel.ResumeLayout(false);
            CenterPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CenterPanel;
        private Button btnCreatePro;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label5;
        private Label label2;
        private DataGridView dataGridViewOrder;
        private Label label6;
    }
}