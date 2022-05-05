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
    public partial class UpdateDatabaseForm : Form
    {
        String upc;
        public UpdateDatabaseForm()
        {
            InitializeComponent();
        }

        public void getUPC(String upc) {
            this.upc = upc;
        }
        //updates the INVENTORY table on an individual level if text boxes are filled or not
        private void button1_Click(object sender, EventArgs e)
        {
            SaleItem a = new SaleItem();
            a.load(upc);
            //item update name
            if(NameBox.Text.Length>0)
                a.updateName(NameBox.Text);
            //item update description
            if (DescriptionBox.Text.Length > 0)
                a.updateDescription(DescriptionBox.Text);
            //item update buycost
            if (BuyCostBox.Text.Length > 0)
                a.updateBuyCost(Convert.ToDouble(BuyCostBox.Text));
            //update salevalue
            if (SellValueBox.Text.Length > 0) {
                a.updateSellValue(Convert.ToDouble(SellValueBox.Text));
                //update inventory to match with old salevalue
                a.updateNumHave();
            }
                
            a.saveItem();
        }
    }
}
