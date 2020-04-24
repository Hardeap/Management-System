using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Management
{
    class Client
    {
        SQLConnect conn = new SQLConnect();

        public bool insertClient(String fname, String lname, String phoneno1, String email, String dob, string sex, String address)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `manageclients`(`fnames`, `lnames`, `phonenos`, `emails`, `dobs`, `sexs`, `addresses`) VALUES (@fns,@lns,@phns, @emls, @dos,@sxs, @adds)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@fns,@lns,@phns, @emls, @dos,@sxs, @adds
            command.Parameters.Add("@fns", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lns", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phns", MySqlDbType.VarChar).Value = phoneno1;
            command.Parameters.Add("@emls", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@dos", MySqlDbType.VarChar).Value = dob;
            command.Parameters.Add("@sxs", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@adds", MySqlDbType.VarChar).Value = address;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;

            }

            else
            {
                conn.closeConnection();
                return false;

            }







        }
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("Select * FROM manageclients ", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;




        }
        
        


        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM 'manageclients' WHERE 'id' = @cid";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            //cid,@fns,@lns,@phns, @emls, @dos,@sxs, @adds
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = id;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;

            }

            else
            {
                conn.closeConnection();
                return false;

            }
        }
    }
}
