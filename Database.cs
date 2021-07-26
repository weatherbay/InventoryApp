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


        public SQLiteCommand Sqlitecommand;


        public SQLiteDataReader Sqlitedatareader;




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

        public void CreateTable()
        {
            string sqlquery = "create table if not exists testtable (col1 varchar(20), col2 int)";
            Sqlitecommand = Myconnection.CreateCommand();
            Sqlitecommand.CommandText = sqlquery;
            Sqlitecommand.ExecuteNonQuery();


            
        }

        public void InsertTable()
        {
            string sqlquery = "insert into testtable (col1, col2) values ('test',1);";
            Sqlitecommand = Myconnection.CreateCommand();
            Sqlitecommand.CommandText = sqlquery;
            Sqlitecommand.ExecuteNonQuery();



        }

        public void ReadTable()
        {
            string sqlquery = "select * from testtable";
            Sqlitecommand = Myconnection.CreateCommand();
            Sqlitecommand.CommandText = sqlquery;
            Sqlitedatareader = Sqlitecommand.ExecuteReader();



        }
    }
}
