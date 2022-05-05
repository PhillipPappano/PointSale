using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PointSale
{
    public class SaleManager
    {
        //need to update to read from file the cost of processing by Credit Card and point that to the card value 
        private static double card;
        //contains the list of all UPCs sold
        private static string UPCList;
        //contains the costs of items as held in the database
        private static double TotalBuyCost, TotalItemSellValue, TotalCashValue, TotalCardValue;

        //takes in the infrmation needed for a transaction then performs the transaction
        //more effecient to simply pass the SaleItem object???
        public static void sellItem(string upcList, double totalBuyCost, double totalItemSellValue, bool cardYN, double cashValue, double cardValue)
        {
            UPCList = upcList;
            TotalBuyCost = totalBuyCost;
            TotalItemSellValue = totalItemSellValue;
            TotalCashValue = cashValue;
            TotalCardValue = cardValue;
            //here should pull from external file based on CreditCard type
            if (cardYN)
            {
                card = .05;
            }
            else {
                card = 0;
            }
            //saves the item transaction to the database
            try
            {
                OleDbConnection myconn = new OleDbConnection();                     
                string filePath = System.AppContext.BaseDirectory;
                //for now no password for database
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source="+ filePath + "\\PoSDatabase.mdb;";
                myconn.Open();
                string my_querry = "";
                OleDbCommand cmd;
               //indented to show that this is suceptable to SQL injection, need to fix this

                    Console.WriteLine("Selling item...");
                    my_querry = "INSERT INTO Sales(UPCList,TotalBuyCost,TotalSaleValue,TaxCalculation,CreditCardProcessing,Profit,CashSale,CardSale)VALUES('"
                    + UPCList + "','" + TotalBuyCost + "','" + Math.Round(TotalItemSellValue*1.08,2) + "','" + Math.Round(TotalItemSellValue * .08,2) + "','" + Math.Round(TotalCardValue*card,2) + "','" + profitCalc() + "','" + TotalCashValue + "','" + TotalCardValue + "')";

                    cmd = new OleDbCommand(my_querry, myconn);
                    
                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch (Exception ex)
            {
                //simply inform me what exception has occured
                Console.WriteLine(ex);
            }
        }

        private static double profitCalc() {

            //calculate the sale
            double sale=Math.Round(TotalItemSellValue*1.08,2);
            //calculate tax
            double tax=Math.Round(TotalItemSellValue*.08,2);
            //calculate the credit card fee
            double ccFee =Math.Round(TotalCardValue * card,2);
            //calculate profit and return!
            return sale - tax - TotalBuyCost - ccFee; ;
        }

    }
}
