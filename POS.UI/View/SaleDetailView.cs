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

namespace POSDesignDemo.View
{
    public partial class SaleDetailView : Form
    {
        private readonly ProductController _service;
        public SaleDetailView()
        {
            InitializeComponent();
            _service = new ProductController();
            InitGridViewColumn();
            InitDataFromApi();
        }

        private async void InitGridViewColumn()
        {
            List<Tuple<string, int>> columns = new List<Tuple<string, int>>
            {
                Tuple.Create("Order ID", 150),
                Tuple.Create("Order Date", 150),
                Tuple.Create("Cashier", 200),
                Tuple.Create("Discount Price", 150),
                Tuple.Create("Total",130),
                Tuple.Create("Received",115),
                Tuple.Create("", 100),
            };
            ItemComponent.SetupDefaultDataGridView(dataGridViewOrder, columns!, ViewOrderDetail, 55);
        }
        private async void InitDataFromApi()
        {
            try
            {
                var orders = await _service.GetSellOrderDetails();
                foreach (var order in orders.Result.order)
                {
                    var index = dataGridViewOrder.Rows.Add("  "+order.order_id, order.order_date, order.cashier, order.discount_price, order.total, order.received);


                    DataGridViewButtonCell btnViewDetail = ItemComponent.CreateButtonSubstract("View Detail");
                    btnViewDetail.Style.Padding = new Padding(0, 12, 0, 12);
                    dataGridViewOrder.Rows[index].Cells[6] = btnViewDetail;
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        private void ViewOrderDetail(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOrder.Columns[6].Index && e.RowIndex >= 0)
            {
                var detailView = new formViewOrderDetails();
                detailView.ShowDialog();
                CenterPanel.SuspendLayout();
            }
        }
    }
}
