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

        
        //sqladapter for sqlite

        public SQLiteDataAdapter sqladapter;


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
            //string sqlquery = "create table if not exists testtable (col1 varchar(20), col2 int)";
            string createitemtable = "create table if not exists inventoryitems (partid varchar(5) primary key, " +
                "partname varchar(10), partunit varchar(3), quantity int, unitcost int, supplier varchar(10), supplierid varchar(5)," +
                "Timestamp default current_timestamp not null)";
            Sqlitecommand = Myconnection.CreateCommand();
            //Sqlitecommand.CommandText = sqlquery;
            //Sqlitecommand.ExecuteNonQuery();

            Sqlitecommand.CommandText = createitemtable;
            Sqlitecommand.ExecuteNonQuery();



        }
        //hardcoded inserttable witj sqlite
        public void InsertTable()
        {
            string sqlquery = "insert into testtable (col1, col2) values ('test',1);";
            Sqlitecommand = Myconnection.CreateCommand();
            Sqlitecommand.CommandText = sqlquery;
            Sqlitecommand.ExecuteNonQuery();



        }

        //hardcoded readtable with sqlite
        public void ReadTable()
        {
            string sqlquery = "select * from testtable";
            Sqlitecommand = Myconnection.CreateCommand();
            Sqlitecommand.CommandText = sqlquery;
            Sqlitedatareader = Sqlitecommand.ExecuteReader();



        }



        //item for inventory structure

        public void InsertItemTable(string partid, string partname, string partunit, int quantity, int unitcost, string supplier, string supplierid)
        {
            string sqlquery = "insert into inventoryitems (partid, partname,partunit,quantity,unitcost,supplier,supplierid) values (@partid," +
                "@partname, @partunit, @quantity, @unitcost, @supplier, @supplierid);";
            Sqlitecommand = Myconnection.CreateCommand();
            Sqlitecommand.CommandText = sqlquery;
            Sqlitecommand.Parameters.Add("@partid", (System.Data.DbType)System.Data.SqlDbType.VarChar, 5).Value = partid;
            Sqlitecommand.Parameters.Add("@partname", (System.Data.DbType)System.Data.SqlDbType.VarChar, 10).Value = partname;
            Sqlitecommand.Parameters.Add("@partunit", (System.Data.DbType)System.Data.SqlDbType.VarChar, 3).Value = partunit;
            Sqlitecommand.Parameters.Add("@quantity", (System.Data.DbType)System.Data.SqlDbType.Int).Value = quantity;
            Sqlitecommand.Parameters.Add("@unitcost", (System.Data.DbType)System.Data.SqlDbType.Int).Value = unitcost;
            Sqlitecommand.Parameters.Add("@supplier", (System.Data.DbType)System.Data.SqlDbType.VarChar, 10).Value = supplier;
            Sqlitecommand.Parameters.Add("@supplierid", (System.Data.DbType)System.Data.SqlDbType.VarChar, 5).Value = supplierid;
            Sqlitecommand.ExecuteNonQuery();



        }

        public void ReadItemTable(string partid)
        {
            string sqlquery = "select * from inventoryitems where partid =@partid";
            Sqlitecommand = Myconnection.CreateCommand();
            Sqlitecommand.CommandText = sqlquery;
            Sqlitecommand.Parameters.Add("@partid", (System.Data.DbType)System.Data.SqlDbType.VarChar, 5).Value = partid;
            Sqlitedatareader = Sqlitecommand.ExecuteReader();


            //sqladapter for readall command
            //sqladapter = new SQLiteDataAdapter(sqlquery, Myconnection);
            
        }
    }
}
