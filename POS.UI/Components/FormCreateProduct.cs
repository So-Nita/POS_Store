using POSDesignDemo.DataModels;
using POSDesignDemo.DataModels.Request;
using POSDesignDemo.Models.Response;
using POSDesignDemo.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSDesignDemo.Models.Request.Product;

namespace POSDesignDemo.Component
{
    public partial class formCreateProduct : Form
    {
        public List<Product> Products = new List<Product>();
        private readonly ProductController _service;
        private readonly ProductUpdateReq? _product;
        public formCreateProduct(ProductUpdateReq? product = null)
        {
            InitializeComponent();
            _service = new ProductController();
            _product = product;
        }

        private void formCreateProduct_Load(object sender, EventArgs e)
        {
            if (_product != null)
            {
                txtName.Text = _product.Name;
                txtPrice.Text = _product.Price.ToString();
                txtCategory.Text = _product.Category;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
            new formCreateProduct().Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                //openFileDialog.Title = "Select an Image";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    Image selectedImage = Image.FromFile(imagePath);
                    panel1.BackgroundImage = selectedImage;
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
            // Create
            if (_product == null)
            {
                var product = new ProductCreateReq()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = txtName.Text,
                    Price = Double.Parse(txtPrice.Text),
                    CateoryId = txtCategory.Text,
                    //Image = 
                };
                var added = _service.CreateProduct(product);
                if (added == true)
                {
                    txtName.Clear(); txtPrice.Clear(); txtCategory.Clear();
                }
            } // Update 
            else
            {
                var product = new ProductUpdateReq()
                {
                    Id = _product.Id,
                    Name = _product.Name,
                    Price = _product.Price,
                    Category = _product.Category,
                    //Image = 
                };
                var update = _service.UpdateProduct(product);
                if (update == true)
                {
                    MessageBox.Show("Update Successfully.");
                }
                else
                {
                    MessageBox.Show("Fail to update.");
                }
            }

        }
    }
}
