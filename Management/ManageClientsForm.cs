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
using System.Configuration;

namespace Management
{
    public partial class ManageClientsForm : Form
    {
        Client cl = new Client();
        public ManageClientsForm()
        {
            InitializeComponent();
            FillCombo();

        }

        public void FillCombo()
        {
            SQLConnect conn = new SQLConnect();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = " SELECT gender from sex";
            command.CommandText = query;
            command.Connection = conn.GetConnection();

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)

            {
                sexcombobox.Items.Add(dr["gender"].ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sexcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addclient_Click(object sender, EventArgs e)
        {
            String fname = firstname.Text;
            String lname = lastname.Text;
            String phone = phoneno.Text;
            String email = email1.Text;
            String dob = dobdatepicker.Text;
            String sex = sexcombobox.Text;
            String address = addressrichtextbox.Text;


            //Boolean insertclient = cl.insertClient(fname, lname, phone, email, dob, sex, address);

            if (firstname.Text.Trim().Equals("") || lastname.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter First and Last Name", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (phoneno.Text.Trim().Equals("") && email1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter phoneno. or email or both", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sexcombobox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please select gender", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addressrichtextbox.Text.Trim().Equals(""))
            {

                MessageBox.Show("Please enter your complete address", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Boolean insertclient = cl.insertClient(fname, lname, phone, email, dob, sex, address);

                if (insertclient)
                {
                    MessageBox.Show("New Client inserted successfully", "Client Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datagrid.DataSource = cl.getClients();
                }
                else
                {
                    MessageBox.Show("Error - Client Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void phoneno_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void clearfields_Click(object sender, EventArgs e)
        {
                id.Text = "";
                firstname.Text = "";
                lastname.Text = "";
                email1.Text = "";
                phoneno.Text = "";
                addressrichtextbox.Text = "";
                sexcombobox.Text = "";
                dobdatepicker.Text = "";
        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            datagrid.DataSource = cl.getClients();
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id1 = Convert.ToInt32(id.Text);
                if(cl.removeClient(id1))
                {
                    datagrid.DataSource = cl.getClients();
                    MessageBox.Show("Client Deleted Successfully", " Delete client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error -Client not deleted", " Delete client", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }

}

