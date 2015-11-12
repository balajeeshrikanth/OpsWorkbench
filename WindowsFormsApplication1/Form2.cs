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


namespace WindowsFormsApplication1
{ 
    public partial class Form2 : Form

    {
        private bool AuthenticateUser(string userName, string password)
        {
            
            //int isPresent = 0;
            MySqlDataReader cnreader;
            cnreader = null;
            String dbuserid;
          
            using ( MySqlConnection cn = new MySqlConnection("SERVER=localhost;" +
    "DATABASE=opsworkbench;" + "UID=root;" + "PASSWORD=coslcos1"))
            {
                cn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT user_id FROM opsworkbench.user WHERE user_id =\'" + userName + "\' AND user_password ='" + password + "\'";
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@userName", userName);
                    //cmd.Parameters.AddWithValue("@password", password);
                    cmd.Connection = cn;
                    //MessageBox.Show(cmd.CommandText);
                    try
                    {
                        //isPresent = cmd.ExecuteNonQuery();
                        cnreader = cmd.ExecuteReader();
                        while (cnreader.Read()) 
                            { dbuserid = Convert.ToString(cnreader["user_id"]);
                            //MessageBox.Show("Database ok");
                            //MessageBox.Show(dbuserid);
                            if (dbuserid == userName)
                            { return true; }
                           
                                }
                        return false;                     
                  
                    }
                    catch (Exception  ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                        
                        throw;
                    }
                    finally
                    {
                        cnreader.Close();
                        cn.Close();
                    }
                }
            }
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            Boolean result;
            
            //MessageBox.Show(userName);
            //MessageBox.Show(password);
            result = AuthenticateUser(userName, password);
           
            if (result) {
                //MessageBox.Show("Success"); 
                MessageBox.Show("Here we can record the Login time");
                new Form1().Show();
            }
            else { MessageBox.Show("Invalid Login");
                txtPassword.Text = null;
                txtPassword.Focus();
                // Application.Exit(); 
            }
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
