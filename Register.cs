using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Home_Appliance_Rental_System
{
    public partial class Register : Form
    {
        private DatabaseAccess DB = new DatabaseAccess();

        public Register()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = Txtusername.Text;
            string password = Txtpassword.Text;

            SqlConnection connection = DB.GetConnection();
            string query = "insert into credentials ([username],[password]) values (" + username + "," + password + ")";
            SqlCommand command = new SqlCommand(query, connection);
            MessageBox.Show("Success");

            DB.CloseConnection(connection);
        }

        private bool nameValidation(string n)
        {
            Regex val = new Regex(@"^[a-zA-Z0-9]*$"); // Creating a Regular Expression object for name validation
            if (val.IsMatch(n) == false)
            {
                MessageBox.Show("Username can contain only letters and numbers. (eg. abc123)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txtusername.Focus();    //not to raise error
                return false;
            }
            else
            {
                return true;

            }
        }

        private static void Register_Load1(object sender, EventArgs e)
        {

        }

        private void LinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
    }
}


 
         
