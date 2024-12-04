﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystem
{
    public partial class frmLogin : Form
    {

        public string username, password;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;


            if (IsValidUser(username, password))
            {
                if (username == "admin01")
                {
                    frmAdmin frmadmin = new frmAdmin();
                    frmadmin.ShowDialog();
                }
                else if(username == "user01")
                {
                    frmUser frmUser = new frmUser();
                    frmUser.ShowDialog();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsValidUser(string admin, string password)
        {
            SqlConnectionClass dbConnection = new SqlConnectionClass();

            string adminQuery = "SELECT COUNT(*) FROM admin WHERE admin = @username AND password = @password";
            string userQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            try
            {
                using (SqlConnection connection = dbConnection.GetConnection())
                {
                    connection.Open();

                
                    using (SqlCommand adminCommand = new SqlCommand(adminQuery, connection))
                    {
                        adminCommand.Parameters.AddWithValue("@username", username);
                        adminCommand.Parameters.AddWithValue("@password", password);

                        int adminCount = (int)adminCommand.ExecuteScalar();
                        if (adminCount > 0)
                        {
                            return true;
                        }
                    }

                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection))
                    {
                        userCommand.Parameters.AddWithValue("@username", username);
                        userCommand.Parameters.AddWithValue("@password", password);

                        int userCount = (int)userCommand.ExecuteScalar();
                        if (userCount > 0)
                        {
                            return true; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while validating user: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
