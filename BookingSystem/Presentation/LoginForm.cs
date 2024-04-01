using BookingSystem.Data;
using BookingSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class LoginForm : Form
    {
        #region Instance Variables
        private StaffController staffController;
        private Collection<Staff> staff;
        HotelDatabase hotelDatabase;
        private bool _loginSuccess = false;
        private string _name;
        #endregion

        #region Properties
        public bool loginSuccess
        {
            get { return _loginSuccess; }
        }
        public HotelDatabase HotelDatabase
        {
            get
            {
                return hotelDatabase;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        #endregion
        public LoginForm()
        {
            InitializeComponent();
            this.hotelDatabase = new HotelDatabase();
            staffController = new StaffController(hotelDatabase);
            staff = staffController.AllStaff;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
            pictureBoxHidden.Visible = false;
            pictureBoxSeen.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = this.ComputeSha256Hash(passwordTextBox.Text);
            Console.WriteLine(this.ComputeSha256Hash("admin123"));
            bool one = username.Equals(staff[0].username);
            bool two = password.Equals(staff[0].password);
            foreach (Staff member in staff)
            {
                if (username.Equals(member.username) && password.Equals(member.password))
                {
                    _name = member.name;
                    _loginSuccess = true;
                    this.Close();
                }
                
            }
            label4.Visible = true;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string ComputeSha256Hash(string rawData)
        {
            
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            { 
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
            
        }
        private void pictureBoxSeen_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
            pictureBoxHidden.Visible = true;
            pictureBoxSeen.Visible = false;
        }

        private void pictureBoxHidden_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
            pictureBoxHidden.Visible = false;
            pictureBoxSeen.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
