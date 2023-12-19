using POSDesignDemo.Constant;
using POSDesignDemo.CustomStyle;
using POSDesignDemo.Models.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDesignDemo
{
    public partial class TouchScrollVerticalForm : Form
    {
        private string ProductImage = "https://imgs.search.brave.com/hWo1llTbvUU5z9-o_yvjjtFbuSGUMv839pyif676lFM/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9jbGlw/YXJ0LWxpYnJhcnku/Y29tL25ld19nYWxs/ZXJ5LzEwNC0xMDQ5/ODIwX3BpY3R1cmUt/Y29jYS1jb2xhLnBu/Zw";
        public TouchScrollVerticalForm()
        {
            InitializeComponent();
            new CustomTouchScroll(flowLayoutPanel1, ConstantScrollDirection.Vertical);
            InitProductCart();
        }
        private void InitProductCart()
        {
            var products = new List<ProductResponse>()
            {
                new ProductResponse(){Product_Name="Product-1",Image=ProductImage},
                new ProductResponse(){Product_Name="Product-2",Image=ProductImage},
                new ProductResponse(){Product_Name="Product-3",Image=ProductImage},
                new ProductResponse(){Product_Name="Product-4",Image=ProductImage},
                new ProductResponse(){Product_Name="Product-5",Image=ProductImage},
                new ProductResponse(){Product_Name="Product-6",Image=ProductImage},
                new ProductResponse(){Product_Name="Product-7",Image=ProductImage},
                new ProductResponse(){Product_Name="Product-8",Image=ProductImage},
            };
            foreach (var item in products)
            {
                AddProductToCartPanel(item);
            }
        }
        private async void AddProductToCartPanel(ProductResponse product)
        {
            FlowLayoutPanel panelProductCart = new FlowLayoutPanel();
            panelProductCart.Size = new Size(358, 60);
            panelProductCart.Padding = new Padding(2,5,2,5);
            panelProductCart.BorderStyle = BorderStyle.None;
            // Panel for product image
            Panel panelProCartImage = CreateSubPanel(new Size(52, 52));
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(50, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Assume that product.Image contains the image data
            if (!string.IsNullOrEmpty(product.Image))
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(product.Image);
                    var stream = new MemoryStream(imageBytes);
                    pictureBox.Image = Image.FromStream(stream);
                }
            }
            else
            {
                pictureBox.Image = null;
            }

            panelProCartImage.Controls.Add(pictureBox);

            // Panel for product name
            Panel panelProName = CreateSubPanel(new Size(120, 52));
            Label nameLabel = new Label();
            nameLabel.Text = product.Product_Name;
            //nameLabel.Dock = DockStyle.Fill;
            panelProName.Controls.Add(nameLabel);

            // Panel for product price
            Panel panelProPrice = CreateSubPanel(new Size(45, 52));
            Label priceLabel = new Label();
            priceLabel.Text = product.Price.ToString();
            priceLabel.Dock = DockStyle.Fill;
            panelProPrice.Controls.Add(priceLabel);

            // Panel for product quantity
            Panel panelProQty = CreateSubPanel(new Size(20, 52));
            Label qtyLabel = new Label();
            qtyLabel.Text = "12"; // Initial quantity, you can modify this based on your logic
            //qtyLabel.Dock = DockStyle.Fill;
            panelProQty.Controls.Add(qtyLabel);

            // Panel for product total
            Panel panelProTotal = CreateSubPanel(new Size(50, 52));
            Label totalLabel = new Label();
            totalLabel.Text = (product.Price * 1).ToString(); // Initial total, you can modify this based on your logic
            panelProTotal.Controls.Add(totalLabel);
            // Panel for subtract button
            Button btnSubtract = new Button();
            btnSubtract.FlatStyle = FlatStyle.Standard;
            btnSubtract.FlatAppearance.BorderColor = Color.LightGray;
            btnSubtract.Text = "-";
            Panel panelProBtnSubSt = CreateSubPanel(new Size(30, 40));
            panelProBtnSubSt.Padding = new Padding(0, 12, 0, 0);
            panelProBtnSubSt.Controls.Add(btnSubtract);

            // Add sub-panels to the main panel for the product in the cart
            panelProductCart.Controls.Add(panelProCartImage);
            panelProductCart.Controls.Add(panelProName);
            panelProductCart.Controls.Add(panelProPrice);
            panelProductCart.Controls.Add(panelProQty);
            panelProductCart.Controls.Add(panelProTotal);
            panelProductCart.Controls.Add(panelProBtnSubSt);

            // Set dynamic X positions
            int currentX = 0;
            foreach (Control subPanel in panelProductCart.Controls)
            {
                subPanel.Location = new Point(currentX, 0);
                currentX += subPanel.Width;
                foreach (Control contentControl in subPanel.Controls)
                {
                    if (contentControl is Label)
                    {
                        ((Label)contentControl).Dock = DockStyle.Fill;
                        ((Label)contentControl).TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else if (contentControl is Button)
                    {
                        ((Button)contentControl).Dock = DockStyle.Fill;
                        ((Button)contentControl).TextAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
            // Add the product panel to the main cart panel
            int topPosition = panelMainCart.Controls.Count * panelProductCart.Height;
            panelProductCart.Location = new Point(0, topPosition);

            panelMainCart.Controls.Add(panelProductCart);
        }

        private Panel CreateSubPanel(Size size)
        {
            Panel panel = new Panel();
            panel.Size = size;
            return panel;
        }


    }
}
