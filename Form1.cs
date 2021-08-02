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
    public partial class InventoryApp : Form
    {
        public InventoryApp()
        {
            
            InitializeComponent();
            
            
        }



        //date function
        public string Datefxn()
        {
            DateTime currentdate = DateTime.Now;
            string convert = currentdate.ToString("dd-MM-yyyy");
            
            return  "Date: " + convert;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //output datefunction
            this.time.Text = Datefxn();

            var database = new Database();
            database.CreateConnection();
            MessageBox.Show("connected");

            //call create table method

            database.CreateTable();
            MessageBox.Show("table created");


            //call insert table

            //database.InsertTable();
            //MessageBox.Show("table data inserted");


            //read user data
            /*
            database.ReadTable();

            if (database.Sqlitedatareader.Read())
            {
                string reader = database.Sqlitedatareader.GetString(0);
                MessageBox.Show(reader);
            }

            database.Myconnection.Close();

            */

            InventoryApp inventory = new InventoryApp();
            inventory.Refresh();
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            this.ErrorLabel.Text = AddItemFunction();
        }

        private string AddItemFunction()
        {
            //create varibales for user input

            string partid = this.PartIDInput.Text;
            string partname = this.PartNameInput.Text;
            string partunit = this.PartUnitInput.Text;
            string quantity = this.QuantityInput.Text;

            

            string unitcost = this.UnitCostInput.Text;
            
            string supplier = this.SupplierInput.Text;
            string supplierid = this.SupplierIDInput.Text;

            //replace empty spaces from user input
            partid.Replace(" ", "");
            partname.Replace(" ", "");
            partunit.Replace(" ", "");
            supplier.Replace(" ", "");
            supplierid.Replace(" ", "");



            //no case sensitive for user input
            partid.ToLower();
            partname.ToLower();
            partunit.ToLower();
            supplier.ToLower();
            supplierid.ToLower();


            //check for empty input from users

            if (partid != string.Empty || partname != string.Empty || partunit != string.Empty || quantity!=string.Empty || unitcost!=string.Empty || 
                supplier!=string.Empty || supplierid != string.Empty)
            {
                var database = new Database();
                database.CreateConnection();


                //call insert method from database.cs
                int unitcostconvert = Convert.ToInt32(unitcost);
                int quantityconvert = Convert.ToInt32(quantity);
                database.InsertItemTable(partid, partname, partunit, quantityconvert, unitcostconvert, supplier, supplierid);
                return "item added";
            }

            return "missing field";

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {
            //go to the viewinventory page
            ViewInventory viewinventory = new ViewInventory();
            viewinventory.Show();
        }
    }
}
