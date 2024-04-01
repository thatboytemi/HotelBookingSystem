using BookingSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingSystem.Logic.Booking;

namespace BookingSystem.Presentation
{
    public partial class SalesReport : Form
    {
        #region Instance variables
        private BookingController bookingController;
        public bool salesReportFormClosed;
        #endregion
        public SalesReport(BookingController bookingController)
        {
            InitializeComponent();
            this.bookingController = bookingController;
            salesReportFormClosed = false;
            clear();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {

        }
        private void SalesReport_FormClosed(object sender, EventArgs e)
        {
            salesReportFormClosed = true;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            clear();
            DateTime date = dateTimePicker1.Value.Date;
            int value = 0;
            int confirmed = 0;
            int unconfirmed = 0;
            int result = 0;
            if (DateTime.Parse("12/7/2023 00:00:00").CompareTo(date) >= 0)
            {
                value = 550;
            }
            else if (DateTime.Parse("12/16/2023 00:00:00").CompareTo(date) <= 0)
            {
                value = 995;
            }
            else
            {
                value = 750;
            }
            foreach(Booking booking in bookingController.AllBookings)
            {
                DateTime checkIn = DateTime.Parse(booking.checkIn);
                DateTime checkOut = DateTime.Parse(booking.checkOut);
                if (date.CompareTo(checkIn)>=0&&date.CompareTo(checkOut)<0) 
                {
                    if (booking.status.TrimEnd().Equals("Confirmed"))
                    {
                        confirmed++;
                    }
                    else
                    {
                        unconfirmed++;
                    }
                    result += value;
                }
               
            }
            if (confirmed+unconfirmed==0)
            {
                clear();
                errorLabel.Visible = true;
            }
            else
            {
                chart1.Series["PieChart"].Points.Clear();
                figure.Text = "R"+ result;
                if (confirmed > 0)
                {
                    chart1.Series["PieChart"].Points.AddXY("Confirmed", Convert.ToString(confirmed));
                }
                if(unconfirmed > 0) 
                {
                    chart1.Series["PieChart"].Points.AddXY("Unconfirmed", Convert.ToString(unconfirmed));
                }
                title.Visible = true;
                salesLabel.Visible = true;
                figure.Visible = true;
                chart1.Visible = true; 
            }
        }
        private void clear()
        {
            chart1.Visible= false;
            salesLabel.Visible= false;
            title.Visible= false;
            errorLabel.Visible= false;
            figure.Visible= false;
        }

        private void salesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
