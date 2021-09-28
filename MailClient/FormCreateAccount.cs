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
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void areaCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            LinkedList<string> allInput = new LinkedList<string>();
            allInput.AddFirst(userNameBox.Text);
            allInput.AddFirst(PasswordBox.Text);
            allInput.AddFirst(firstNameBox.Text);
            allInput.AddFirst(lastNameBox.Text);
            allInput.AddFirst(phoneNumberBox.Text);
            allInput.AddFirst(confirmPasswordBox.Text);

            LinkedList<string> LenInPut = new LinkedList<string>();
            LenInPut.AddFirst(userNameBox.Text);
            LenInPut.AddFirst(PasswordBox.Text);

            string[] matchingStrings = { PasswordBox.Text, confirmPasswordBox.Text };
            

            if (checkInPut(allInput)&&CheckLengthOfInput(LenInPut)&& isMatchingStrings(matchingStrings))
            {
               
                try
                {
                    String connectionString = "datasource =localhost; port = 3306; username = root; password =";
                    String mySQL = ("INSERT INTO email_client.users (`userName`, `passWord`, `firstName`, `lastName`,`optionalMail`, `phoneNumber`) VALUES ('" + userNameBox.Text + "','" + PasswordBox.Text + "','" + firstNameBox.Text + "','" + lastNameBox.Text + "','" + ReservEmailBox.Text + "','" + phoneNumberBox.Text + "')");
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    MySqlCommand command = new MySqlCommand(mySQL, connection);
                    connection.Open();
                    MySqlDataAdapter dtb = new MySqlDataAdapter(command);
                    DataSet dtable = new DataSet();
                    dtb.Fill(dtable);
    

                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                string examption = "";
                if (!checkInPut(allInput))
                    examption += "please fill all marked fields!\n";
                if (!CheckLengthOfInput(LenInPut))
                    examption += "userName && password need to be more then 8 chars!\n";
                if (!isMatchingStrings(matchingStrings))
                    examption += "password and confirm password fileds do not match!";
                MessageBox.Show(examption);
            }
        }
        private void registerFormContiner_Enter(object sender, EventArgs e)
        {

        }


        public bool CheckLengthOfInput(LinkedList<string> list)
        {
            //checking that the list of strings is not shorter then 8 chars
            foreach (string input in list)
                if (input.Length<8)
                    return false;
            return true;
        }
        public bool checkInPut(LinkedList<string> list)
        {
            //checking that the list of strings is not empty
            foreach (string input in list)
                if (input == "")
                    return false;
            return true;
        }

        public bool isMatchingStrings(string[] listOfInput)
        {
            for (int i = 0; i < listOfInput.Length - 1; i++)
                if (listOfInput[i] != listOfInput[i + 1])
                    return false;
            return true;
        }
    }
}
