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
    //the form where items are pooled for the actual sale
    public partial class PoSForm : Form
    {
        LineItemsForm a;
        List<SaleItem> itemList;
        public PoSForm()
        {
            InitializeComponent();
        }
        //adds item information for both the user and customer
        private void addItem_Click(object sender, EventArgs e)
        {
            //if the form for holding data has not yet been instantiated, instantiate important items now
            if (a == null)
            {
                a = new LineItemsForm();
                a.Show();
                itemList = new List<SaleItem>();
                //checks item existance, and if it does exist then begin loading information into itemList and the form
                SaleItem item = new SaleItem(upcBox.Text);
                if (item.doesUPCExist())
                {
                    item.load(upcBox.Text);
                    itemList.Add(item);
                    string text = item.getName() + "......................................................................................................$" + item.getSaleValue();
                    a.lineItemTextChange(text);
                    upcBox.Text = "";
                }
                //inform user that item was not found
                else {
                    Console.WriteLine("Item "+item.getUpc()+" could not be found.");
                }
            }
            //if the form exists, contine loading into it and itemList
            else 
            {
                SaleItem item = new SaleItem(upcBox.Text);
                if (item.doesUPCExist())
                {
                    item.load(upcBox.Text);
                    itemList.Add(item);
                    string text = item.getName() + "......................................................................................................$" + item.getSaleValue();
                    a.lineItemTextChange(text);
                    upcBox.Text = "";
                }
                else
                {
                    Console.WriteLine("Item " + item.getUpc() + " could not be found.");
                }
            }
        }
        //finalizes the sale and opes the new form for the transaction, passing it all the info
        private void finalizeButton_Click(object sender, EventArgs e)
        {
            paymentSystem a = new paymentSystem();
            a.itemList(itemList);
            a.Show();
        }
    }
}
