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
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }
        //creates the form to add items to the database
        private void addItem_Click(object sender, EventArgs e)
        {
            DatabaseAddForm a = new DatabaseAddForm();
            a.ShowDialog();
            a.Close();
        }
        //creates the form to chacge items in the database
        private void changeItem_Click(object sender, EventArgs e)
        {
            DatabaseChangeForm a = new DatabaseChangeForm();
            a.ShowDialog();
            a.Close();
        }
        //creates form to delete items from the database
        private void deleteItem_Click(object sender, EventArgs e)
        {
            DatabaseDeleteForm a = new DatabaseDeleteForm();
            a.ShowDialog();
            a.Close();
        }
        //creates the form to begin monthly inventory
        private void inventory_Click(object sender, EventArgs e)
        {
            InventoryTypeForm a = new InventoryTypeForm();
            a.ShowDialog();
            a.Close();
        }
    }
}
