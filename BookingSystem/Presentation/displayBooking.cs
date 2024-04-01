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

namespace BookingSystem.Presentation
{
    public partial class displayBooking : Form
    {
        #region Instance variables
        public bool displayBookingFormClosed;
        private GuestController guestController;
        private BookingController bookingController;
        private Guest guest;
        private Booking booking;
        private FormStates state;

        #endregion
        public displayBooking(GuestController guestController, BookingController bookingController)
        {
            InitializeComponent();
            this.guestController = guestController;
            this.bookingController = bookingController;
            this.Activated += displayBooking_Activated;
            this.Load += displayBooking_Load;
            ShowAll(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowAll(bool value)
        {
            errorLabel.Visible = value;
            DetailsListView.Visible = value;
            invalidLabel.Visible = value;
        }

        private void checkDetailsButton_Click(object sender, EventArgs e)
        {
            DetailsListView.Visible = false;
            state = FormStates.View;
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(resIDtextBox.Text))
            {
                invalidLabel.Visible = true;
                errorLabel.Visible = false;
                return;
            }
            int number = Convert.ToInt32(resIDtextBox.Text);
            booking = bookingController.Find(number);
            if (booking == null)
            {
                invalidLabel.Visible = false;
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
                invalidLabel.Visible = false;
                setUpListView();
                DetailsListView.Visible = true;
            }

        }

        private void displayBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            displayBookingFormClosed = true;
        }

        private void displayBooking_Load(object sender, EventArgs e)
        {
            this.DetailsListView.View = View.Details;
        }

        private void displayBooking_Activated(object sender, EventArgs e)
        {
            this.DetailsListView.View = View.Details;
        }

        private void DetailsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setUpListView()
        {
            ListViewItem bookingDetails;
            this.DetailsListView.Clear();
            this.DetailsListView.Columns.Insert(0, "Reservation ID", 120, HorizontalAlignment.Left);
            this.DetailsListView.Columns.Insert(1, "Guest ID", 120, HorizontalAlignment.Left);
            this.DetailsListView.Columns.Insert(2, "Name", 120, HorizontalAlignment.Left);
            this.DetailsListView.Columns.Insert(3, "Season Type", 120, HorizontalAlignment.Left);
            this.DetailsListView.Columns.Insert(4, "Check In Date", 120, HorizontalAlignment.Left);
            this.DetailsListView.Columns.Insert(5, "Check Out Date", 120, HorizontalAlignment.Left);
            this.DetailsListView.Columns.Insert(6, "Status", 120, HorizontalAlignment.Left);
            bookingDetails = new ListViewItem();
            bookingDetails.Text = booking.id.ToString();
            bookingDetails.SubItems.Add(booking.guest.id.ToString());
            bookingDetails.SubItems.Add(booking.guest.name.ToString());
            bookingDetails.SubItems.Add(booking.seasonType.ToString());
            bookingDetails.SubItems.Add(DateTime.Parse(booking.checkIn).ToShortDateString());
            bookingDetails.SubItems.Add(DateTime.Parse(booking.checkOut).ToShortDateString());
            bookingDetails.SubItems.Add(booking.status.ToString());
            this.DetailsListView.Items.Add(bookingDetails);
            this.DetailsListView.GridLines = false;
            this.DetailsListView.Refresh();
        }
    }
}