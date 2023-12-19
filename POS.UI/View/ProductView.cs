using POSDesignDemo.Component;
using POSDesignDemo.Components;
using POSDesignDemo.Models.Request;
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

namespace POSDesignDemo.View
{
    public partial class ProductView : Form
    {

        public ProductView()
        {
            InitializeComponent();
            InitLoadData();
            InitGridViewColumn();
        }

        private void btnCreatePro_Click(object sender, EventArgs e)
        {
            formCreateProduct formCreate = new formCreateProduct();
            formCreate.StartPosition = FormStartPosition.CenterScreen;
            formCreate.ShowDialog();
        }
        private void InitGridViewColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("Image", 150),
                Tuple.Create("ID", 50),
                Tuple.Create("Name", 300),
                Tuple.Create("Price", 80),
                Tuple.Create("Quantity", 80),
                Tuple.Create("Category", 170),
                Tuple.Create("", 75),
                Tuple.Create("", 75),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewProduct, columns!, ClickUpdateOrDelete, 55);
        }
        private async void InitLoadData()
        {
            try
            {
                var service = new ProductController();
                var products = await service.GetAllProductsAsync();

                foreach (var product in products)
                {
                    var Image = await ItemComponent.GetImageFromUrl(product.GetImageUrl);
                    var index = dataGridViewProduct.Rows.Add(Image, product.Id, product.Product_Name, product.Price, product.Qty, product.CategoryName);

                    DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                    btnUpdate.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewProduct.Rows[index].Cells[6] = btnUpdate;

                    DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                    btnDelete.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewProduct.Rows[index].Cells[7] = btnDelete;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClickUpdateOrDelete(object? sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columnId = dataGridViewProduct.Rows[rowIndex];
            var product = new ProductUpdateReq();

            if (e.ColumnIndex == dataGridViewProduct.Columns[6].Index && e.RowIndex >= 0)
            {
                product.Id = Convert.ToInt32(columnId.Cells[1].Value);
                product.Name = columnId.Cells[2].Value?.ToString();
                product.Category = columnId.Cells[4].Value?.ToString();

                if (double.TryParse(columnId.Cells[3].Value?.ToString(), out double price))
                {
                    product.Price = price;
                }
                formCreateProduct formCreate = new formCreateProduct(product);
                formCreate.StartPosition = FormStartPosition.CenterScreen;
                formCreate.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewProduct.Columns[7].Index && e.RowIndex >= 0)
            {
                var service = new ProductController();
                var getId = columnId.Cells[1].Value;
                var result = service.DeleteProduct(Convert.ToInt32(getId));
                MessageBox.Show(result);
            }
        }



    }
}
