namespace POSDesignDemo.View
{
    partial class OrderDetailView
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            CenterPanel = new Panel();
            dataGridViewProduct = new DataGridView();
            label1 = new Label();
            CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // CenterPanel
            // 
            CenterPanel.AutoScroll = true;
            CenterPanel.BackColor = Color.White;
            CenterPanel.Controls.Add(dataGridViewProduct);
            CenterPanel.Controls.Add(label1);
            CenterPanel.Location = new Point(2, 0);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(1100, 540);
            CenterPanel.TabIndex = 2;
            CenterPanel.UseWaitCursor = true;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.CausesValidation = false;
            dataGridViewProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProduct.ColumnHeadersHeight = 30;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Transparent;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewProduct.GridColor = SystemColors.Control;
            dataGridViewProduct.Location = new Point(55, 70);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewProduct.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewProduct.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.RowTemplate.ReadOnly = true;
            dataGridViewProduct.Size = new Size(990, 450);
            dataGridViewProduct.StandardTab = true;
            dataGridViewProduct.TabIndex = 2;
            dataGridViewProduct.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 0;
            label1.Text = "Order Product Detail";
            label1.UseWaitCursor = true;
            // 
            // OrderDetailView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 540);
            Controls.Add(CenterPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDetailView";
            Text = "OrderDetailView";
            CenterPanel.ResumeLayout(false);
            CenterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CenterPanel;
        private DataGridView dataGridViewProduct;
        private Label label1;
    }
}