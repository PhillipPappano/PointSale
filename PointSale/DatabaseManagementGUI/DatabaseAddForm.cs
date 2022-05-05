using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PointSale
{
    public partial class DatabaseAddForm : Form
    {
        //form for adding things to the database
        public DatabaseAddForm()
        {
            InitializeComponent();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            //check for null values, returns an error
            try
            {
                SaleItem add = new SaleItem(upcBox.Text, itemNameBox.Text, itemDescriptionBox.Text, double.Parse(itemBuyCostBox.Text), double.Parse(itemSellPriceBox.Text), int.Parse(itemNumberHaveBox.Text));
                //export item to database if it does not already exist
                if (add.doesUPCExist())
                {
                    Console.WriteLine("UPC " + upcBox.Text + " already exists!");
                }
                else
                {
                    Console.WriteLine(add.getUpc());
                    add.saveItem();
                }
            }
            catch(Exception a) {
                //should contain a message box instead of console output, perhaps both?
                Console.WriteLine("Items must contain all proper values");
                a.ToString();
            }
        }
    }
}
