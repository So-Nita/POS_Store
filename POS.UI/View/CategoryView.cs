using POSDesignDemo.Component;
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
using POSDesignDemo.Components;
using static System.Windows.Forms.DataFormats;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using POSDesignDemo.Models.Request;
using POSDesignDemo.Models.Response;
using POSDesignDemo.Models.Request.Product;

namespace POSDesignDemo.View
{
    public partial class CategoryView : Form
    {
        private readonly ProductController _service;
        public CategoryView()
        {
            _service = new ProductController();
            InitializeComponent();
            InitLoadData();
        }
        private void InitLoadData()
        {
            InitDataGridViewColumn();
            InitDataFromApi();
        }

        private void InitDataGridViewColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("Image", 150),
                Tuple.Create("ID", 130),
                Tuple.Create("Name", 270),
                Tuple.Create("MainCategory", 180),
                Tuple.Create("Description",93),
                Tuple.Create("", 80),
                Tuple.Create("", 80),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewCategory, columns!, CheckUpdateOrDelete, 55);
        }

        private void CheckUpdateOrDelete(object? sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            var columnId = dataGridViewCategory.Rows[rowIndex];
            var product = new ProductUpdateReq();

            if (e.ColumnIndex == dataGridViewCategory.Columns[3].Index && e.RowIndex >= 0)
            {
                product.Id = Convert.ToInt32(columnId.Cells[0].Value);
                product.Name = columnId.Cells[1].Value?.ToString()!;
                //product.MainCategory = columnId.Cells[3].Value?.ToString()!;
                formCreateProduct formCreate = new formCreateProduct(product);
                formCreate.StartPosition = FormStartPosition.CenterScreen;
                formCreate.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewCategory.Columns[6].Index && e.RowIndex >= 0)
            {
                var service = new ProductController();
                var getId = columnId.Cells[0].Value;
                var result = service.DeleteProduct(Convert.ToInt32(getId));
                MessageBox.Show(result);
            }
        }
        private async void InitDataFromApi()
        {
            try
            {
                var service = new ProductController();
                var categories = await _service.GetCategoriesAsync();
                foreach (var category in categories)
                {
                    var Image = await ItemComponent.GetImageFromUrl("https://static.vecteezy.com/system/resources/previews/000/964/198/non_2x/fast-food-meal-set-vector.jpg");
                    var index = dataGridViewCategory.Rows.Add(Image, category.Id, category.Name, "Main Category", category.Description);

                    DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                    btnUpdate.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewCategory.Rows[index].Cells[5] = btnUpdate;

                    DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                    btnDelete.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewCategory.Rows[index].Cells[6] = btnDelete;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            var formCreate = new FormCreateCategory();
            formCreate.StartPosition = FormStartPosition.CenterScreen;
            formCreate.ShowDialog();
            CenterPanel.BringToFront();
        }

    }
}
