using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace MailClient
{
    public partial class NewMessage : Form
    {
        public NewMessage()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            String from, pass, to, subject, messageBody;
            MailMessage message = new MailMessage();
            from = "put here your email";
            pass = "put here your password";
            to = ToTextBox.Text;
            subject = SubjectTextBox.Text;
            messageBody = MessageEmailBox.Text;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "From : "+ form.getFirstName()+" "+form.getLastName() + "<br>Message: " + messageBody;
            message.Subject = subject;
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("the mail was sent");
                archive(new Form1().getID(), to, subject, messageBody);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageEmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameLable_Click(object sender, EventArgs e)
        {

        }

        private void NewMessage_Load(object sender, EventArgs e)
        {
            
            NameLable.Text = form.getFirstName();
        }
        private void archive(int ID, String to, String subject, String messageBody) {
            try {
                String connectionString = "datasource =localhost; port = 3306; username = root; password =";
                String mySQL = ("INSERT INTO email_client.email_archive (`from`, `to`, `subject`, `emailBody`) VALUES (" + ID + ", '" + to +"', '" + subject +"' , '" + messageBody +"')");
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(mySQL, connection);
                connection.Open();
                MySqlDataAdapter dtb = new MySqlDataAdapter(command);
                DataSet dtable = new DataSet();
                dtb.Fill(dtable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
