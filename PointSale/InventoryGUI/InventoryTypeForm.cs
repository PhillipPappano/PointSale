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
    public partial class InventoryTypeForm : Form
    {
        //determines what kind of activities will be performed; monthly inventory or adding new inventory?
        public InventoryTypeForm()
        {
            InitializeComponent();
        }
        //initiates the form to add a new shipment of items who's UPCs already exist in the INVENTORY table 
        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            AddInventoryForm a = new AddInventoryForm();
            a.ShowDialog();
            a.Close();
        }
        //initiates the monthly inventory
        private void MonthlyInventoryButton_Click(object sender, EventArgs e)
        {
            MonthlyInventoryForm a = new MonthlyInventoryForm();
            a.ShowDialog();
            a.Close();
        }
    }
}
