using BookingSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Data
{
    public class Database
    {
        #region Variable declaration
        private string strConn = Settings.Default.HotelDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        #endregion
        #region Database Operation Enum
        public enum DBOperation
        {
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion
        #region Constructor
        public Database()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error in establishing connection with the database.");
                return;
            }
        }

        #endregion
        #region Update DataSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }
        #endregion
        #region Update the database
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                cnMain.Open();
                int i=daMain.Update(dsMain, table);
                Console.WriteLine(i);
                cnMain.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            return success;
        }
        #endregion
    }
}
