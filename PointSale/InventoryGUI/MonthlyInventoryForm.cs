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
    public partial class MonthlyInventoryForm : Form
    {
        public MonthlyInventoryForm()
        {
            InitializeComponent();
        }

        private void UPCCheckButton_Click(object sender, EventArgs e)
        {
            //load upc into string value, and check if it is an actual value and if it exists
            string upc = UPCCheckBox.Text;
            SaleItem actual = new SaleItem(upc);
            if (UPCCheckBox.Text.Length > 0 && actual.doesUPCExist())
            {
                //load upc and check if it has been created in inventory database. If it hasnt, create it based on the actual posessed inventory
                actual.load(upc);
                InventorySalleItem compare = new InventorySalleItem(upc); ;
                if (compare.doesUPCExist()) {
                    compare.load(upc);
                }
                else
                    compare = new InventorySalleItem(upc, actual.getName(), actual.getDescription(), actual.getBuyCost(), actual.getSaleValue(), 0);
                
                //add one and save it, then update the uneditable textboxs on sreen
                compare.addNumHave(1);
                compare.saveItem();
                UPCRecordBox.Text = Convert.ToString(actual.getNumHave());
                UPCCheckedBox.Text = Convert.ToString(compare.getNumHave());

            }

            else
                Console.WriteLine("UPC not found");

        }

        private void ExcelExportButton_Click(object sender, EventArgs e)
        {
            //need to implement the enter key performing click action
            //exports all UPCs and how much the database says exists and how many were scanned for inventory
            CallItems.Exports.MonthlyInventoryExcelExport();
            CallItems.Exports.SaleExcelExport();
            CallItems.Exports.InventoryExcelExport();
            MessageBox.Show("All information exported to "+ AppContext.BaseDirectory);
        }

        private void UPCCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            //return key performs click action
            if (e.KeyCode == Keys.Enter)
                UPCCheckButton.PerformClick();
        }
    }
}
