using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TechArmy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            userLogin();//call method
        }

        private void userLogin() {
            try
            {
                string  userType = cmbUserType.SelectedItem.ToString();
               string username = txtUsername.Text;
               string password = txtPassword.Text;

                if (userType == "admin")
                {/*
                   if (username.Trim() == "" && password.Trim() == "")
                    {
                        MessageBox.Show("Empyt Field, try again ", "Error");
                    }
                    else
                    {
                        string query = "SELECT * FROM login WHERE username= @user AND password = @pass AND userType = 'admin'";
                        SQLiteConnection conn = new SQLiteConnection("Data Source=afis.db;Version=3;");
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("You Have Login in", "Admin Login Succesfully");
                            new AdminForm().Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Login Failed, try again ", "Error");
                        }

                    }*/
                    new AdminForm().Show();
                }
                else if (userType == "security")
                {
                     /* if (username.Trim() == "" && password.Trim() == "")
                      {
                          MessageBox.Show("Empyt Field, try again ", "Error");
                      }
                      else
                      {
                          string query = "SELECT * FROM login WHERE username= @user AND password = @pass AND userType = 'security'";
                          SQLiteConnection conn = new SQLiteConnection("Data Source=afis.db;Version=3;");
                          conn.Open();
                          SQLiteCommand cmd = new SQLiteCommand(query, conn);
                          cmd.Parameters.AddWithValue("@user", username);
                          cmd.Parameters.AddWithValue("@pass", password);

                          SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt.Rows.Count > 0)
                          {
                              MessageBox.Show("You Have Login in", "Security Login Succesfully");
                              new SecurityForm().Show();
                              this.Hide();

                          }
                          else
                          {
                              MessageBox.Show("Login Failed, try again ", "Error");
                          }

                      }
                      */
                     
                    new SecurityForm().Show();
                }
                else
                {
                    cmbUserType.Focus();
                }
           
            
            }catch(NullReferenceException e) { }

           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            cmbUserType.SelectedIndex = -1;
        }
    }

}
