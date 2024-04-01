using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Logic
{
    public class BookingController
    {
        #region Instance variables
        private HotelDatabase hotelDatabase;
        private Collection<Booking> bookings;
        #endregion
        #region Property methods
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion
        #region Constructor
        public BookingController(HotelDatabase hotelDatabase)
        {
            this.hotelDatabase = hotelDatabase;
            bookings= hotelDatabase.AllBookings;
        }
        #endregion
        #region Database Communication
        public void DataMaintenance(Booking booking, Database.DBOperation operation)
        {
            int index = -1;
            hotelDatabase.BookingDataSetChange(booking, operation);
            switch (operation)
            {
                case Database.DBOperation.Add:
                    bookings.Add(booking);
                    break;
                case Database.DBOperation.Edit:
                    index = FindIndex(booking);
                    bookings.RemoveAt(index);
                    bookings.Insert(index, booking);
                    break;
                case Database.DBOperation.Delete:
                    index = FindIndex(booking);
                    bookings.RemoveAt(index);
                    break;
            }
        }
        public bool FinalizeChanges()
        {
            return hotelDatabase.UpdateBookingDataSource();
        }
        #endregion
        #region Search Methods
        public int FindIndex(Booking booking)// method that finds the index of a booking
        {
            int counter = 0;
            bool found = false;
            found = (booking.id == bookings[counter].id);
            while (!(found) && (counter < bookings.Count - 1))
            {
                counter++;
                found = (booking.id == bookings[counter].id);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }

        }
        public Booking Find(int ID) //method that finds a booking object, given the reservation number
        {
            bool found = false;
            int index = -1;
            for (int i = 0; i < bookings.Count; i++)
            {
                if (bookings[i].id == ID)
                {
                    found = true;
                    index = i; break;
                }
            }
            return found ? bookings[index] : null;
        }
        #endregion
        public int validateDate(string checkInString, string checkOutString) //method that indicates whether occupancy is over the threshold for the date user has chosen
        {
            DateTime checkIn =  DateTime.Parse(checkInString);
            DateTime checkOut = DateTime.Parse(checkOutString);
            int counter = 0;
            DateTime storedCheckIn;
            DateTime storedCheckOut;
            foreach(Booking booking in bookings)
            {
                storedCheckIn = DateTime.Parse(booking.checkIn);
                storedCheckOut = DateTime.Parse(booking.checkOut);
                if ((storedCheckIn.CompareTo(checkIn) <= 0 && storedCheckOut.CompareTo(checkIn) > 0)||(storedCheckIn.CompareTo(checkOut) < 0 && storedCheckOut.CompareTo(checkOut) > 0)||(checkIn.CompareTo(storedCheckIn) <= 0 && checkOut.CompareTo(storedCheckOut) >= 0))
                {
                    counter++;
                }
            }
            return counter;

        }
        public int generateNumber()
        {
            int number = 0;
            foreach(Booking booking in bookings)
            {
                if (booking.id > number)
                {
                    number= booking.id;
                }
            }
            return number+1;
        }


    }
}
