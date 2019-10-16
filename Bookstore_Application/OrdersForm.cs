using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Application
{
    public partial class OrdersForm : Form
    {
        public string email;
        DataTable pendingdt;
        DataTable completedt;

        DBConnection dbconn = new DBConnection("localhost", "bookstore_schema", "root", "root");
        

        public OrdersForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            pendingdt = dbconn.Select("SELECT order_id AS OrderID, order_email AS Email, order_items AS Items, order_price AS Price, order_date AS `Order Date` FROM bookstore_schema.orders WHERE order_email = '" + email + "' AND received_date IS NULL;");
            pendingDataGridView.DataSource = pendingdt;

            completedt = dbconn.Select("SELECT order_id AS OrderID, order_email AS Email, order_items AS Items, order_price AS Price, received_date AS `Received Date` FROM bookstore_schema.orders WHERE order_email = '" + email + "' AND received_date IS NOT NULL;");
            completedDataGridView.DataSource = completedt;

            this.Text = email + " Book Orders";
        }

        private void okOrdersButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
