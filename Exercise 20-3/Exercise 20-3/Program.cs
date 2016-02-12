using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Exercise_20_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the data connection
            string connectionString = "server=.\\sqlexpress;Trusted_Connection=yes;database=Northwind";

            // create the string to hold the SQL command 
            // to get records from the Customers table
            string commandString = "select e.FirstName, e.LastName "+
                                   "from Employees e "+
                                   "join EmployeeTerritories et on e.EmployeeID = et.EmployeeID "+
                                   "join Territories t on et.TerritoryID = t.TerritoryID "+
                                   "join Region r on t.RegionID = r.RegionID "+
                                   "where r.RegionID = 1";

            // create the data adapter with the 
            // connection string and command
            SqlDataAdapter myDataAdapter = 
               new SqlDataAdapter(commandString, connectionString);

            // Create and fill the DataSet object
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet);

            // Retrieve the Orders table
            DataTable myDataTable = myDataSet.Tables[0];

            // iterate over the rows collection 
            // and output the fields
            Console.WriteLine("Employees in Region 1:");
            foreach (DataRow dataRow in myDataTable.Rows)
            {
                Console.WriteLine("{0} {1}", dataRow["FirstName"], dataRow["LastName"]);
            }

        }
    }
}
