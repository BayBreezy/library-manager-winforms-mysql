using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace LibraryManager.Connection
{
    public static class Connection
    {
        static MySqlConnection dbConnection = null;

        // Method used to get connection string and establish connection
        private static MySqlConnection? getDBConnection()
        {
            try
            {
                if (dbConnection == null)
                {
                    // Get connection string from `App.config` file
                    string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
                    // Set connection
                    dbConnection = new MySqlConnection(connectionString);
                }
                return dbConnection;
            }
            catch (Exception ex)
            {
                // Show connection error box if connection did not take place
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
        }

        // Open connection
        public static MySqlConnection OpenConnection()
        {
            try
            {
                getDBConnection();
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                }
                return dbConnection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Close connection
        public static void CloseConnection()
        {
            try
            {
                if (dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
