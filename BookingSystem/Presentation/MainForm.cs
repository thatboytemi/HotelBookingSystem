using BookingSystem.Data;
using BookingSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class MainForm : Form
    {

        private int childFormNumber = 0;


        #region Instance variables
        private ManageBooking manageBookingForm;
        private GuestController guestController;
        private BookingController bookingController;
        private HotelDatabase hotelDatabase;
        private displayBooking checkDetailsForm;
        private addBooking addBookingForm;
        private OccupancyReport occupancyReportForm;
        private HomeScreen homeScreen;
        private SalesReport salesReport;
        

        #endregion

        public MainForm(HotelDatabase hotelDatabase, string name)
        {
            InitializeComponent();
            this.hotelDatabase = hotelDatabase;
            guestController = new GuestController(hotelDatabase);
            bookingController = new BookingController(hotelDatabase);
            homeScreen = new HomeScreen(name,guestController);
            homeScreen.MdiParent = this;
        }
        #region Form manipulations

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
            ManageBookingButton.Hide();
        }
        #endregion
        #region General Tool Strips
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(homeScreen);
            homeScreen.Show();
            ManageBookingButton.FlatStyle = FlatStyle.Flat;
            ManageBookingButton.FlatAppearance.BorderSize = 0;
            addBookingButton.FlatStyle = FlatStyle.Flat;
            addBookingButton.FlatAppearance.BorderSize = 0;
            reportButton.FlatStyle = FlatStyle.Flat;
            reportButton.FlatAppearance.BorderSize = 0;
            checkBookingDetails.FlatStyle = FlatStyle.Flat;
            checkBookingDetails.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.FlatAppearance.BorderSize = 0;
            salesButton.FlatStyle = FlatStyle.Flat;
            salesButton.FlatAppearance.BorderSize = 0;
        }
        private void MainForm_FormClosing(object sender, FormClosedEventArgs e)
        {
           
        }
        #endregion
        #region Create new child form
        public void CreateNewManageBookingForm()
        {
            manageBookingForm = new ManageBooking(guestController, bookingController);
            manageBookingForm.MdiParent = this;
        }
        public void CreateNewSalesReportForm()
        {
            salesReport = new SalesReport(bookingController);
            salesReport.MdiParent = this;
        }

        #endregion

        private void ManageBookingButton_Click(object sender, EventArgs e)
        {
            FormatButtons();
            ManageBookingButton.BackColor = Color.MediumSeaGreen;
            ManageBookingButton.ForeColor = Color.White;
            if (manageBookingForm == null)
            {
                this.CreateNewManageBookingForm();
            }
            else if (manageBookingForm.manageBookingFormClosed)
            {
                this.CreateNewManageBookingForm();
            }
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(manageBookingForm);
            manageBookingForm.Show();
        }
        public void CreateNewCheckDetailsForm()
        {
            checkDetailsForm = new displayBooking(guestController, bookingController);
            checkDetailsForm.MdiParent = this;
            
        }
        public void CreateNewAddBookingForm()
        {
            addBookingForm = new addBooking(guestController,bookingController);
            addBookingForm.MdiParent = this;
            
        }
        public void CreateNewOccupancyReportForm()
        {
            occupancyReportForm = new OccupancyReport(bookingController);
            occupancyReportForm.MdiParent= this;
        }

        private void addBookingButton_Click(object sender, EventArgs e)
        {
            FormatButtons();
            addBookingButton.BackColor = Color.MediumSeaGreen;
            addBookingButton.ForeColor = Color.White;
            if (addBookingForm == null)
            {
                this.CreateNewAddBookingForm();
            }
            else if (addBookingForm.addBoookingFormClosed)
            {
                this.CreateNewAddBookingForm();
            }
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(addBookingForm);
            addBookingForm.Show();

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            FormatButtons();
            reportButton.BackColor = Color.MediumSeaGreen;
            reportButton.ForeColor = Color.White;
            if (occupancyReportForm == null)
            {
                this.CreateNewOccupancyReportForm();
            }
            else if (occupancyReportForm.occupancyReportFormClosed)
            {
                this.CreateNewOccupancyReportForm();
            }
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(occupancyReportForm);
            occupancyReportForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBookingDetails_Click(object sender, EventArgs e)
        {
            FormatButtons();
            checkBookingDetails.BackColor = Color.MediumSeaGreen;
            checkBookingDetails.ForeColor = Color.White;
            if (checkDetailsForm == null)
            {
                this.CreateNewCheckDetailsForm();
            }
            else if (checkDetailsForm.displayBookingFormClosed)
            {
                this.CreateNewCheckDetailsForm();
            }
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(checkDetailsForm);
            checkDetailsForm.Show();
        }
        private void FormatButtons()
        {
            checkBookingDetails.BackColor = Color.White;
            checkBookingDetails.ForeColor = Color.DimGray;
            addBookingButton.BackColor = Color.White;
            addBookingButton.ForeColor = Color.DimGray;
            ManageBookingButton.BackColor = Color.White;
            ManageBookingButton.ForeColor = Color.DimGray;
            reportButton.BackColor = Color.White;
            reportButton.ForeColor = Color.DimGray;
            homeButton.BackColor = Color.White;
            homeButton.ForeColor = Color.DimGray;
            salesButton.BackColor = Color.White;
            salesButton.ForeColor = Color.DimGray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            FormatButtons();
            homeButton.BackColor = Color.MediumSeaGreen;
            homeButton.ForeColor = Color.White;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(homeScreen);
            homeScreen.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            FormatButtons();
            salesButton.BackColor = Color.MediumSeaGreen;
            salesButton.ForeColor = Color.White;
            if (salesReport == null)
            {
                this.CreateNewSalesReportForm();
            }
            else if (salesReport.salesReportFormClosed)
            {
                this.CreateNewSalesReportForm();
            }
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(salesReport);
            salesReport.Show();
        }
    }
}
