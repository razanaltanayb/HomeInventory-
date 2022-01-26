using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeInventory.entites;
namespace HomeInventory.data
{
    public static class ItemsDAL
    {
        
            private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\User\\Desktop\\Item.accdb";
            private static OleDbConnection connection = new OleDbConnection(connectionString);




            public static void CreateItem(Item item)
            {

                string commandText = $"Insert into Item values('{item.ItemName}', '{item.Unit}'," +
               $" {item.Quantity}, {item.UserID} )";
                OleDbCommand command = new OleDbCommand(commandText, connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            public static void UpdateItem(Item item)
            {
                string commandText = $"Update Item Set " +
               $"ItemName = '{item.ItemName}', " +
               $"Unit = '{item.Unit}', " +
               $"Quantity = {item.Quantity}, " +
               $"UserId = {item.UserID} " +
               $"where ItemId = {item.ItemID}";

                OleDbCommand command = new OleDbCommand(commandText, connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            public static void DeleteItem(Item item)
            {
                string commandText = $"Delete from Item where ItemId = {item.ItemID}";
                OleDbCommand command = new OleDbCommand(commandText, connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            public static DataTable GetAllItem()
            {
                string commandText = $"Select * from  Item";
                OleDbCommand command = new OleDbCommand(commandText, connection);

                OleDbDataAdapter da = new OleDbDataAdapter(command);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }

        public static Item GetItemById(int ItemID)
        {
            Item item = new Item();

            string commandText = $"Select * from Items where ItemId={ItemID}";

            OleDbCommand command = new OleDbCommand(commandText, connection);
            connection.Open();

            OleDbDataReader itemReader = command.ExecuteReader();

            if (itemReader.HasRows)
            {
                while (itemReader.Read())
                {
                    item.ItemID = itemReader.GetInt32(0);
                    item.ItemName = itemReader.GetString(1);
                    item.Unit = itemReader.GetString(2);
                    item.Quantity = itemReader.GetDouble(3);
                    item.UserID = itemReader.GetInt32(4);
                }
            }

            connection.Close();
            return item;
        }
    }
}
