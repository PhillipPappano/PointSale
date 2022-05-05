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
    public partial class DatabaseChangeForm : Form
    {
        public DatabaseChangeForm()
        {
            InitializeComponent();
        }
        //accident I need to delete
        private void DatabaseChangeForm_Load(object sender, EventArgs e)
        {

        }
        //accident I need to delete
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchUPCButton_Click(object sender, EventArgs e)
        {
            String upc = searchBoxUPC.Text;
            SaleItem item = new SaleItem(upc);
            //search database for upc, if it exists load the form for altering the INVENTORY table
            //send the form the UPC so it does not get changed

            if (item.doesUPCExist()) {
                UpdateDatabaseForm a = new UpdateDatabaseForm();
                a.Show();
                a.getUPC(upc);
                //a.Close();
            }
               
        }
    }
}
