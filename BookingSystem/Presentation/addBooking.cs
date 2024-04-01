using BookingSystem.Logic;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BookingSystem.Presentation
{
    public partial class addBooking : Form
    {
        public bool addBoookingFormClosed;
        private BookingController bookingController;
        private GuestController guestController;
        private FormStates state;
        private Booking booking;
        private Guest guest;
        private string checkIn;
        private string checkOut;
        public static readonly int NUM_ROOMS=5;
        private Booking.SeasonType seasonType;
        private int cost;
        private bool edit;
        public addBooking(GuestController guestController, BookingController bookingController)
        {
            InitializeComponent();
            this.guestController = guestController;
            this.bookingController = bookingController;
            this.FormClosed += addBooking_FormClosed;
            this.Activated += addBooking_Activated;
            this.Load += addBooking_Load;
            state = FormStates.Add;
        }

       

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        public void showAll(bool value)
        {
            GuestIDLabel.Visible = value;
            guestIDTextBox.Visible = value;
            CheckInLabel.Visible = true;
            CheckInDateTimePicker.Visible = true;
            CheckOutDateLabel.Visible = true;
            CheckOutDateTimePicker.Visible = true;
            NameLabel.Visible = value;
            SuburbLabel.Visible = value;
            PostalCodeLabel.Visible = value;
            CityLabel.Visible = value;
            StreetNameLabel.Visible = value;
            NameTextBox.Visible = value;
            NameTextBox.Visible = value;
            StrNameTextBox.Visible = value;
            SuburbTextBox.Visible = value;
            CityTextBox.Visible = value;
            PostCodeTextBox.Visible = value;
            searchButton.Visible = true;
            counterLabel.Visible = value;   
            FindGuestButton.Visible = value;
            newGuest.Visible = value;
            paymentLabel.Visible = value;
            nowButton.Visible = value;
            laterButton.Visible = value;
            cardNumLabel.Visible = value;
            cardNumTextBox.Visible = value;
            processPaymentButton.Visible = value;
            paymentSuccessLabel.Visible = value;
            submitBookingButton.Visible = value;
            depositLabel.Visible = value;
            phoneNumTextBox.Visible = value;
            phoneNumLabel.Visible = value;
            emailLabel.Visible = value;
            emailTextBox.Visible = value;
            balanceLabel.Visible = value;
            edit = false;
            errorLabel.Visible = value;
            invalidID.Visible = value;
            dateError.Visible = value;
            cancelButton.Visible = value;
        }

        public void PopulateGuest()
        {   
            string guestID = guestIDTextBox.Text;
            string name = NameTextBox.Text;
            string strName = StrNameTextBox.Text;
            string suburb = SuburbTextBox.Text;
            string city = CityTextBox.Text;
            int postCode = Convert.ToInt32(PostCodeTextBox.Text);
            string phone = phoneNumTextBox.Text;
            int amountOwing = cost;
            string email = emailTextBox.Text; 
            guest = new Guest(guestID, name, strName,suburb,city, postCode, phone,email, amountOwing);
        }

        private void addBooking_Load(object sender, EventArgs e)
        {
            showAll(false);
        }

        private void addBooking_Activated(object sender, EventArgs e)
        {
            showAll(false);
        }

        private void addBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            addBoookingFormClosed = true;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            cancelButton.Visible = true;
            CheckInDateTimePicker.Value = CheckInDateTimePicker.Value.Date;
            CheckOutDateTimePicker.Value = CheckOutDateTimePicker.Value.Date;
            if (CheckInDateTimePicker.Value.Date.CompareTo(CheckOutDateTimePicker.Value.Date) >= 0)
            {
                dateError.Visible = true;
                return;
            }
            dateError.Visible = false;
            checkIn = CheckInDateTimePicker.Value.Date.ToString();
            checkOut = CheckOutDateTimePicker.Value.Date.ToString();
            int numberBooked = bookingController.validateDate(checkIn, checkOut);
            bool valid =  numberBooked < NUM_ROOMS;
            int price;
            if (valid)
            {
                DateTime season = CheckInDateTimePicker.Value;
                if (DateTime.Parse("12/7/2023 00:00:00").CompareTo(season) >= 0)
                {
                    seasonType = Booking.SeasonType.LOW_SEASON;
                    price = 550;
                }
                else if (DateTime.Parse("12/16/2023 00:00:00").CompareTo(season) <= 0)
                {
                    seasonType = Booking.SeasonType.HIGH_SEASON;
                    price = 995;
                }
                else
                {
                    seasonType = Booking.SeasonType.MID_SEASON;
                    price = 750;
                }
                counterLabel.ForeColor = Color.DimGray;
                counterLabel.Text = "There are " + (NUM_ROOMS - numberBooked) + " available rooms on the chosen dates. The price per day is: R"+price;
                counterLabel.Visible = true;
                showGuestPrompt();
                
                switch (seasonType)
                {
                    case Booking.SeasonType.LOW_SEASON:
                        cost = 550;
                        break;
                    case Booking.SeasonType.MID_SEASON:
                        cost = 750;
                        break;
                    case Booking.SeasonType.HIGH_SEASON:
                        cost = 995;
                        break;
                }
                int value = (CheckOutDateTimePicker.Value - CheckInDateTimePicker.Value).Days;
                cost = cost * value;
            }
            else
            {
                counterLabel.ForeColor = Color.Red;
                counterLabel.Text = "There are no rooms available on the chosen dates. Please choose new dates.";
                counterLabel.Visible= true;
            }
        }
      
        private void clearAll()
        {
            guestIDTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            SuburbTextBox.Text = string.Empty;
            StrNameTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            cardNumTextBox.Text = string.Empty;
            phoneNumTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            PostCodeTextBox.Text = string.Empty;
        }

        private void guestIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void showGuestPrompt()
        {
            GuestIDLabel.Visible = true;
            guestIDTextBox.Visible = true;
            FindGuestButton.Visible = true;
        }

        private void FindGuestButton_Click(object sender, EventArgs e)
        {
            if (!validateGuestID())
            {
                invalidID.Visible = true;
                return;
            }
            invalidID.Visible = false;
            Guest checkExisting = guestController.Find(guestIDTextBox.Text);
            if (checkExisting != null)
            {
                if (checkExisting.amountOwing+cost < 10000)
                {
                    balanceLabel.Visible = false;
                    guest = checkExisting;
                    NameLabel.Visible = true;
                    NameTextBox.Text = guest.name;
                    NameTextBox.Visible = true;
                    NameTextBox.Enabled = false;
                    paymentLabel.Visible = true;
                    nowButton.Visible = true;
                    laterButton.Visible = true;
                    depositLabel.Text = "Deposit Amount: R" + (0.1 * cost);
                    depositLabel.Visible = true;
                    edit = true;
                }
                else
                {
                    showAll(false);
                    guestIDTextBox.Visible = true;
                    GuestIDLabel.Visible=true;
                    FindGuestButton.Visible=true;
                    balanceLabel.Visible = true;
                }
               
            }
            else
            {
                newGuest.Visible = true;
                NameLabel.Visible = true;
                NameTextBox.Enabled = true;
                NameTextBox.Visible = true;
                StreetNameLabel.Visible = true;
                StrNameTextBox.Visible = true;
                SuburbLabel.Visible = true;
                SuburbTextBox.Visible = true;
                CityLabel.Visible = true;
                CityTextBox.Visible = true;
                PostalCodeLabel.Visible = true;
                PostCodeTextBox.Visible = true;
                phoneNumLabel.Visible = true;
                phoneNumTextBox.Visible = true;
                emailLabel.Visible = true;
                emailTextBox.Visible = true;
                paymentLabel.Visible = true;
                nowButton.Visible = true;
                laterButton.Visible = true;
                depositLabel.Text = "Deposit Amount: R" + (0.1 * cost);
                depositLabel.Visible = true;
            }
            
        }

        private void submitBookingButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Enabled) //if new guest
            {
                bool valid = true && validateStrings() && validatePhoneAndPostCode(phoneNumTextBox.Text,PostCodeTextBox.Text);
                if (!valid)
                {
                    errorLabel.Visible = true;
                    return;
                }
                PopulateGuest();
                guestController.DataMaintenance(guest, Data.Database.DBOperation.Add);
                guestController.FinalizeChanges();
            }
            else if (edit)
            {
                guest.amountOwing = guest.amountOwing + cost;
                guestController.DataMaintenance(guest, Data.Database.DBOperation.Edit);
                guestController.FinalizeChanges();
            }
            booking.guest = guestController.Find(guestIDTextBox.Text);
            bookingController.DataMaintenance(booking, Data.Database.DBOperation.Add);
            bookingController.FinalizeChanges();
            showAll(false);
            MessageBox.Show(GenerateOutputString());
            clearAll();
        }

        private void nowButton_Click(object sender, EventArgs e)
        {
            cardNumLabel.Visible = true;
            cardNumTextBox.Visible = true;
            processPaymentButton.Visible = true;
        }

        private void processPaymentButton_Click(object sender, EventArgs e)
        {
            cost = cost - (int) (cost * 0.1);
            paymentSuccessLabel.Visible = true;
            submitBookingButton.Visible = true;
            booking = new Booking(guest, checkIn, checkOut, seasonType, bookingController.generateNumber(), "Confirmed");
        }

        private void laterButton_Click(object sender, EventArgs e)
        {
            submitBookingButton.Visible = true;
            booking = new Booking(guest, checkIn, checkOut, seasonType, bookingController.generateNumber(), "Unconfirmed");
        }
        private string GenerateOutputString()
        {
            return "Booking has been placed for: "+guest.name+".\nReservation Number: "+booking.id+".\nCheck In Date: "+booking.checkIn+".\nCheck Out Date: "+booking.checkOut+".\nAmount owing for stay: R"+ cost+".\nStatus: "+booking.status;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool validateStrings()
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9 ]+$");
            return regex.IsMatch(NameTextBox.Text)&&regex.IsMatch(StrNameTextBox.Text)&&regex.IsMatch(SuburbTextBox.Text) && regex.IsMatch(CityTextBox.Text) && (emailTextBox.Text.Equals("") || emailTextBox.Text.EndsWith(".com")||emailTextBox.Text.EndsWith(".za"));
        }
        private bool validatePhoneAndPostCode(string num, string postcode)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return num[0] == '0' && num.Length == 10 && regex.IsMatch(num) &&regex.IsMatch(postcode);
        }
        private bool validateGuestID()
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return guestIDTextBox.Text.Length==13 && regex.IsMatch(guestIDTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            showAll(false);
            clearAll();
        }

        private void paymentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
