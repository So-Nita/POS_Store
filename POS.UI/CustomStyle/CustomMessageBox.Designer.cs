namespace POSDesignDemo.Test
{
    partial class CustomMessageBox
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
            
            label = new Label();
            /*panelMessage = new Panel();
            panelImage = new Panel();
            panelMessage.SuspendLayout();*/
            SuspendLayout();
            // 
            // panelMessage
            // 
            /*panelMessage.BackColor = Color.White;
            panelMessage.Controls.Add(panelImage);
            panelMessage.Controls.Add(label);
            panelMessage.Location = new Point(2, 1);
            panelMessage.Name = "panelMessage";
            panelMessage.Size = new Size(300, 142);
            panelMessage.TabIndex = 1;*/
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlDarkDark;
            label.Location = new Point(85, 76);
            label.Name = "label";
            label.Size = new Size(90, 17);
            label.TabIndex = 0;
            label.Text = "Order Details";
            // 
            // panelImage
            // 
            /*panelImage.BackColor = Color.White;
            panelImage.Location = new Point(105, 9);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(60, 60);
            panelImage.TabIndex = 2;*/
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(306, 146);
            //Controls.Add(panelMessage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            Text = "CustomMessageBox";
            /*panelMessage.ResumeLayout(false);
            panelMessage.PerformLayout();*/
            ResumeLayout(false);
        }

        #endregion

        //private Panel panelMessage;
        private Label label;
        //private Panel panelImage;
    }
}