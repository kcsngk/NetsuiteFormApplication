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
    public partial class AddBinsToItemsForm : Form
    {
        public AddBinsToItemsForm()
        {
            InitializeComponent();
        }

        private void buttonAddBin_Click(object sender, EventArgs e)
        {
            if (textBoxLocation.Text != null && textBoxBinNumber.Text != null && textBoxSKU.Text != null)
            {
                ItemBinUpdate itemBinUpdate = new ItemBinUpdate();
                Item itemToAdd = new Item(textBoxSKU.Text);
                InventoryBin inventoryBin = new InventoryBin(textBoxLocation.Text, textBoxBinNumber.Text, itemToAdd);
                string status = itemBinUpdate.addBin(inventoryBin);
                MessageBox.Show(status);
            }
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

        private void buttonAddBins_Click(object sender, EventArgs e)
        {
            ItemBinUpdate itemBinUpdate = new ItemBinUpdate();
            List<InventoryBin> listOfItemBins = new List<InventoryBin>();
            listOfItemBins = itemBinUpdate.GetItemBinsFromExcel(textBoxUpload.Text);
            foreach (var itemBin in listOfItemBins)
            {
                string status = itemBinUpdate.addBin(itemBin);
                MessageBox.Show(status);
            }
        }

        

       

     

     
    }
}
