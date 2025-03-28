﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.common.Utility
{
    public static class SD
    {
        #region Orders
        public const string SelectAllOrders = "SELECT o.order_id, o.created_at, CONCAT(c.first_name, ' ', c.last_name) AS customer_name, c.company_name, o.po_number, o.dr_number, o.total_price " +
                                              "FROM orders o " +
                                              "JOIN customers c ON o.customers_id = c.customers_id " +
                                              "WHERE o.deleted_at IS NULL;";

        public const string InsertToOrders = "INSERT INTO orders (customers_id, po_number, dr_number, order_date, total_price, created_at) " +
                    "VALUES (@customer_id, @po_number, @dr_number, @order_date, @total_price, @created_at)";
        public const string SelectOrder = "SELECT o.order_id, o.created_at, CONCAT(c.first_name, ' ', c.last_name) AS customer_name, c.company_name, o.po_number, o.dr_number, o.total_price\r\nFROM orders o\r\nJOIN customers c ON o.customers_id = c.customers_id WHERE o.order_id = @order_id";
        #endregion
        #region Order Items
        public const string InsertToOrderItems = "INSERT INTO order_items (order_id, product_id, quantity, price, created_at) " +
                        "VALUES (@order_id, @product_id, @quantity, @price, @created_at)";
        public const string SelectOrderItems = "SELECT product_id, quantity FROM order_items oi JOIN products p ON p.product_id = oi.product_id WHERE o.order_id = @order_id";
        #endregion
        #region Customers
        public const string SelectAllCustomersForOrder = "SELECT customers_id, CONCAT(first_name, ' ', last_name) AS customer_name, company_name, email FROM customers;";
        #endregion
        #region Products
        public const string SelectProductsForOrder = "SELECT product_id, item_code, item_name, item_description, item_color, item_category, supplier, unit, stock, item_price FROM products";
        public const string SelectSpecificOrderProducts = "SELECT p.item_name, p.item_code, p.item_description, p.item_color, p.item_price, oi.quantity FROM order_items oi JOIN products p ON p.product_id = oi.product_id where oi.order_id = @order_id";
        #endregion
    }
}
