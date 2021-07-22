using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Database
    {

        public SQLiteConnection Myconnection;




        public void CreateConnection()
        {

            // Create a new database connection:
            Myconnection = new SQLiteConnection("Data Source=database.db;Version=3;New = True;Compress = True;");

         // Open the connection:
            try
            {
                Myconnection.Open();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"no connection.{ex.Message}");
            }
            
        }
    }
}
