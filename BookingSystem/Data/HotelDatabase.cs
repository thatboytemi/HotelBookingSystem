using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Logic;

namespace BookingSystem.Data
{
    public class HotelDatabase:Database
    {
        #region Instance variables
        private string table1 = "Guests";
        private string sqlLocal1 = "SELECT * FROM Guests";
        private string table2 = "Booking";
        private string sqlLocal2 = "SELECT * FROM Booking";
        private string table3 = "Staff"; //left out SQL queries for this table as it is out of scope
        private string sqlLocal3 = "SELECT * FROM Staff";
        private Collection <Booking> bookings;
        private Collection <Guest> guests;
        private Collection<Staff> staff;
        #endregion
        #region Accessor Method: Guest
        public Guest getGuest(string id)
        {
            foreach(Guest guest in guests)
            { 
                if(guest.id == id)
                {
                    return guest;
                }
            }
            return null;
        }
        #endregion

        #region Property Method: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        public Collection<Staff> AllStaff
        {
            get
            {
                return staff;
            }
        }
        #endregion
        #region Constructor
        public HotelDatabase() : base()
        {
            bookings = new Collection<Booking>();
            guests = new Collection<Guest>();
            staff= new Collection<Staff>(); 
            FillDataSet(sqlLocal1, table1);
            Add2GuestCollection(table1);
            FillDataSet(sqlLocal2, table2);
            Add2BookingCollection(table2);
            FillDataSet(sqlLocal3, table3);
            Add2StaffCollection(table3);
        }
        #endregion
        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2GuestCollection(string table)
        {
            DataRow myRow = null;
            string id;
            string name;
            int streetNo;
            string streetName;
            string suburb;
            string city;
            int postalCode;
            string phone;
            string email;
            int amountOwing;
            Guest guest;
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                myRow = row;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    id = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    name = Convert.ToString(myRow["Name"]).TrimEnd();
                    streetName = Convert.ToString(myRow["StreetName"]).TrimEnd();
                    suburb = Convert.ToString(myRow["Suburb"]).TrimEnd();
                    city = Convert.ToString(myRow["City"]).TrimEnd();
                    postalCode = Convert.ToInt32(myRow["PostalCode"]);
                    phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    email = Convert.ToString(myRow["Email"]).TrimEnd();
                    amountOwing = Convert.ToInt32(myRow["AmountOwing"]);
                    guest = new Guest(id, name, streetName, suburb,city, postalCode,phone,email, amountOwing);
                    guests.Add(guest);
                }
            }
        }
        private void Add2BookingCollection(string table)
        {
            DataRow myRow = null;
            Booking booking;
            string checkIn;
            string checkOut;
            Booking.SeasonType seasonType;
            Guest guest;
            string status;
            int id;
            foreach (DataRow row in dsMain.Tables[table].Rows) 
            {
                myRow= row;
                if(!(myRow.RowState== DataRowState.Deleted))
                {
                    guest = this.getGuest(Convert.ToString(myRow["GuestID"]).TrimEnd());
                    checkIn = Convert.ToString(myRow["CheckInDate"]);
                    checkOut = Convert.ToString(myRow["CheckOutDate"]);
                    seasonType = (Booking.SeasonType) Convert.ToByte(myRow["SeasonType"]);
                    id = Convert.ToInt32(myRow["ReservationID"]);  
                    status = Convert.ToString(myRow["Status"]);
                    booking = new Booking(guest, checkIn, checkOut, seasonType, id, status);
                    bookings.Add(booking);
                }
            }
        }
        private void Add2StaffCollection(string table)
        {
            DataRow myRow = null;
            string name;
            string username;
            string password;
            int empID;
            Staff staffMember;
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                myRow = row;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    name = Convert.ToString(myRow["Name"]);
                    username = Convert.ToString(myRow["Username"]);
                    password = Convert.ToString(myRow["Password"]);
                    empID = Convert.ToInt32(myRow["EMPID"]);
                    staffMember = new Staff(name, username, password,empID);  
                    staff.Add(staffMember);
                }

               
            }
        }
        private void FillGuestRow(DataRow row, Guest guest, Database.DBOperation operation)
        {
            if(operation==Database.DBOperation.Add)
            {
                row["GuestID"] = guest.id;
            }
            row["Name"] = guest.name;
            row["StreetName"] = guest.streetName;
            row["Suburb"] = guest.suburb;
            row["City"] = guest.city;
            row["PostalCode"] = guest.postalCode;
            row["Phone"] = guest.phone;
            row["Email"] = guest.email;
            row["AmountOwing"] = guest.amountOwing;
        }
        private void FillBookingRow(DataRow row, Booking booking, Database.DBOperation operation)
        {
            if (operation == Database.DBOperation.Add)
            {
                row["ReservationID"] = booking.id;
            }
            row["CheckInDate"] = booking.checkIn;
            row["CheckOutDate"] = booking.checkOut;
            row["SeasonType"] =(int) booking.seasonType;
            row["GuestID"] = booking.guest.id;
            row["Status"] = booking.status;
        }
        private int FindGuestRow(Guest guest, String table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (guest.id.Equals(Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"]).TrimEnd()))
                    {
                        returnValue = rowIndex;
                    }

                }
                rowIndex++;
            }
            return returnValue;
        }
        private int FindBookingRow(Booking booking, String table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (booking.id == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["ReservationID"]))
                    {
                        returnValue = rowIndex;
                    }

                }
                rowIndex++;
            }
            return returnValue;
        }

        #endregion
        #region Database Operations CRUD
        public void GuestDataSetChange(Guest guest, Database.DBOperation operation)
        {
            DataRow row = null;
            string table = table1;
            switch (operation)
            {
                case Database.DBOperation.Add:
                    row = dsMain.Tables[table].NewRow();
                    FillGuestRow(row, guest, operation);
                    dsMain.Tables[table].Rows.Add(row); //Add to the dataset
                    break;
                case Database.DBOperation.Edit:
                    row = dsMain.Tables[table].Rows[FindGuestRow(guest, table)];
                    FillGuestRow(row, guest, operation);
                    break;
                case Database.DBOperation.Delete:
                    row = dsMain.Tables[table].Rows[FindGuestRow(guest, table)];
                    row.Delete();
                    break;
            }
        }
        public void BookingDataSetChange(Booking booking, Database.DBOperation operation)
        {
            DataRow row = null;
            string table = table2;
            switch (operation)
            {
                case Database.DBOperation.Add:
                    row = dsMain.Tables[table].NewRow();
                    FillBookingRow(row, booking, operation);
                    dsMain.Tables[table].Rows.Add(row); //Add to the dataset
                    break;
                case Database.DBOperation.Edit:
                    row = dsMain.Tables[table].Rows[FindBookingRow(booking, table)];
                    FillBookingRow(row, booking, operation);
                    break;
                case Database.DBOperation.Delete:
                    row = dsMain.Tables[table].Rows[FindBookingRow(booking, table)];
                    row.Delete();
                    break;
            }
        }
        #endregion
        #region Build Parameters, Create Commands & Update Database
        private void Create_Guest_Insert_Command()
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Guests(GuestID, Name, StreetName, Suburb, City, PostalCode, Phone, Email, AmountOwing) VALUES (@ID, @Name, @StreetName, @Suburb, @City, @PostalCode, @Phone, @Email, @AmountOwing)",cnMain);
            Build_Guest_Insert_Parameters();
        }
        private void Build_Guest_Insert_Parameters() //for now, only adding functionality to insert a guest. Will add additional functionality if necessary.
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ID", SqlDbType.NChar, 13, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 40, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StreetName", SqlDbType.NVarChar, 40, "StreetName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Suburb", SqlDbType.NVarChar, 20, "Suburb");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@City", SqlDbType.NVarChar, 20, "City");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PostalCode", SqlDbType.Int,4, "PostalCode");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AmountOwing", SqlDbType.Int, 4, "AmountOwing");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 10, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);
        }
        private void Create_Booking_Insert_Command()
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Booking(ReservationID, GuestID, CheckInDate, CheckOutDate, SeasonType, Status) VALUES (@ReservationNumber, @GuestID, @CheckIn, @CheckOut, @SeasonType, @Status)", cnMain);
            Build_Booking_Insert_Parameters();
        }
        private void Build_Booking_Insert_Parameters() 
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ReservationNumber", SqlDbType.NVarChar, 15, "ReservationID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 100, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SeasonType", SqlDbType.TinyInt, 100, "SeasonType");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckIn", SqlDbType.DateTime, 100, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOut", SqlDbType.DateTime, 100, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NChar, 50, "Status");
            daMain.InsertCommand.Parameters.Add(param);
        }
        private void Create_Booking_Update_Command()
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET CheckInDate=@CheckIn, CheckOutDate=@CheckOut, SeasonType=@SeasonType WHERE ReservationID=@Original_ResNumber", cnMain);
            Build_Booking_Update_Parameters();
        }
        private void Create_Guest_Update_Command()
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Guests SET AmountOwing=@AmountOwing WHERE GuestID=@Original_ID", cnMain);
            Build_Guest_Update_Parameters();
        }
        private void Build_Guest_Update_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AmountOwing", SqlDbType.Int, 100, "AmountOwing");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }
        private void Build_Booking_Update_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Original_ResNumber", SqlDbType.NVarChar, 15, "ReservationID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@Original_GuestID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@CheckIn", SqlDbType.DateTime, 100, "CheckInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@CheckOut", SqlDbType.DateTime, 15, "CheckOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
            param = new SqlParameter("@SeasonType", SqlDbType.TinyInt, 1, "SeasonType");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }
        private void Create_Booking_Delete_Command()
        {
            string errorString = null;
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE ReservationID = @ReservationNumber",cnMain);
            try
            {
                Build_Booking_Delete_Parameters();
            }
            catch (Exception ex)
            {
                errorString = ex.Message + " " + ex.StackTrace;
            }
        }
        private void Build_Booking_Delete_Parameters()
        {
            SqlParameter param = new SqlParameter("@ReservationNumber", SqlDbType.NVarChar, 15, "ReservationID");
            daMain.DeleteCommand.Parameters.Add(param);
        }
        public bool UpdateGuestDataSource()
        {
            bool success = false;
            string errorString;
            try
            {
                Create_Guest_Insert_Command();
                Create_Guest_Update_Command();
                UpdateDataSource(sqlLocal1, table1);
                success = true;
            }
            catch (Exception ex)
            {
                errorString = ex.Message + " " + ex.StackTrace;
            }
            return success;
        }
        public bool UpdateBookingDataSource()
        {
            bool success = false;
            string errorString;
            try
            {
                Create_Booking_Insert_Command();
                Create_Booking_Update_Command();
                Create_Booking_Delete_Command();
                UpdateDataSource(sqlLocal2, table2);
                success = true;
            }
            catch (Exception ex)
            {
                errorString = ex.Message + " " + ex.StackTrace;
            }
            return success;
        }
        #endregion

    }
}
