using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.common.Utility
{
    public static class SD
    {
        #region Orders
        public const string SelectAllOrders = "SELECT o.order_id, o.created_at, CONCAT(c.first_name, ' ', c.last_name) AS customer_name, c.company_name, o.po_number, o.dr_number, o.total_price\r\nFROM orders o\r\nJOIN customers c ON o.customers_id = c.customers_id;";
        #endregion
        #region Customers
        public const string SelectAllCustomers = "SELECT customers_id, CONCAT(first_name, ' ', last_name) AS customer_name, company_name, email FROM customers;";
        #endregion
        #region Products
        public const string SelectProducts = "SELECT product_id, item_code, item_name, item_description, item_color, item_category, supplier, unit, stock, item_price" + "FROM products";
        #endregion
    }
}
