using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent();
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            //initialize the inventoryapp class
            InventoryApp inventoryapp = new InventoryApp();
            
            //call the date function in inventoryapp
            var date = inventoryapp.Datefxn();

            //output the date function
            this.time.Text = date;

            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            SearchButtonMethod();
        }

        private void SearchButtonMethod()
        {
            //create varibales for user input

            string partid = this.PartIDInput.Text;

            //replace empty spaces from user input
            partid.Replace(" ", "");

            //no case sensitive for user input
            partid.ToLower();

            //check for empty input from users

            if (partid != string.Empty)
            {
                var database = new Database();
                database.CreateConnection();



                //call database method to readdata
                database.ReadItemTable(partid);
                
                
                //call sqldatareader

                var sqlitedatateader = database.Sqlitedatareader;

                ViewInventoryDataGrid.ColumnCount = 8;

                ViewInventoryDataGrid.Columns[0].Name = "partid";
                ViewInventoryDataGrid.Columns[1].Name = "partname";
                ViewInventoryDataGrid.Columns[2].Name = "partunit";
                ViewInventoryDataGrid.Columns[3].Name = "quantity";
                ViewInventoryDataGrid.Columns[4].Name = "unitcost";
                ViewInventoryDataGrid.Columns[5].Name = "supplier";
                ViewInventoryDataGrid.Columns[6].Name = "supplierid";
               ViewInventoryDataGrid.Columns[7].Name = "timestamp";
                
                
                if (sqlitedatateader.Read())
                {
                    ViewInventoryDataGrid.Rows.Add(new object[] {
                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Partid")),  // U can use column index
                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Partname")),  // Or column name like this
                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Partunit")),

                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Quantity")),
                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Unitcost")),
                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Supplier")),
                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Supplierid")),
                    sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Timestamp"))



                    

                     }) ;

                    //output quantityinstock and orderstatus; nt the table for this will be daily usage table
                    string quantity = sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Quantity")).ToString();
                    this.QuantityinStock.Text = quantity;

                    //output entrytime
                    string time = sqlitedatateader.GetValue(sqlitedatateader.GetOrdinal("Timestamp")).ToString();
                    this.ViewEntryTime.Text = time;

                    //orderstatus
                    int orderstatus = Convert.ToInt32(quantity);
                    if(orderstatus <= 50)
                    {
                        this.OrderStatus.Text = "YES";
                    }

                    else if(orderstatus >= 50)
                    {
                        this.OrderStatus.Text = "NO";
                    }

                    //make the data grid visible
                    this.ViewInventoryDataGrid.Visible = true;
                }


                //check for null value from sqldatareader

                else if (!(sqlitedatateader.Read()))
                {
                    this.ViewErrorOut.Text = "invalid partid";

                    //make the data grid invisible
                    this.ViewInventoryDataGrid.Visible = false;

                }




            }

            else if (partid == string.Empty)
            {
                MessageBox.Show("enter partid");
                
            }

            
        }
    }
    }

