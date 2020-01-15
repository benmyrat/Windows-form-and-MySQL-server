using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorization
{
    class connectionDatabase
    {
        MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;" +
           "username=root;password=21071998;database=mylittledatabase");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
