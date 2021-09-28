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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }
        Timer time;

        private void UserMenu_Load(object sender, EventArgs e)
        {
            refresh_emails();      
        }
        private void newMessageBtn_Click(object sender, EventArgs e)
        {
            NewMessage newMessage = new NewMessage();
            newMessage.ShowDialog();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 loginMenue = new Form1();
            this.Hide();
            loginMenue.ShowDialog();
            this.Close();
        }

        private void NameLable_Click(object sender, EventArgs e)
        {
            
        }

        public void refresh_emails()
        {
            Form1 form = new Form1();
            NameLable.Text = form.getFirstName();

            String connectionString = "datasource =localhost; port = 3306; username = root; password =";
            String mySQL = "SELECT `to`,`subject`,`emailBody` from email_client.email_archive where email_archive.from =" + new Form1().getID();
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(mySQL, connection);
            connection.Open();
            MySqlDataAdapter dtb = new MySqlDataAdapter(command);
            DataTable dtable = new DataTable();
            dtb.Fill(dtable);
            userEmails.DataSource = dtable;
            InitTimer();
        }

        public void InitTimer()
        {
            time = new Timer();
            time.Tick += new EventHandler(UserMenu_Load);
            time.Interval = 2000; // in miliseconds
            time.Start();
        }
    }
}
