using BookingSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class HomeScreen : Form
    {
        private string staffName;
        private GuestController guestController;
        private Collection<Guest> guests;

        public HomeScreen(string staffName, GuestController guestController)
        {
            InitializeComponent();
            ShowAll(false);
            this.staffName = staffName;
            this.guestController = guestController;
            guests = guestController.AllGuests;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            messageLabel.Visible = true;
            messageTextBox.Visible = true;
            submitButton.Visible = true;
            cancelButton.Visible = true;
            subjectTextBox.Visible = true;
            subjectLabel.Visible = true;
        }
        private void ShowAll(bool value)
        {
            messageLabel.Visible = value;
            messageTextBox.Visible = value;
            submitButton.Visible = value;
            cancelButton.Visible = value;
            subjectTextBox.Visible = value;
            subjectLabel.Visible = value;
            messageTextBox.Text = string.Empty;
            subjectTextBox.Text = string.Empty;
            sendingLabel.Visible = value;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ShowAll(false);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            sendingLabel.Visible = true;
            this.Update();
            bool success = sendEmail();
            if (!success)
            {
                ShowAll(false);
                return;
            }
            MessageBox.Show("Emails successfully sent!");
            ShowAll(false);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello, " + staffName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool sendEmail()
        {
            bool success = false;
            try
            {
                success = true;
                string fromMail = "phulakamnandi@gmail.com";
                string fromPassword = "edeytmhkdekeqshq";
                foreach (Guest guest in guests)
                {

                    if (!(guest.email.Equals(string.Empty)))
                    {
                        MailMessage message = new MailMessage();
                        message.From = new MailAddress(fromMail);
                        message.Body = messageTextBox.Text;
                        message.Subject = subjectTextBox.Text;
                        message.To.Add(new MailAddress(guest.email));
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(message);
                        
                    }
                }
                return success;
            }
            catch (Exception ex)
            {
                success=false;
                MessageBox.Show("Failed to send email. Please retry.");
                return success;
            }
            
        }
    }
}
