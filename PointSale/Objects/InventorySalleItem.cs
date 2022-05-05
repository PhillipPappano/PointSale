using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PointSale
{
    //need to document more
    //yes, sale is spelled wrong, I dont care enough to fix it
    public class InventorySalleItem
    {
        //all the variables needed, they are self explanitory
        private string itemUpc;
        private string itemName;
        private string itemDescription;
        private double itemBuyCostNow;
        private double itemBuyCostOld;
        private double itemSellValue;
        private int itemNumHaveNow;
        private int itemNumHaveOld;

        public InventorySalleItem()
        {
            //output a failure notice
        }

        public InventorySalleItem(String upc)
        {
            //allows an item to be created with only the UPC to allow for later population and for diging through the database
            itemUpc = upc;
        }
        public InventorySalleItem(string upc, string name, string description, double buyCost, double sellValue, int numHave)
        {
            //creates a new item with everything
            itemUpc = upc;
            itemName = name;
            itemDescription = description;
            itemBuyCostNow = buyCost;
            itemBuyCostOld = 0;
            itemSellValue = sellValue;
            itemNumHaveNow = numHave;
            itemNumHaveOld = 0;
        }
        public void addNumHave(int add) //should include/update on new buy costs?
        {
            //adds one to the number of items held in inventory
            itemNumHaveNow += add;
        }

        public int getNumHave()
        {
            //return the number of items you have already checked for inventory
            return itemNumHaveNow;
        }

        public bool doesUPCExist()
        {
            //should querry the MONTHLYINVENTORY table for the UPCs existance
            //succeptable to injection, needs to be fixed
            try
            {
                OleDbConnection myconn = new OleDbConnection();
                string filePath = System.AppContext.BaseDirectory;
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + filePath + "\\PoSDatabase.mdb;";
                myconn.Open();

                string my_querry = "SELECT * FROM MonthlyInventory WHERE UPC = '" + itemUpc + "'";
                Console.WriteLine(my_querry);
                OleDbCommand cmd = new OleDbCommand(my_querry, myconn);

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[1].ToString());
                    myconn.Close();
                    return true;
                }

                myconn.Close();
                return false;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
                return false;
            }
            //return false;
        }

        public void saveItem()
        {
            //saves the item to the MONTHLYINVENTORY table
            //partially succeptable to injection, should be fixed
            try
            {
                OleDbConnection myconn = new OleDbConnection();                     
                string filePath = System.AppContext.BaseDirectory;
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + filePath + "\\PoSDatabase.mdb;";
                myconn.Open();

                string my_querry = "";
                OleDbCommand cmd;
                if (!doesUPCExist())
                {
                    //this part is succeptable to injection
                    Console.WriteLine("creating new item...");
                    my_querry = "INSERT INTO MonthlyInventory(UPC,ItemName,ItemDescription,ItemBuyCostNow,ItemBuyCostOld,ItemSellValue,ItemNumHaveNow,ItemNumHaveOld)VALUES('"
                        + itemUpc + "','" + itemName + "','" + itemDescription + "','" + itemBuyCostNow + "','" + itemBuyCostOld + "','" + itemSellValue + "','" + itemNumHaveNow + "','" + itemNumHaveOld + "')";
                    cmd = new OleDbCommand(my_querry, myconn);
                }
                else
                { //update old
                    /*
                     
                     */
                    //my_querry = "UPDATE Inventory";
                    Console.WriteLine("Updating item...");
                    my_querry = @"UPDATE MonthlyInventory SET [UPC] = @itemUpc, [ItemName] = @itemName, [ItemDescription] = @itemDescription, [ItemBuyCostNow] = @itemBuyCostNow, [ItemBuyCostOld] = @itemBuyCostOld, [ItemSellValue] = @itemSellValue, [ItemNumHaveNow] = @itemNumHaveNow, [ItemNumHaveOld] = @itemNumHaveOld WHERE UPC=@itemUpc";
                    cmd = new OleDbCommand(my_querry, myconn);
                    cmd.Parameters.AddWithValue("@itemUPC", itemUpc);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@itemDescription", itemDescription);
                    cmd.Parameters.AddWithValue("@itemBuyCostNow", itemBuyCostNow);
                    cmd.Parameters.AddWithValue("@itemBuyCostOld", itemBuyCostOld);
                    cmd.Parameters.AddWithValue("@itemSellValue", itemSellValue);
                    cmd.Parameters.AddWithValue("@itemNumHaveNow", itemNumHaveNow);
                    cmd.Parameters.AddWithValue("@itemNumHaveOld", itemNumHaveOld);

                }
                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void load(String upc)
        {
            //loads the item from the database
            //succeptable to injection
            itemUpc = upc;
            try
            {
                OleDbConnection myconn = new OleDbConnection();                     
                string filePath = System.AppContext.BaseDirectory;
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + filePath + "\\PoSDatabase.mdb;";
                myconn.Open();
                //need to add an "old sell value" line to database & object
                string my_querry = "SELECT * FROM MonthlyInventory WHERE UPC = '" + upc + "'";
                Console.WriteLine(my_querry);
                OleDbCommand cmd = new OleDbCommand(my_querry, myconn);

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[1].ToString()); //upc
                    Console.WriteLine(dr[2].ToString()); //name
                    itemName = dr[2].ToString();
                    Console.WriteLine(dr[3].ToString()); //descript
                    itemDescription = dr[3].ToString();
                    Console.WriteLine(dr[4].ToString()); //buyNow
                    itemBuyCostNow  = Convert.ToDouble(dr[4].ToString());
                    Console.WriteLine(dr[5].ToString()); //buyOld
                    itemBuyCostOld  = Convert.ToDouble(dr[5].ToString());
                    Console.WriteLine(dr[6].ToString()); //sellValue
                    itemSellValue  = Convert.ToDouble(dr[6].ToString());
                    Console.WriteLine(dr[7].ToString()); //numHvaeNow
                    itemNumHaveNow  = Convert.ToInt32(dr[7].ToString());
                    Console.WriteLine(dr[8].ToString()); //haveOld
                    itemNumHaveOld  = Convert.ToInt32(dr[8].ToString());

                }
                myconn.Close();

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }

    }
}
