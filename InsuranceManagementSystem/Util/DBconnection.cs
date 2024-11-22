using System;
using System.Data.SqlClient;

namespace InsuranceManagementSystem.Util
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Server=DESKTOP-LO4QRAG;Database=InsuranceManagementSystem;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
