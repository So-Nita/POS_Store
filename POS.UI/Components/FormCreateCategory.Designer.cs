namespace POSDesignDemo.Components
{
    partial class FormCreateCategory
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
            panel6 = new Panel();
            label10 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            txtDescription = new TextBox();
            label8 = new Label();
            txtName = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(label10);
            panel6.Location = new Point(0, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(359, 78);
            panel6.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(107, 29);
            label10.Name = "label10";
            label10.Size = new Size(123, 21);
            label10.TabIndex = 0;
            label10.Text = "Create Product";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtDescription);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(btnSave);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 454);
            panel5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 195);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "Category";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(42, 213);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(279, 94);
            txtDescription.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 110);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 10;
            label8.Text = "Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(42, 128);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 32);
            txtName.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkGray;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(196, 352);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 39);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.UseWaitCursor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(56, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.UseWaitCursor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // FormCreateCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 458);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreateCategory";
            Text = "FormCreateCategory";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Label label10;
        private Panel panel5;
        private Label label7;
        private TextBox txtDescription;
        private Label label8;
        private TextBox txtName;
        private Button btnClose;
        private Button btnSave;
    }
}