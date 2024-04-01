using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Logic
{
    public class Guest
    {
        #region Instance variables
        private string _id; 
        private string _name;
        private string _streetName;
        private string _suburb;
        private string _city;
        private int _postalCode;
        private string _phone;
        private string _email;
        private int _amountOwing;
        #endregion
        #region Constructor
        public Guest(string id, string name, string streetName, string suburb, string city, int postalCode, string phone, string email, int amountOwing)
        {
            _id = id;
            _name = name;
            _streetName = streetName;
            _city = city;
            _postalCode = postalCode;
            _suburb = suburb;
            _phone = phone;
            _email = email;
            _amountOwing = amountOwing;
        }
        #endregion
        #region Accessors and Mutators
        public string id //no mutator method, ID cannot be changed
        {
            get { return _id; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string streetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }
        public string city
        {
                get { return _city; }
                set { _city = value; }
        }
        public int postalCode
        {
                get { return _postalCode; }
                set { _postalCode = value; }
        }
        public string suburb
        {
            get { return _suburb; } 
            set { _suburb = value; }
        }
        public string phone
        {
            get { return _phone; }
            set {_phone = value; }
        }
        public string email
        {
            get
            {
                return _email;
            }
            set { _email = value; }
        }
        public int amountOwing
        {
            get { return _amountOwing; }
            set { _amountOwing = value; }
        }
        #endregion
    }
}
