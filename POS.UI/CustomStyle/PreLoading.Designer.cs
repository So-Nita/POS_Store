﻿namespace POSDesignDemo.CustomStyle
{
    partial class PreLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreLoading));
            bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Active = false;
            bunifuFlatButton1.Activecolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackColor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 0;
            bunifuFlatButton1.ButtonText = "";
            bunifuFlatButton1.DisabledColor = Color.Gray;
            bunifuFlatButton1.Iconcolor = Color.Transparent;
            bunifuFlatButton1.Iconimage = (Image)resources.GetObject("bunifuFlatButton1.Iconimage");
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 0;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = true;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = true;
            bunifuFlatButton1.IconZoom = 90D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new Point(73, 54);
            bunifuFlatButton1.Margin = new Padding(4, 3, 4, 3);
            bunifuFlatButton1.Name = "bunifuFlatButton1";
            bunifuFlatButton1.Normalcolor = Color.FromArgb(46, 139, 87);
            bunifuFlatButton1.OnHovercolor = Color.FromArgb(36, 129, 77);
            bunifuFlatButton1.OnHoverTextColor = Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new Size(154, 37);
            bunifuFlatButton1.TabIndex = 0;
            bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // PreLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 203);
            Controls.Add(bunifuFlatButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PreLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreLoading";
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}