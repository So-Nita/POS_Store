using FontAwesome.Sharp;
using POSDesignDemo.Components;

namespace POSDesignDemo.View.SubMenuView
{
    partial class SupplierView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateSupplier));
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
            txtCatgoryName = new Label();
            btnAllCatgory = new Label();
            label2 = new Label();
            panelMainView = new Panel();
            btnAddNewSupplier = new IconButton();
            btnSupplierLabel = new IconButton();
            panel2 = new Panel();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dataGridViewSupplier = new DataGridView();
            panelCategory = new Panel();
            panelMainView.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).BeginInit();
            SuspendLayout();
            // 
            // txtCatgoryName
            // 
            txtCatgoryName.AutoSize = true;
            txtCatgoryName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCatgoryName.ForeColor = SystemColors.ControlDarkDark;
            txtCatgoryName.Location = new Point(32, -16);
            txtCatgoryName.Name = "txtCatgoryName";
            txtCatgoryName.Size = new Size(0, 17);
            txtCatgoryName.TabIndex = 6;
            // 
            // btnAllCatgory
            // 
            btnAllCatgory.AutoSize = true;
            btnAllCatgory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllCatgory.ForeColor = SystemColors.ControlDarkDark;
            btnAllCatgory.Location = new Point(18, -17);
            btnAllCatgory.Name = "btnAllCatgory";
            btnAllCatgory.Size = new Size(85, 17);
            btnAllCatgory.TabIndex = 7;
            btnAllCatgory.Text = "All Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(110, -25);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 9;
            label2.Text = "Reset";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMainView
            // 
            panelMainView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainView.BackColor = Color.Transparent;
            panelMainView.Controls.Add(btnAddNewSupplier);
            panelMainView.Controls.Add(btnSupplierLabel);
            panelMainView.Controls.Add(panel2);
            panelMainView.Controls.Add(dataGridViewSupplier);
            panelMainView.Location = new Point(-1, 2);
            panelMainView.Name = "panelMainView";
            panelMainView.Size = new Size(1102, 600);
            panelMainView.TabIndex = 4;
            // 
            // btnAddNewSupplier
            // 
            btnAddNewSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewSupplier.BackColor = Color.FromArgb(128, 128, 255);
            btnAddNewSupplier.FlatStyle = FlatStyle.Flat;
            btnAddNewSupplier.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewSupplier.ForeColor = Color.White;
            btnAddNewSupplier.IconChar = IconChar.Add;
            btnAddNewSupplier.IconColor = Color.White;
            btnAddNewSupplier.IconFont = IconFont.Auto;
            btnAddNewSupplier.IconSize = 19;
            btnAddNewSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewSupplier.Location = new Point(1023, 26);
            btnAddNewSupplier.Margin = new Padding(3, 10, 3, 10);
            btnAddNewSupplier.Name = "btnAddNewSupplier";
            btnAddNewSupplier.Size = new Size(66, 26);
            btnAddNewSupplier.TabIndex = 18;
            btnAddNewSupplier.Tag = "Home";
            btnAddNewSupplier.Text = "New";
            btnAddNewSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNewSupplier.UseVisualStyleBackColor = false;
            btnAddNewSupplier.Click += btnAddNewSupplier_Click;
            // 
            // btnSupplierLabel
            // 
            btnSupplierLabel.BackColor = Color.White;
            btnSupplierLabel.FlatAppearance.BorderSize = 0;
            btnSupplierLabel.FlatStyle = FlatStyle.Flat;
            btnSupplierLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupplierLabel.ForeColor = Color.Black;
            btnSupplierLabel.IconChar = IconChar.UserGroup;
            btnSupplierLabel.IconColor = Color.FromArgb(98, 102, 244);
            btnSupplierLabel.IconFont = IconFont.Auto;
            btnSupplierLabel.IconSize = 30;
            btnSupplierLabel.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplierLabel.Location = new Point(3, 0);
            btnSupplierLabel.Margin = new Padding(3, 10, 3, 10);
            btnSupplierLabel.Name = "btnSupplierLabel";
            btnSupplierLabel.Padding = new Padding(10, 0, 10, 4);
            btnSupplierLabel.Size = new Size(132, 40);
            btnSupplierLabel.TabIndex = 17;
            btnSupplierLabel.Tag = "Home";
            btnSupplierLabel.Text = "Supplier";
            btnSupplierLabel.TextAlign = ContentAlignment.MiddleLeft;
            btnSupplierLabel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSupplierLabel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 225, 255);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(23, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 31);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(479, 8);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 10;
            label6.Text = "Shop Name";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(935, 8);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 7;
            label8.Text = "Website";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(788, 8);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(1016, 8);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 9;
            label10.Text = "Actions";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(633, 8);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(81, 8);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Supplier Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(359, 8);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Supplier Code";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Supplier Id";
            // 
            // dataGridViewSupplier
            // 
            dataGridViewSupplier.AllowUserToResizeColumns = false;
            dataGridViewSupplier.AllowUserToResizeRows = false;
            dataGridViewSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSupplier.BackgroundColor = Color.White;
            dataGridViewSupplier.BorderStyle = BorderStyle.None;
            dataGridViewSupplier.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewSupplier.ColumnHeadersHeight = 30;
            dataGridViewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSupplier.ColumnHeadersVisible = false;
            dataGridViewSupplier.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewSupplier.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSupplier.Location = new Point(23, 94);
            dataGridViewSupplier.Name = "dataGridViewSupplier";
            dataGridViewSupplier.ReadOnly = true;
            dataGridViewSupplier.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSupplier.RowHeadersVisible = false;
            dataGridViewSupplier.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewSupplier.RowTemplate.Height = 25;
            dataGridViewSupplier.ScrollBars = ScrollBars.Vertical;
            dataGridViewSupplier.Size = new Size(1066, 492);
            dataGridViewSupplier.TabIndex = 1;
            // 
            // panelCategory
            // 
            panelCategory.Location = new Point(6, -28);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(200, 100);
            panelCategory.TabIndex = 5;
            // 
            // SupplierView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(txtCatgoryName);
            Controls.Add(btnAllCatgory);
            Controls.Add(label2);
            Controls.Add(panelMainView);
            Controls.Add(panelCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierView";
            Text = "SupplierView";
            panelMainView.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCatgoryName;
        private Label btnAllCatgory;
        private Label label2;
        private Panel panelMainView;
        private Panel panelCategory;
        private DataGridView dataGridViewSupplier;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSupplierLabel;
        private FontAwesome.Sharp.IconButton btnAddNewSupplier;
        private Label label1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label10;
        private Label label6;
    }
}