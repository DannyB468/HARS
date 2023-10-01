using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Appliance_Rental_System
{
    public class DatabaseAccess
    {
        public string connectionString = @"Data Source=DAN;Initial Catalog = credentials; Integrated Security = True";
        public SqlConnection GetConnection()
        {
            SqlConnection connection =new SqlConnection(connectionString); //create object
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to the database:" + ex.Message); //exception error
                return null;

            }
        }
        public void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
