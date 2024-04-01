using BookingSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingSystem.Logic.Booking;

namespace BookingSystem.Presentation
{
    public partial class ManageBooking : Form
    {
        #region Instance variables
        public bool manageBookingFormClosed;
        private GuestController guestController;
        private BookingController bookingController;
        private Guest guest;
        private Booking booking;
        private FormStates state;
        public static readonly int NUM_ROOMS = 5;
        private string checkIn;
        private string checkOut;
        private int cost;
     
        #endregion
        public ManageBooking(GuestController guestController, BookingController bookingController)
        {
            InitializeComponent();
            this.guestController = guestController;
            this.bookingController = bookingController;
            this.Load += ManageBooking_Load;
            this.Activated += ManageBooking_Activated;
            this.FormClosed += ManageBooking_FormClosed;
            state = FormStates.View;
        }
        #region Events

        private void ManageBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            manageBookingFormClosed = true;
        }

        private void ManageBooking_Activated(object sender, EventArgs e)
        {
            ShowAll(false);
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {
            ShowAll(false);
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #region Utility Methods
        public void ShowAll(bool value)
        {
            SearchButton.Visible = value;
            ResNumberLabel.Visible = value;
            ResNumTextBox.Visible = value;
            ResErrorLabel.Visible = value;
            IDLabel.Visible = value;
            IDTextBox.Visible = value;
            NameLabel.Visible = value;
            NameTextBox.Visible = value;
            CheckInDateLabel.Visible = value;
            dateTimePicker1.Visible = value;
            CheckOutDateLabel.Visible = value;
            dateTimePicker2.Visible = value;
            DateErrorLabel.Visible = value;
            SubmitButton.Visible = value;
            errorLabel2.Visible = value;
            dateError.Visible= value;
            durationError.Visible = value;
            cancelButton.Visible = value;
            invalidLabel.Visible = value;
        }



        #endregion

        private void UpdateBookingButton_Click(object sender, EventArgs e)
        {
            cancelButton.Visible = true;
            state = FormStates.Edit;
            SearchButton.Visible = true;
            ResNumberLabel.Visible = true;
            ResNumTextBox.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(ResNumTextBox.Text))
            {
                ShowAll(false);
                invalidLabel.Visible = true;
                cancelButton.Visible = true;
                SearchButton.Visible = true;
                ResNumberLabel.Visible = true;
                ResNumTextBox.Visible = true;
                ResErrorLabel.Visible = false;
                return;
            }
            int number = Convert.ToInt32(ResNumTextBox.Text);
            booking = bookingController.Find(number);
            if (booking == null)
            {
                ShowAll(false);
                invalidLabel.Visible = false;
                ResErrorLabel.Visible = true;
                cancelButton.Visible = true;
                SearchButton.Visible = true;
                ResNumberLabel.Visible = true;
                ResNumTextBox.Visible = true;
            }
            else
            {
                invalidLabel.Visible = false;
                ResErrorLabel.Visible = false;
                IDLabel.Visible = true;
                IDTextBox.Text = booking.guest.id;
                IDTextBox.Visible = true;
                IDTextBox.Enabled = false;

                NameLabel.Visible = true;
                NameTextBox.Text = booking.guest.name;
                NameTextBox.Visible = true;
                NameTextBox.Enabled = false;
                if (state == FormStates.Edit)
                {
                    CheckInDateLabel.Visible = true;
                    dateTimePicker1.Visible = true;
                    CheckOutDateLabel.Visible = true;
                    dateTimePicker2.Visible = true;
                }
                SubmitButton.Visible = true;
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (state == FormStates.Edit)
            {
                checkIn = dateTimePicker1.Value.Date.ToString();
                checkOut = dateTimePicker2.Value.Date.ToString();
                if (dateTimePicker1.Value.Date.CompareTo(dateTimePicker2.Value.Date) >= 0)
                {
                    dateError.Visible = true;
                    return;
                }
                dateError.Visible = false;
                bool valid = bookingController.validateDate(checkIn, checkOut) < NUM_ROOMS;
                int seasonType = 0;
                
                if (DateTime.Parse("12/7/2023 00:00:00").CompareTo(dateTimePicker1.Value.Date) >= 0)
                {
                    seasonType = 1;
                    
                }
                else if (DateTime.Parse("12/16/2023 00:00:00").CompareTo(dateTimePicker1.Value.Date) <= 0)
                {
                    seasonType =3;
                    
                }
                else
                {
                    seasonType = 2;
                    
                }
                
                if (seasonType != (int) booking.seasonType)
                {
                    errorLabel2.Visible = true;
                    state = FormStates.Edit;
                    return;
                }
                if (!((dateTimePicker2.Value.Date - dateTimePicker1.Value.Date).Days == (DateTime.Parse(booking.checkOut) - DateTime.Parse(booking.checkIn)).Days))
                {
                    durationError.Visible = true;
                    return;
                }
                else if (valid)
                {
                    durationError.Visible = false;
                    
                    this.PopulateObject();
                    this.ClearAll();
                    bookingController.DataMaintenance(booking, Data.Database.DBOperation.Edit);
                    bookingController.FinalizeChanges();
                    MessageBox.Show("Changes added to database.");
                }
                else
                {
                    durationError.Visible = false;
                    DateErrorLabel.Visible = true;
                }
                state = FormStates.View;
            }
            else
            {
                if (DateTime.Parse("12/7/2023 00:00:00").CompareTo(DateTime.Parse(booking.checkIn)) >= 0)
                {
                    cost = 550;
                }
                else if (DateTime.Parse("12/16/2023 00:00:00").CompareTo(DateTime.Parse(booking.checkOut)) <= 0)
                {
                    cost = 995;
                }
                else
                {
                    cost = 750;
                }

                cost = cost * (DateTime.Parse(booking.checkOut) - DateTime.Parse(booking.checkIn)).Days;
                guest = booking.guest;
                guest.amountOwing = guest.amountOwing - cost;
                guestController.DataMaintenance(guest, Data.Database.DBOperation.Edit);
                guestController.FinalizeChanges();
                bookingController.DataMaintenance(booking, Data.Database.DBOperation.Delete);
                bookingController.FinalizeChanges();
                this.ClearAll();
                MessageBox.Show("Booking deleted.");
                state = FormStates.View;
            }
            
        }

        public void PopulateObject()
        {
            booking.checkIn = checkIn;
            booking.checkOut = checkOut;
        }
        public void ClearAll()
        {
            IDTextBox.Text = string.Empty;
            NameTextBox.Text= string.Empty;
            ResNumTextBox.Text = string.Empty;
            this.ShowAll(false);
        }

        private void DeleteBookingButton_Click(object sender, EventArgs e)
        {
            cancelButton.Visible = true;
            state = FormStates.Delete;
            SearchButton.Visible = true;
            ResNumberLabel.Visible = true;
            ResNumTextBox.Visible = true;
        }

        private void ManageBooking_Activated_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            ShowAll(false);
        }
    }
}
