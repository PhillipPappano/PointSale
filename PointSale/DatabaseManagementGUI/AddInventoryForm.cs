using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PointSale
{

    public partial class AddInventoryForm : Form
    {
        //form to add new items to the inventory table
        public AddInventoryForm()
        {
            InitializeComponent();
        }

        private void UpcSearchButton_Click(object sender, EventArgs e)
        {
            //load new UPC to string and check if it already exists
            string upc = UpcSearchBox.Text;
            SaleItem item = new SaleItem(upc);

            item.load(upc);
            //if it exists let the user know how many you have
            if (item.doesUPCExist())
            {
                ItemNumHaveNowBox.Text = item.getNumHave().ToString();
            }
        }
        //accidentally added and need to remove
        private void UpcSearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        //makes enter key run the search button
        private void UpcSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UpcSearchButton.PerformClick();
        }
        //increments the number of items stores in MonthlyInventory and saves it
        private void UpcAddButton_Click(object sender, EventArgs e)
        {
            string upc = UpcAddBox.Text;
            SaleItem item = new SaleItem(upc);
            //load it, if it exists then increment an save
            item.load(upc);
            if (item.doesUPCExist()) {
                item.addNumHave(1);
                item.saveItem();
                //if the search box is empty input the UPC into it to search it better
                if (UpcSearchBox.Text.Length == 0) {
                    UpcSearchBox.Text = upc;
                }
                UpcSearchButton.PerformClick();
            }
        }
        //perform addButtonClick
        private void UpcAddBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpcAddButton.PerformClick();
                UpcSearchButton.PerformClick();
            }
        }
    }
}
