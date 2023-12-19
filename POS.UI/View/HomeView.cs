using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSDesignDemo.Components;
using POSDesignDemo.Constant;
using POSDesignDemo.Controllers;
using POSDesignDemo.CustomStyle;
using POSDesignDemo.Models.Request.Order;
using POSDesignDemo.Models.Response;
using POSDesignDemo.Test;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace POSDesignDemo.View
{
    public partial class HomeView : Form
    {
        private readonly ProductController _service;
        private List<ProductResponse> Products = new();
        private List<ProductResponse> Carts = new();
        private List<Category> Categories = new();

        private string DefaultImage = "http://172.26.16.113:8082/media/file/crm/uploadfile/1700034534097486b889fca2539b3b3e2146deefef0.webp";
        public HomeView()
        {
            _service = new ProductController();
            InitializeComponent();

            if (panelMenuCategory != null)
            {
                touchScroll = new CustomTouchScroll(panelMenuCategory, ConstantScrollDirection.Horizontal);
                touchScrollProduct = new CustomTouchScroll(productPanel, ConstantScrollDirection.Vertical);
                touchScrollProductCart = new CustomTouchScroll(productPanel, ConstantScrollDirection.Vertical);
            }
            InitializeFlowLayoutPanel();
        }
        private void InitializeFlowLayoutPanel()
        {
            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanelProducts);
            InitProductsFromApiAsync();
            InitBtnAllCategory();
            InitBtnCategory();
            InitButtonColumn();
        }

        private async void InitBtnCategory()
        {
            try
            {
                var categories = await _service.GetCategoriesAsync();
                if (categories.Count > 0)
                {
                    for (int i = 0; i < categories.Count; i++)
                    {
                        CreateButtonCategory(categories[i]);
                    }
                }
            }
            catch { throw new Exception(); }
        }

        private async void InitProductsFromApiAsync()
        {
            var Test = new List<string>();
            try
            {
                Products = await _service.GetAllProductsAsync();
                foreach (var product in Products)
                {
                    Test.Add(product.Id.ToString() + product.Product_Name);
                    CreateProductPanel(product);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Product Id = [" + Test + "]" + "Message= " + ex.Message);
            }
        }
        private void InitButtonColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("Image", 50),
                Tuple.Create("Name", 90),
                Tuple.Create("Price", 35),
                Tuple.Create("Qty", 34),
                Tuple.Create("Total", 35),
                Tuple.Create("", 33)
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewProduct, columns!, BtnSubstract_Click, 50);
        }

        private void InitBtnAllCategory()
        {
            Button btnAllCategory = new Button();
            btnAllCategory.ForeColor = Color.DarkGray;
            btnAllCategory.Text = "All Category";
            btnAllCategory.FlatAppearance.BorderColor = Color.White;
            btnAllCategory.FlatAppearance.CheckedBackColor = Color.AliceBlue;
            btnAllCategory.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAllCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllCategory.FlatStyle = FlatStyle.Flat;
            btnAllCategory.FlatAppearance.BorderSize = 0;
            btnAllCategory.Cursor = Cursors.Hand;
            btnAllCategory.Location = new Point(YOffSet, 7);
            btnAllCategory.Size = new Size(115, 40);
            btnAllCategory.BackColor = Color.White;
            btnAllCategory.Click += BtnAllCategory_Click!;

            panelMenuCategory.Controls.Add(btnAllCategory);
            // Active Button AllCategory
            lastClickedButton = btnAllCategory;
            YOffSet += 120;
        }
        // Create Button Category
        private void CreateButtonCategory(Category category)
        {
            try
            {
                var btnCategory = new Button();
                btnCategory.ForeColor = Color.DarkGray;
                btnCategory.Text = category.Name;
                btnCategory.FlatAppearance.MouseOverBackColor = Color.LightGray;
                btnCategory.FlatStyle = FlatStyle.Flat;
                btnCategory.FlatAppearance.BorderSize = 0;

                btnCategory.Cursor = Cursors.Hand;
                //btnCategory.Location = new Point(YOffSet, 0);
                btnCategory.Location = new Point(YOffSet, 7);
                btnCategory.Size = new Size(120, 40);
                //
                btnCategory.BackColor = Color.White;
                //btnCategory.Click += GetProductByCategory;
                btnCategory.Click += (sender, e) => GetProductByCategory(category);
                panelMenuCategory.Controls.Add(btnCategory);
                YOffSet += 120;

                // Assign scrolling events to the dynamically created button
                touchScroll.AssignScrollEvent(btnCategory);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        private Button lastClickedButton;

        private void CategoryActiveButton(Button button, Color backgroundColor, Color textColor)
        {
            //button.Padding = new Padding(0, 5, 0, 0);
            button.BackColor = backgroundColor;
            button.ForeColor = textColor;
        }
        private async void GetProductByCategory(/*object? sender, EventArgs e,*/Category category)
        {
            try
            {
                /*productPanel.Controls.Clear();
                if (lastClickedButton != null)
                {
                    CategoryActiveButton(lastClickedButton, Color.White, Color.DarkGray);
                }
                if (sender is Button btnCategory)
                {
                    CategoryActiveButton(btnCategory, Color.Gray, Color.White);
                    lastClickedButton = btnCategory;

                    var categoryId = await _service.GetCategoryByName(btnCategory.Text);
                    if (categoryId != null)
                    {
                        Products = await _service.GetProductByCategory(categoryId.Id);
                    }
                }
                foreach (var item in Products)
                {
                    CreateProductPanel(item);
                }*/

                productPanel.Controls.Clear();
                if (lastClickedButton != null)
                {
                    CategoryActiveButton(lastClickedButton, Color.White, Color.DarkGray);
                }
                if (category.Id.ToString()!=null)
                {
                    Products = await _service.GetProductByCategory(category.Id);
                }
                foreach (var item in Products)
                {
                    CreateProductPanel(item);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        // Button All Category
        private void BtnAllCategory_Click(object sender, EventArgs e)
        {
            productPanel.Controls.Clear();
            if (lastClickedButton != null)
            {
                CategoryActiveButton(lastClickedButton, Color.White, Color.DarkGray);
            }
            InitProductsFromApiAsync();
        }
        // Button Action to Substract Qty
        private void BtnSubstract_Click(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProduct.Columns[""].Index && e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                if (index < Carts.Count)
                {
                    SubstractItem(index);
                }
                UpdateTotalPrice();
            }
        }
        // Substract Method 
        private void SubstractItem(int index)
        {
            if (Carts[index].Qty == 1)
            {
                Carts.Remove(Carts[index]);
                dataGridViewProduct.Rows.RemoveAt(index);
            }
            else
            {
                Carts[index].Qty -= 1;
                dataGridViewProduct.Rows[index].Cells[3].Value = Carts[index].Qty;
                double totalProductPrice = (double)(Carts[index].Price * Carts[index].Qty)!;
                dataGridViewProduct.Rows[index].Cells[4].Value = totalProductPrice;
            }
        }
        // Sum Price Method
        private void UpdateTotalPrice()
        {
            double totalPrice = 0.00;
            foreach (var product in Carts)
            {
                totalPrice += (double)(product.Price * product.Qty)!;
            }
            textTotalPrice.Text = "$ " + totalPrice.ToString("0.00");
        }

        // Create Panel for each product
        private async void CreateProductPanel(ProductResponse product)
        {
            try
            {
                Panel btnProduct = new Panel();
                //btnProduct.Size = new Size(190, 235);
                btnProduct.Size = new Size(190, 200);

                Panel imagePanel = new Panel();
                imagePanel.Size = new Size(200, 200);
                imagePanel.Location = new Point(0, 0);
                imagePanel.Dock = DockStyle.Top;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(200, 155);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                Label nameLabel = new Label();
                nameLabel.Text = "Name: " + product.Product_Name;
                nameLabel.BackColor = Color.White;
                nameLabel.Dock = DockStyle.Bottom;

                Label priceLabel = new Label();
                priceLabel.Text = "Price: " + product.Price;
                priceLabel.BackColor = Color.White;
                priceLabel.Dock = DockStyle.Bottom;

                btnProduct.Controls.Add(imagePanel);

                /*using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes;
                    try
                    {
                        imageBytes = await client.GetByteArrayAsync(product.GetImageUrl);
                    }
                    catch
                    {
                        imageBytes = await client.GetByteArrayAsync(DefaultImage);
                    }
                    var stream = new MemoryStream(imageBytes);
                    System.Drawing.Image image = Image.FromStream(stream);
                    pictureBox.Image = image;
                    imagePanel.Controls.Add(pictureBox);
                }*/
                var Image = await ItemComponent.GetImageFromUrl((product.GetImageUrl));
                pictureBox.Image = Image;
                imagePanel.Controls.Add(pictureBox);

                int topPosition = flowLayoutPanelProducts.Controls.Count * 260;
                btnProduct.Location = new Point(0, topPosition);
                // Add to New Row
                imagePanel.Tag = product;
                //pictureBox.Click += (sender, e) => CreateNewRow_Click(sender, e, product);
                pictureBox.Click += (sender, e) => AddProductCartToRow(product);
                //imagePanel.Click += CreateNewRowClick;
                imagePanel.Controls.Add(nameLabel);
                imagePanel.Controls.Add(priceLabel);
                btnProduct.Controls.Add(imagePanel);
                btnProduct.BackgroundImageLayout = ImageLayout.Center;
                flowLayoutPanelProducts.Controls.Add(btnProduct);
                productPanel.Controls.Add(btnProduct);
                //For Content Touc Scroll
                touchScrollProduct.AssignScrollEvent(btnProduct);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message+"\n"+ex.StackTrace);
            }

        }
       
        private async void AddProductCartToRow(ProductResponse product)
        {
            var checkProExist = Carts.FirstOrDefault(p => p.Id == product.Id);

            if (checkProExist == null)
            {
                Carts.Insert(0, product);
                product.Qty = 1;
                dataGridViewProduct.Rows.Clear();

                foreach (var item in Carts)
                {
                    double totalProductPrice = (double)(item.Price * item.Qty)!;
                    var image = await ItemComponent.GetImageFromUrl(item.GetImageUrl);
                    var index = dataGridViewProduct.Rows.Add(image, item.Product_Name, item.Price, item.Qty, totalProductPrice);

                    DataGridViewButtonCell buttonSubtract = ItemComponent.CreateButtonSubstract("-");
                    buttonSubtract.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewProduct.Rows[index].Cells[5] = buttonSubtract;
                }
            }
            else
            {
                checkProExist.Qty++;
                int rowIndex = dataGridViewProduct.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[1].Value.ToString() == checkProExist.Product_Name)
                    .Select(r => r.Index)
                    .FirstOrDefault();

                dataGridViewProduct.Rows[rowIndex].Cells[3].Value = checkProExist.Qty;

                double totalProductPrice = (double)(checkProExist.Price * checkProExist.Qty)!;
                dataGridViewProduct.Rows[rowIndex].Cells[4].Value = totalProductPrice;
            }
            //touchScrollProductCart.AssignScrollEvent(dataGridViewProduct);
            UpdateTotalPrice();
        }
        // Button To Clear All 
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            Carts.Clear();
            dataGridViewProduct.Rows.Clear();
            UpdateTotalPrice();
        }
        // Button Click Pay
        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                var totalAmount = 0.0;
                var products = new List<OrderProductCreateReq>();
                foreach (var item in Carts)
                {
                    totalAmount += (double)(item.Qty * item.Price)!;
                    var product = new OrderProductCreateReq()
                    {
                        productId = item.Id.ToString(),
                        productName = item.Product_Name!,
                        price = item.Price.ToString()!,
                        productImage = item.Image ?? DefaultImage,
                        qty = item.Qty.ToString(),
                        unitPrice = item.Price.ToString()!,
                        discount = "0",
                        productTax = "0",
                        variantId = "376",
                        subTotal = totalAmount.ToString(),
                    };
                    products.Add(product);
                }
                if (products.Count <= 0)
                {
                    CustomMessageBox.ShowMessageBox("Plase select the product!", Color.Red, 3);
                }
                else
                {
                    var data = new OrderCreateReq()
                    {
                        shopId = "1",
                        saleType = "walk-in",
                        grandTotal = totalAmount.ToString(),
                        products = products
                    };

                    var result = await _service.CreatePurchaseOrderAsync(data);
                    if (result != true)
                    {
                        CustomMessageBox.ShowMessageBox("Payment failed. Please try again!", Color.Red, 3);
                    }
                    else
                    {
                        Carts.Clear();
                        UpdateTotalPrice();
                        dataGridViewProduct.Rows.Clear();
                        CustomMessageBox.ShowMessageBox("Payment successful!", Color.Green, 4);
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }
        // Create Panel For Cart 
        private void CheckExistOrNewProduct(ProductResponse product)
        {
            var productExist = Carts.FirstOrDefault(e => e.Id == product.Id);

            if (productExist == null)
            {
                DefaultQty = 1;
                CreatePanelProductAddToCart(product);
            }
            else
            {
                var productsPanel = panelMainCart.Controls.OfType<FlowLayoutPanel>()
                                .FirstOrDefault(panel => panel.Tag is ProductResponse && ((ProductResponse)panel.Tag).Id == productExist!.Id);
                DefaultQty += 1;
                productExist!.Qty = DefaultQty;
                BtnSubstractProduct_Click(productExist);
                CreatePanelProductAddToCart(productExist);
            }
            UpdateTotalPrice();
        }

        private int DefaultQty = 1;
        private async void CreatePanelProductAddToCart(ProductResponse product)
        {
            FlowLayoutPanel panelProductCart = new FlowLayoutPanel();
            panelProductCart.Size = new Size(345, 60);
            panelProductCart.Padding = new Padding(2, 5, 2, 5);
            panelProductCart.BorderStyle = BorderStyle.None;
            // Panel for product image
            Panel panelProCartImage = CreateSubPanel(new Size(50, 52));
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(50, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Assume that product.Image contains the image data
            if (!string.IsNullOrEmpty(product.Image))
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(product.GetImageUrl);
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
            panelProName.Controls.Add(nameLabel);

            // Panel for product price
            Panel panelProPrice = CreateSubPanel(new Size(40, 52));
            Label priceLabel = new Label();
            priceLabel.Text = product.Price.ToString();
            priceLabel.Dock = DockStyle.Fill;
            panelProPrice.Controls.Add(priceLabel);

            // Panel for product quantity
            Panel panelProQty = CreateSubPanel(new Size(20, 52));
            Label qtyLabel = new Label();
            qtyLabel.Name = "lblQty";
            qtyLabel.Text = DefaultQty.ToString();
            panelProQty.Controls.Add(qtyLabel);
            product.Qty = DefaultQty;

            // Panel for product total
            Panel panelProTotal = CreateSubPanel(new Size(45, 52));
            Label totalLabel = new Label();
            totalLabel.Text = (product.Price * 1).ToString();
            totalLabel.Name = "lblTotalPrice";
            panelProTotal.Controls.Add(totalLabel);
            // Panel for subtract button
            Button btnSubtract = new Button();
            btnSubtract.FlatStyle = FlatStyle.Standard;
            btnSubtract.FlatAppearance.BorderColor = Color.LightGray;
            btnSubtract.Text = "-";
            btnSubtract.Click += (sender, e) => BtnSubstractProduct_Click(product);
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
            panelProductCart.Tag = product;
            // Add the product panel to the main cart panel
            int topPosition = panelMainCart.Controls.Count * panelProductCart.Height;
            //int topPosition = Carts.Count * panelProductCart.Height;
            panelProductCart.Location = new Point(0, topPosition);
            panelMainCart.Controls.Add(panelProductCart);
            //touchScrollProductCart.AssignScrollEvent(panelProductCart);
            Carts.Add(product);
        }

        private void BtnSubstractProduct_Click(ProductResponse product)
        {
            var productPanel = panelMainCart.Controls.OfType<FlowLayoutPanel>()
                               .FirstOrDefault(panel => panel.Tag is ProductResponse && ((ProductResponse)panel.Tag).Id == product.Id);
            if (productPanel != null)
            {
                panelMainCart.Controls.Remove(productPanel);
            }
            var Test = Carts.FirstOrDefault(e => e.Id == product.Id)!;
            Carts.Remove(Test);
            UpdateTotalPrice();
        }

        private Panel CreateSubPanel(Size size)
        {
            Panel panel = new Panel();
            panel.Size = size;
            return panel;
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panelMainCart_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panelMenuCategory_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textTotalPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextPrice_Click(object sender, EventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnAllCatgory_Click(object sender, EventArgs e)
        {
        }

        private void panelCategory_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtCatgoryName_Click(object sender, EventArgs e)
        {
        }
    }
}
