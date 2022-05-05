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
    //payment system to calculate how payment is done
    public partial class paymentSystem : Form
    {
        private List<SaleItem> saleList;
        private double totalCost;
        private double cashPayment; //stores how much money was paid by cash
        private double cardPayment; //stores how much money was paid by card
        private bool cardUsed;      //stores if a card was used at any time
        public paymentSystem()
        {
            InitializeComponent();
        }

        private void paymentSystem_Load(object sender, EventArgs e)
        {
            //calculates the total cost multiplied by the tax rate, then sends it to the Label
            //still need a way to pull tax rate from an external location
            totalCost = 0.0;
            cashPayment = 0.0;
            cardPayment = 0.0;
            cardUsed = false;
            for (int i=0;i<saleList.Count();i++) {
                totalCost += saleList[i].getSaleValue();
            }
            totalCost *= 1.08;
            totalCost=Math.Round(totalCost,2);
            totalLabel.Text = "Total: $"+totalCost;
            //run new method to load ccFees and tax from SaleManager()::Unneeded?
        }

        public void itemList(List<SaleItem> lst) {
            //runs before paymentSystem_Load, loads SaleItem List
            saleList = lst;
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            //takes the value proposed to be paid by card and attempts to deduct it
            //depending on the value, it will not finish the sale
            //need to create variables to deal with multiple types of payments
            //need a way to discover what cc fees are (saved in fees.dat)
            double value = Double.Parse(costOfItems.Text);
            if (value > 0)
            {
                totalCost -= value;
                if (totalCost <= 0)//calculates change and print recepit; also close screens and sellItem();
                {
                    cardUsed = true;
                    cardPayment += value;
                    sellItem();
                    for (int i = 0; i < saleList.Count(); i++)
                    {
                        saleList[i].sellItem(1);
                        saleList[i].saveItem();
                    }
                    string receipt=printRecepit();
                    Console.WriteLine(receipt);
                    this.Close();
                } 
                else {
                    cardUsed = true;
                    cardPayment += value;
                    costOfItems.Text = "";
                }
               
                totalLabel.Text = "Total: $" + totalCost;
            }
            else 
            { 
                //show error message for negative money
            }
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            //see above, but without dealing with creditcard payment scheme
            double value = Double.Parse(costOfItems.Text);
            if (value > 0)
            {
                totalCost -= value;
                
                if (totalCost <= 0)
                {

                    cashPayment += value;
                    sellItem();//commits the sale to the database
                    for (int i = 0; i < saleList.Count(); i++)
                    {
                        saleList[i].sellItem(1);//decrements the total item number
                        saleList[i].saveItem(); //saves that item
                    }
                    //collect recepit id, and add it to recepit
                    string recepit = printRecepit();
                    Console.WriteLine(recepit);
                    this.Close();
                }
                else {
                    cashPayment += value;
                    costOfItems.Text = "";
                }

                totalLabel.Text = "Total: $" + totalCost;
            }
            else
            {
                //show error message for trying to give negative money
            }
        }
        private void sellItem() {
            //commits item sales to the SALES table
            
            /*order:
             * UPC->ID // -> default ID value
             * Name->Item UPC's parced by ','
             * BuyValue -> cumulative buy value
             * SaleValue -> cumulative sale value
             * Tax -> cumulative, based on sale value
             * CardProcessingFee -> cumulative, based on credit card sale value
             * Profit -> total profits (salevalue-tax-creditCardProcessing-buyValue)
             * not yet implemented: cash sale variable
             * not yet implemented: card sale variable
             */
            string upcList="";
            double buyCostTotal=0.0;
            double sellCostTotal=0.0;
            for (int i=0;i<saleList.Count();i++) {
                upcList += saleList[i].getUpc() + ",";
                buyCostTotal += saleList[i].getBuyCost();
                sellCostTotal += saleList[i].getSaleValue();
            }
            SaleManager.sellItem(upcList, buyCostTotal, sellCostTotal, cardUsed, cashPayment, cardPayment);// add cashSale and CardSale
        }

        //prints recepit
        private string printRecepit() {
            Form f = Application.OpenForms["LineItemsForm"];
            string rtrn = (((LineItemsForm)f).getText());
            f.Close();
            //actually print recepit here, 
            return rtrn;
        }
        //cancels the active sale by force closing all related forms
        private void cancelSaleButton_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["LineItemsForm"];
            Form g = Application.OpenForms["PoSForm"];
            f.Close();
            g.Close();
            this.Close();
        }
    }
}
