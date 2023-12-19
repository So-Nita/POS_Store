using POSDesignDemo.Models;
using POSDesignDemo.Models.Response.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDesignDemo.Components
{
    public partial class formViewOrderDetails : Form
    {
        public formViewOrderDetails()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int yOffSet = 13;
        private void CreateProductPanel(OrderDetail order)
        {
            panelProduct.BackColor = Color.White;
            panelProduct.Controls.Add(txtQty);
            panelProduct.Controls.Add(txtTotal);
            panelProduct.Controls.Add(txtPrice);
            panelProduct.Controls.Add(txtName);
            panelProduct.Controls.Add(txtBarCode);
            panelProduct.Location = new Point(23, yOffSet);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(806, 50);
            panelProduct.TabIndex = 1;
            panelProduct.UseWaitCursor = true;
        }
    }
}
