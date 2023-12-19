using System.Windows.Forms.VisualStyles;

namespace POSDesignDemo.Component
{
    partial class formCreateProduct
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnImage = new Button();
            label11 = new Label();
            label7 = new Label();
            txtCategory = new TextBox();
            label8 = new Label();
            txtPrice = new TextBox();
            label9 = new Label();
            txtName = new TextBox();
            panel6 = new Panel();
            label10 = new Label();
            btnExit = new Button();
            btnSave = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            btnClose = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 467);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 467);
            panel3.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnImage);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(txtCategory);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtPrice);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnExit);
            panel5.Controls.Add(btnSave);
            panel5.Location = new Point(-1, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 467);
            panel5.TabIndex = 13;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(42, 326);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(279, 30);
            btnImage.TabIndex = 15;
            btnImage.Text = "Choose Image ";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 304);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 14;
            label11.Text = "Image";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 233);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(42, 251);
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(279, 30);
            txtCategory.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 159);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 10;
            label8.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(42, 177);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(279, 30);
            txtPrice.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 84);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 7;
            label9.Text = "Name ";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(42, 102);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 30);
            txtName.TabIndex = 6;
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
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(203, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 39);
            btnExit.TabIndex = 4;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.UseWaitCursor = true;
            btnExit.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(60, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.UseWaitCursor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 224);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Name ";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(42, 242);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 30);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 151);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "Name ";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(42, 169);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(279, 30);
            textBox5.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 83);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Name ";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(42, 101);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(279, 30);
            textBox3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Location = new Point(0, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(359, 56);
            panel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(107, 19);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 0;
            label5.Text = "Create Product";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(203, 379);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(60, 379);
            button2.Name = "button2";
            button2.Size = new Size(96, 39);
            button2.TabIndex = 3;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 166);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Name ";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(42, 188);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 35);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(42, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 35);
            textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 56);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(107, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 0;
            label1.Text = "Create Product";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkGray;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(203, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 39);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.UseWaitCursor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // formCreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(362, 469);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCreateProduct";
            Text = "FormCreateProduct";
            Load += formCreateProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;

        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Panel panel3;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox3;
        private Panel panel4;
        private Label label5;
        private Button button1;
        private Button button2;
        //private Label txtProName;
        private TextBox textBox1;
        private Panel panel5;
        private Label label12;
        private Label label11;
        private TextBox textBox9;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox txtName;
        private Panel panel6;
        private Label label10;
        private Button btnExit;
        private Button btnSave;
        private Button btnImage;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private TextBox txtCategory;
        private TextBox txtPrice;


    }
}