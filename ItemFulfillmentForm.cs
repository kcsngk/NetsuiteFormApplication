using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetsuiteFormApplication
{
    public partial class ItemFulfillmentForm : Form
    {
        public ItemFulfillmentForm()
        {
            InitializeComponent();
        }

        private void buttonFulfillOrders_Click(object sender, EventArgs e)
        {
            CreateFulfillmentForm form = new CreateFulfillmentForm();
            form.Show();
        }

        private void buttonDeleteOrders_Click(object sender, EventArgs e)
        {
            DeleteFulfillmentForm form = new DeleteFulfillmentForm();
            form.Show();
        }

  
    }
}
