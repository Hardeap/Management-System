using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Management
{
    class SQLConnect
    {
        private MySqlConnection Connection = new MySqlConnection("datasource = localhost; port = 3306; username =root; password=; database= managementcs1;");

        public MySqlConnection GetConnection()

        {
            return Connection;

        }

        public void openConnection()
        {
            if(Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        public void closeConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }







    }
}
