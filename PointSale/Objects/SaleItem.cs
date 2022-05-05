using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PointSale
{
    //main item, does nearly anything regarding sales or database manipulation regarding itself
    public class SaleItem
    {
        private string itemUpc;
        private string itemName;
        private string itemDescription;
        private double itemBuyCostNow;
        private double itemBuyCostOld;
        private double itemSellValue;
        private int itemNumHaveNow;
        private int itemNumHaveOld;

        //has two references, should remove
        public SaleItem() { 
            //output a failure notice
        }
        //instantiates the item with only the UPC stored
        public SaleItem(String upc) {
            itemUpc = upc;
        }
        //instantiates the item with everything
        public SaleItem(string upc, string name, string description, double buyCost, double sellValue, int numHave) {
            itemUpc = upc;
            itemName = name;
            itemDescription = description;
            itemBuyCostNow = buyCost;
            itemBuyCostOld = 0;
            itemSellValue = sellValue;
            itemNumHaveNow = numHave;
            itemNumHaveOld = 0;
        }
        //adds total number of posessed items to the object
        public void addNumHave(int add) 
        {
            itemNumHaveNow += add;
        }
        //sells items, decrementing from itself and altering based on the previously contained values
        //ie: this Object contains 20 items, each selling for $4. The first 10 were purchased at $1, and late, 10 more at $2
        //this will make sure that the first value ($1) will be decremented BEFORE the $2 decrementation to adjust for changing buy values
        public void sellItem(int numSold) {
            //manage the inventory: old buy value comapired to new buyvalue
            itemNumHaveNow -= numSold;
            //check if items still exist that were purchased at a different price
            //if the number sold are >=the old value then it decrements the number sold
            if (itemNumHaveOld > 0 && (itemNumHaveOld - numSold) >= 0)
            {
                itemNumHaveOld -= numSold;
            }
            //if the amount sold is greater than the number of old items that existed,
            //decrement the value till it reaches zero
            //ex; store has three items at the old price, but I buy 4 items, we cannot
            //calculate all four sales at the cost of the old itemBuyPrice, only three
            else {
                for (;numSold>0;numSold--) {
                    itemNumHaveOld--;
                    //MUST DECLARE PROFIT FROM SALE HERE, or maybe not in the for, but still
                    //this is currently handeled by only ever selling one item at a time, preventing this else from ever running
                }
            }
        }
        //updates the cost of the item in question fro the user
        public void updateBuyCost(double newBuyCost) {
            itemBuyCostOld = itemBuyCostNow;
            itemBuyCostNow = newBuyCost;
        }
        //updates the value that the the user wishes to sell an item at
        public void updateSellValue(double newSaleValue) {
            itemSellValue = newSaleValue;
        }
        //updates the name of the ietm
        public void updateName(string newName) {
            itemName = newName;
        }
        //updates the description of the item
        public void updateDescription(string newDescript)
        {
            itemDescription = newDescript;
        }
        //updates the number of items that the user has
        //has the potential to be abused
        public void updateNumHave() {
            itemNumHaveOld = itemNumHaveNow;
        }
        //returns the UPC of the item
        public string getUpc()
        {
            return itemUpc;
        }
        //returns the name of the item
        public string getName()
        {
            return itemName;
        }
        //returns the description of the item
        public string getDescription()
        {
            return itemDescription;
        }
        //returns the current buycost of the item
        public double getBuyCost()
        {
            return itemBuyCostNow;
        }
        //returns the sale cost of the tiem
        public double getSaleValue()
        {
            return itemSellValue;
        }
        //ureturns the current number of the item
        public int getNumHave()
        {
            return itemNumHaveNow;
        }
        //saves the item to the INVENTORY table
        //currently partially succeptable to injection
        public void saveItem() 
        {
            try
            {
                OleDbConnection myconn = new OleDbConnection();                     //Data Source=C:\Users\Phill\source\repos\PointSale\
                string filePath = System.AppContext.BaseDirectory;
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + filePath + "\\PoSDatabase.mdb;";
                myconn.Open();

                string my_querry="";
                OleDbCommand cmd;
                //if the UPC does not exist in the table, add it
                if (!doesUPCExist())
                {
                    //this part is succeptable to injection
                    Console.WriteLine("creating new item...");
                    my_querry = "INSERT INTO Inventory(UPC,ItemName,ItemDescription,ItemBuyCostNow,ItemBuyCostOld,ItemSellValue,ItemNumHaveNow,ItemNumHaveOld)VALUES('"
                        + itemUpc + "','" + itemName + "','" + itemDescription + "','" + itemBuyCostNow + "','" + itemBuyCostOld + "','" + itemSellValue + "','" + itemNumHaveNow + "','" + itemNumHaveOld + "')";
                    cmd = new OleDbCommand(my_querry, myconn);
                }
                //otherwise, update the item with new information
                else
                { 
                    Console.WriteLine("Updating item...");
                    my_querry = @"UPDATE Inventory SET [UPC] = @itemUpc, [ItemName] = @itemName, [ItemDescription] = @itemDescription, [ItemBuyCostNow] = @itemBuyCostNow, [ItemBuyCostOld] = @itemBuyCostOld, [ItemSellValue] = @itemSellValue, [ItemNumHaveNow] = @itemNumHaveNow, [ItemNumHaveOld] = @itemNumHaveOld WHERE UPC=@itemUpc";
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
        //returns true if the UPC exiss in the INVENTIRY table
        public bool doesUPCExist() {
            //should querry the database for the UPCs existance
            try
            {
                OleDbConnection myconn = new OleDbConnection();                    
                string filePath = System.AppContext.BaseDirectory;
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + filePath + "\\PoSDatabase.mdb;";
                myconn.Open();
                //succeptable to injection
                string my_querry = "SELECT * FROM Inventory WHERE UPC = '"+itemUpc+"'";
                Console.WriteLine(my_querry);
                OleDbCommand cmd=new OleDbCommand(my_querry,myconn);

                OleDbDataReader dr = cmd.ExecuteReader();
                //if the loop runs the item exists
                while (dr.Read()) {
                    myconn.Close();
                    return true;
                }
                //if it does not run it does not exist
                myconn.Close();
                return false;
            }
            catch (Exception Ex) {
                Console.WriteLine(Ex);
                return false;
            }
                
        }
        //loads the item based on the UPC
        //sending the UPC a second time is redundant
        //succeptable to injection
        public void load(String upc) {
            itemUpc = upc;
            try
            {
                OleDbConnection myconn = new OleDbConnection();                     //Data Source=C:\Users\Phill\source\repos\PointSale\
                string filePath = System.AppContext.BaseDirectory;
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + filePath + "\\PoSDatabase.mdb;";
                myconn.Open();
                //succeptable to injection
                string my_querry = "SELECT * FROM Inventory WHERE UPC = '" + upc + "'";
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
                    Console.WriteLine(dr[4].ToString()); //haveNow
                    itemNumHaveNow = Convert.ToInt32(dr[4].ToString());
                    Console.WriteLine(dr[5].ToString()); //haveOld
                    itemNumHaveOld = Convert.ToInt32(dr[5].ToString());
                    Console.WriteLine(dr[6].ToString()); //buyNow
                    itemBuyCostNow = Convert.ToDouble(dr[6].ToString());
                    Console.WriteLine(dr[7].ToString()); //buyOld
                    itemBuyCostOld = Convert.ToDouble(dr[7].ToString());
                    Console.WriteLine(dr[8].ToString()); //sell
                    itemSellValue = Convert.ToDouble(dr[8].ToString());
                }
                myconn.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }
        //deletes an item from the table based on the UPC
        public void DELETE() {
            try
            {
                OleDbConnection myconn = new OleDbConnection();                     
                string filePath = System.AppContext.BaseDirectory;
                myconn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + filePath + "\\PoSDatabase.mdb;";
                myconn.Open();
                //succeptable to injection
                string my_querry = "DELETE * FROM Inventory WHERE UPC = '" + itemUpc + "'";
                //Console.WriteLine(my_querry);
                OleDbCommand cmd = new OleDbCommand(my_querry, myconn);

                OleDbDataReader dr = cmd.ExecuteReader();
                myconn.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}