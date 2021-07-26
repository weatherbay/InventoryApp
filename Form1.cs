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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var database = new Database();
            database.CreateConnection();
            MessageBox.Show("connected");

            //call create table method

            database.CreateTable();
            MessageBox.Show("table created");


            //call insert table

            database.InsertTable();
            MessageBox.Show("table data inserted");


            //read user data

            database.ReadTable();

            if (database.Sqlitedatareader.Read())
            {
                string reader = database.Sqlitedatareader.GetString(0);
                MessageBox.Show(reader);
            }

            database.Myconnection.Close();
            
        }

        



    }
}
