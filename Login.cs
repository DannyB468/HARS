using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Home_Appliance_Rental_System
{
    public partial class Login : Form
    {
        private DatabaseAccess DB = new DatabaseAccess();


        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;

            SqlConnection connection = DB.GetConnection();
            string query = "select COUNT(*) from credentials where Username = '"+username+"' AND Password = '"+password+"'";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Success");
                }
                else MessageBox.Show("Fail");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("" + ex);
            }
            


            DB.CloseConnection(connection);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            this.Hide();
            rg.Show();
        }
    }
}
