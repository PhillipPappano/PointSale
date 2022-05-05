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
    public partial class LineItemsForm : Form
    {
        public LineItemsForm()
        {
            InitializeComponent();
        }
        //accidental creation
        private void lineItems_TextChanged(object sender, EventArgs e)
        {

        }
        //changes the text of the box, formatted for a receipt
        public void lineItemTextChange(string saleItem)
        {
            //attach new line item to the text box
            string holder=saleItem;
            if (lineItems.Text.Length == 0)
            {
                lineItems.Text = holder;
            }
            else {
                lineItems.Text += Environment.NewLine + holder;
            }
        }
        //returns the text in the box
        public string getText() {
            //pull text from the text box and return it
            return lineItems.Text;
        }
    }
}
