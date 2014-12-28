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
    public partial class BinManagementForm : Form
    {
        public BinManagementForm()
        {
            InitializeComponent();
        }

        private void buttonCreateBins_Click(object sender, EventArgs e)
        {
            CreateNewBinsForm form = new CreateNewBinsForm();
            form.Show();
        }

        private void buttonDeleteBins_Click(object sender, EventArgs e)
        {
            DeleteBinsForm form = new DeleteBinsForm();
            form.Show();
        }

    
    }
}
