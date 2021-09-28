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

namespace MailClient
{
    public partial class Form1 : Form
    {
        public static String userFirstName,userLastName;
        public static int ID;
        public Form1()
        {
            InitializeComponent();
        }



        #region Log In section

        private void createButton_Click(object sender, EventArgs e)
        {
            FormCreateAccount createAccount = new FormCreateAccount();
            createAccount.ShowDialog();
           

        }

        private void textLogIn_TextChanged(object sender, EventArgs e)
        {

        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            /*
            creating two variables that will store the input of the userName and password 
            from the application user.
            */
            String UserName = logInText.Text;
            String Password = textPassword.Text;
            /*
            storing the two given strings in a list, then sending them to the function that 
            will check that thet are not empty, only then we will creat a connection to the 
            dataBase to check for the users account.
            */
            LinkedList<String> needToCheck = new LinkedList<String>();
            needToCheck.AddFirst(Password);
            needToCheck.AddFirst(UserName);
            /* creatign a bool flag to represent a successful search*/
            DataSet dtable = new DataSet();
            bool loginSuccessful = false;
            if (new FormCreateAccount().checkInPut(needToCheck)) { 
                try
                {
                    /*
                     * connectionString = will store the infroamtion needed to connect to the data base 
                     * is self.
                     * mySQL = will store a sting that will represent the query that will be sent to the 
                     * dataBase.
                     * connection = a object that takes the connectionString as a argument to its initialization
                     * for for future questioning of the dataBase.
                     * command = takes the MySQL and connection argument so it will be able to be send alone
                     * as an argument but it will store the query and the key to the database as well.
                     * dtb = the data retrived from the query to the dataBase.
                     * line 85-87 = giveing loginSuccessful the value true/false, based on what was retrived from the 
                     * query, if no rows(matching account) where found the value will be false, otherwise true.
                     * giving useFirstName, userLasName the first and last names of the account that was pulled, for 
                     * future use.
                     */
                    String connectionString = "datasource =localhost; port = 3306; username = root; password =";
                    String mySQL = "select ID, firstName, lastName from email_client.users where userName='" + UserName + "' and passWord='" + Password + "'";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    MySqlCommand command = new MySqlCommand(mySQL, connection);
                    connection.Open();
                    MySqlDataAdapter dtb = new MySqlDataAdapter(command);
                    dtb.Fill(dtable);
                    loginSuccessful = (dtable.Tables.Count > 0) && (dtable.Tables[0].Rows.Count > 0);
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (loginSuccessful)
            {
                userFirstName = dtable.Tables[0].Rows[0].Field<String>("firstName");
                userLastName = dtable.Tables[0].Rows[0].Field<String>("lastName");
                ID = dtable.Tables[0].Rows[0].Field<int>("ID");
                UserMenu UserMenu = new UserMenu();
                this.Hide();
                UserMenu.ShowDialog();
                this.Close(); 
            }
            else
            {
                errorPassLog.Text = "Invalid user name or password";
            }
        }
        #endregion
        private void errorPassLog_Click(object sender, EventArgs e)
        {

        }

        private void logInText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public String getFirstName()
        {
            return userFirstName;
        }
        public String getLastName()
        {
            return userLastName;
        }
        public int getID() {
            return ID;
        }
        }
    }
