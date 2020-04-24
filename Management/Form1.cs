using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            SQLConnect conn = new SQLConnect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = " SELECT * FROM `appusers` WHERE `username`= @admin AND `password`= @12345;";
            command.CommandText = query;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@admin", MySqlDbType.VarChar).Value = username.Text;
            command.Parameters.Add("@12345", MySqlDbType.VarChar).Value = Password.Text;



            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count >0)

            {
                this.Hide();
                Main mform = new Main();
                mform.Show();
            

            }

            else
            {
                if (username.Text.Trim().Equals("") && Password.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Username and Password to Login", "Empty Username and Password fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   

                else if (username.Text.Trim().Equals(""))
                    {
                    MessageBox.Show("Enter Username to Login", "Empty Username field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (Password.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Password to Login", "Empty Password field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                


                else
                    MessageBox.Show("Username or Password is not correct. Please try again", "Incorrect username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
