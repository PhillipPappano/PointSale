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
    public partial class DatabaseDeleteForm : Form
    {
        public DatabaseDeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //need to update to standardize with other similar code
            //deletes the item based on the UPC submitted
            SaleItem a = new SaleItem();
            a.load(UpcTextBox.Text);
            a.DELETE();
        }
    }
}
