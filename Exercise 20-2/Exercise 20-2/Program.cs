using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Exercise_20_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the data connection
            string connectionString = "server=.\\sqlexpress;Trusted_Connection=yes;database=Northwind";

            // create the string to hold the SQL command 
            // to get records from the Customers table
            string commandString = "Select ProductID, ProductName from Products where UnitsInStock < 10";

            // create the data adapter with the connection string and command
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(commandString, connectionString);

            // Create and fill the DataSet object
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet);

            // Retrieve the Orders table
            DataTable myDataTable = myDataSet.Tables[0];

            // iterate over the rows collection and output the fields
            Console.WriteLine("Products with less than 10 units in stock:");
            foreach (DataRow dataRow in myDataTable.Rows)
            {
                Console.WriteLine("ProductID: {0} \tProduct Name: {1}", dataRow["ProductID"], dataRow["ProductName"]);
            }

        }
    }
}
