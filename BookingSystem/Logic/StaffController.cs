using BookingSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Logic
{
    public class StaffController
    {
        #region Instance Variables
        private HotelDatabase hotelDatabase;
        private Collection <Staff> staff;
        #endregion

        #region Constructor
        public StaffController(HotelDatabase hotelDatabase)
        {
            this.hotelDatabase= hotelDatabase;
            staff = hotelDatabase.AllStaff;
        }
        #endregion
        #region Property Methods
        public Collection<Staff> AllStaff
        {
            get
            {
                return staff;
            }
        }
        #endregion
    }
}
