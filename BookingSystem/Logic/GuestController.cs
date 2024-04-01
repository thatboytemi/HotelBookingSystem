using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Logic
{
    public class GuestController
    {
        #region Instance variables
        private HotelDatabase hotelDatabase;
        private Collection<Guest> guests;
        #endregion
        #region Property methods
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion
        #region Constructor
        public GuestController(HotelDatabase hotelDatabase)
        {
            this.hotelDatabase = hotelDatabase;
            guests = hotelDatabase.AllGuests;
        }
        #endregion
        #region Database Communication
        public void DataMaintenance(Guest guest, Database.DBOperation operation)
        {
            int index = -1;
            hotelDatabase.GuestDataSetChange(guest, operation);
            switch (operation)
            {
                case Database.DBOperation.Add:
                    guests.Add(guest);
                    break;
                case Database.DBOperation.Edit:
                    index = FindIndex(guest);
                    guests.RemoveAt(index);
                    guests.Insert(index, guest);
                    break;
                case Database.DBOperation.Delete:
                    index = FindIndex(guest);
                    guests.RemoveAt(index);
                    break;
            }
        }
        public bool FinalizeChanges()
        { 
            return hotelDatabase.UpdateGuestDataSource();
        }
        #endregion
 
        #region Search Methods
        public int FindIndex(Guest guest)// method that finds the index of a guest
        {
            int counter = 0;
            bool found = false;
            found = (guest.id == guests[counter].id);
            while (!(found) && (counter < guests.Count - 1))
            {
                counter++;
                found = (guest.id == guests[counter].id);
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
        public Guest Find(string ID) //method that finds a guest object, given the guestID
        {
            bool found = false;
            int index = -1;
            for(int i = 0; i < guests.Count; i++)
            {
                if (guests[i].id == ID) { 
                    found = true;
                    index = i; break;
                }
            }
            return found ? guests[index] : null;
        }


        #endregion

    }

}
