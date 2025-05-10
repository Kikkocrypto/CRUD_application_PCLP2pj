using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace StudentManagementApp
{
    internal class DBConnection
    {
        private MySqlConnection connection;

        //INITIALIZE DB CONNECTION WITH THE CLASS
        public DBConnection()
        {
            try
            {
                string dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
                string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
                string dbHost = Environment.GetEnvironmentVariable("DB_HOST");

                string connectionString = $"server={dbHost};port=3306;user={dbUser};password={dbPassword};database=student_db";

                connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to DB. ", "error: " + ex.Message);
            }
        }

        //GET CONNECTION FUNCTION
        public MySqlConnection getConnection()
        {
            return connection;
        }

        //CREATE A FUNCTION TO OPEN AND CLOSE CONNECTION
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //CLOSE
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
