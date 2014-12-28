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
    public partial class CreateNewBinsForm : Form
    {
        public CreateNewBinsForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            BinManagement binCreation = new BinManagement();
            InventoryBin binToAdd = new InventoryBin(textBoxLocation.Text, textBoxBinNumber.Text);
            string status = binCreation.createNewBin(binToAdd);
            MessageBox.Show(status);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult selectedFile = openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            if (selectedFile == DialogResult.OK) // Test result.
            {
                textBoxUpload.Text = fileName;
            }
        }

        private void buttonCreateBins_Click(object sender, EventArgs e)
        {
            if (textBoxUpload.Text.Contains("xls"))
            {
                BinManagement binManagement = new BinManagement();
                List<InventoryBin> binsToCreate = binManagement.GetBinsFromExcel(textBoxUpload.Text);
                foreach (var bin in binsToCreate)
                {
                    string status = binManagement.createNewBin(bin);
                    MessageBox.Show(status);
                }
            }
            else MessageBox.Show("Please select an Excel File");
        }

     

    
    }
}
