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
    public partial class DeleteFulfillmentForm : Form
    {
        public DeleteFulfillmentForm()
        {
            InitializeComponent();
        }

        private void DeleteFulfillment_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ItemFulfillment itemFulfillment = new ItemFulfillment();
            itemFulfillment.itemFulfillmentSearch(textBoxOrderNumber.Text);
            string status = itemFulfillment.deleteFulfillment();
            MessageBox.Show(status);
        }
    }
}
