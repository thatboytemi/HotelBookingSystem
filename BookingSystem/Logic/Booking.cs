using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Logic
{
    public class Booking
    {
        #region Season Type Enum
        public enum SeasonType
        {
            LOW_SEASON=1, 
            MID_SEASON=2,
            HIGH_SEASON=3
        }
        #endregion
        #region Instance variables
        private Guest _guest;
        private string _checkIn;
        private string _checkOut;
        private SeasonType _seasonType;
        private int _id;
        private string _status;
        #endregion
        #region Constructor
        public Booking(Guest guest, string checkIn, string checkOut, SeasonType seasonType, int id, string status)
        {
            _guest = guest;
            _checkIn = checkIn;
            _checkOut = checkOut;
            _seasonType = seasonType;
            _id = id;
            _status = status;
        }
        #endregion
        #region Accessor and Mutator methods
        public Guest guest
        {
            get { return _guest; }
           set { _guest = value; }
        }
        public string checkIn
        { 
            get { return _checkIn; } 
            set { _checkIn = value; }
        }
        public string checkOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }
        public SeasonType seasonType
        {
            get { return _seasonType; }
            set { _seasonType = value; }
        }
        public int id
        {
            get { return _id; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

    }
}
