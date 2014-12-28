using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetsuiteAPI;

namespace NetsuiteFormApplication
{
    public partial class CreateFulfillmentForm : Form
    {
        public CreateFulfillmentForm()
        {
            InitializeComponent();
        }

        public void buttonFulfill_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("xls"))
            {
                ItemFulfillment itemFulfillment = new ItemFulfillment();
                string[] ordersToFulfill = itemFulfillment.GetBinsFromExcel(textBox1.Text);
                foreach(var order in ordersToFulfill)
                {
                    MessageBox.Show(order);
                    SalesOrder salesOrder = new SalesOrder();
                    salesOrder.salesOrderSearch(order);

                    ItemFulfillment newItemFulfillment = new ItemFulfillment(salesOrder);
                    string fulfillmentStatus = newItemFulfillment.createItemFulfillment();
                    MessageBox.Show(fulfillmentStatus);
                }
            }

            if (textBox1.Text!=null && !textBox1.Text.Contains("xls"))
            {
                SalesOrder salesOrder = new SalesOrder();
                salesOrder.salesOrderSearch(textBox1.Text);

                ItemFulfillment testIF = new ItemFulfillment(salesOrder);
                string fulfillmentStatus = testIF.createItemFulfillment();
                MessageBox.Show(fulfillmentStatus);

            }
           
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult selectedFile = openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            if (selectedFile == DialogResult.OK) // Test result.
            {
                textBox1.Text = fileName;
            }
            
        }
    }
}
