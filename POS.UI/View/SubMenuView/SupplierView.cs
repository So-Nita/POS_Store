using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POSDesignDemo.Components;
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

namespace POSDesignDemo.View.SubMenuView
{
    public partial class SupplierView : Form
    {
        private readonly SupplierContoller _service;
        public SupplierView()
        {
            _service = new SupplierContoller();
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            InitDataFromApi();
            InitDataGridViewColumn();
        }
        
        private void InitDataGridViewColumn()
        {
            List<Tuple<string, int>> columns = new()
            {
                Tuple.Create("", 50),
                Tuple.Create("", 60),
                Tuple.Create("ID", 60),
                Tuple.Create("Name", 220),
                Tuple.Create("Supplier Code", 110),
                Tuple.Create("ShopName", 150),
                Tuple.Create("contact", 100),
                Tuple.Create("Email", 170),
                Tuple.Create("Website", 90),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewSupplier, columns!, null!, 55);
        }

        private async void InitDataFromApi()
        {
            try
            {
                var suppliers = await _service.GetAllSupplier();

                foreach (var item in suppliers)
                {
                    // var iconDelete = await ItemComponent.GetImageFromUrl("https://p.kindpng.com/picc/s/154-1541056_edit-edit-icon-svg-hd-png-download.png");
                    var index = dataGridViewSupplier.Rows.Add(item.Id, item.SupplierName, item.VendorCode, item.ShopName, item.Contact, item.Email, item.Website);
                    DataGridViewButtonCell btnUpdate = ItemComponent.CreateButtonSubstract("Update");
                    btnUpdate.Style.Padding = new Padding(0, 13, 0, 13);
                    //dataGridViewSupplier.Rows[index].Cells[0] = btnUpdate;

                    DataGridViewButtonCell btnDelete = ItemComponent.CreateButtonSubstract("Delete");
                    btnDelete.Style.Padding = new Padding(0, 13, 0, 13);
                    //dataGridViewSupplier.Rows[index].Cells[1] = btnDelete;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddControlls(Form form)
        {
            if (this.panelMainView.Controls.Count > 0)
            {
                this.panelMainView.Controls.RemoveAt(0);
            }
            panelMainView.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelMainView.Controls.Add(form);
            form.Show();
        }
        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            AddControlls(new FormCreateSupplier());
        }
    }
}
