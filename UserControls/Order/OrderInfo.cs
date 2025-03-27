using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_system.Repository;
using inventory_system.style;
using inventory_system.Model;

namespace inventory_system.UserControls.Order
{
    public partial class OrderInfo: UserControl
    {
        OrderRepository orderRepository;
        public OrderInfo(int id)
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
            DataTable dt = orderRepository.GetSpecificOrderItems(id);
            DataGridViewStyler.ApplyStyles(orderItemsDatagridview);
            orderItemsDatagridview.DataSource = orderRepository.GetSpecificOrderItems(id);
            Model.Order order = orderRepository.GetOrderInfo(id);

            // Use LINQ to calculate the sum of the 'quantity' column
            int totalQuantity = dt.AsEnumerable().Sum(row => row.Field<int>("quantity"));
            totalQuantityLbl.Text = totalQuantity.ToString();
            totalPriceLbl.Text = order.TotalPrice.ToString();
            puchaseOrderLbl.Text = $"Purchase Order No. {order.PurchaseOrderId.ToString()}";
            deliveryReceiptLbl.Text = $"Delivery Receipt No. {order.DeliveryReceipt.ToString()}";
        }
    }
}
