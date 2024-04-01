using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Logic
{
    public class Staff
    {
        #region Instance variables
        private string _name;
        private string _username;
        private string _password;
        private int _empID;
        #endregion
        #region Constructor
        public Staff(string name, string username, string password, int empID) 
        {
            _name = name;
            _username = username;   
            _password = password;
            _empID = empID;
        }
        #endregion
        #region Property Methods
        public string name
        {
            get { return _name; }
        }
        public string username
        {
            get { return _username; }
        }
        public string password
        {
            get { return _password; }
        }
        public int empID
        {
            get
            {
                return _empID;
            }
        }
        #endregion
    }
}
