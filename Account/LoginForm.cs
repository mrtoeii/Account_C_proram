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
using Org.BouncyCastle.Crypto.Generators;

namespace Account
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passsword_textbox.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = passsword_textbox.Text;
            string encrypt = AES_Encryption.Encrypt(password);
            string decrypt = AES_Encryption.Decrypt(encrypt);
            string constring = ConfigConnectSql.ConnectString();
            string sql = "select * from auth where username = '" + username + "'and password1 = '" + encrypt + "' ";

            MySqlConnection DataConnection = new MySqlConnection(constring);
            MySqlCommand command_DB = new MySqlCommand(sql, DataConnection);
            command_DB.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                DataConnection.Open();
                reader = command_DB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        //Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5) + " " + reader.GetString(6));
                        //Console.WriteLine(reader.GetString("password1"));

                        AccountForm dashboard = new AccountForm();
                        profile.storage_profile(reader.GetString("username"));
                        dashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect");
                }
                DataConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //if(con.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Connect Created Successfully");
            //}
            //else
            //{
            //    MessageBox.Show("Connection Failed");
            //}

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
