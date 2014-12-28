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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFulfillOrders_Click(object sender, EventArgs e)
        {
            ItemFulfillmentForm form = new ItemFulfillmentForm();
            form.Show();
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinManagementForm form = new BinManagementForm();
            form.Show();
        }
    }
}
