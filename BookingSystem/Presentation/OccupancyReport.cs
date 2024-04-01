using BookingSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookingSystem.Presentation
{
    public partial class OccupancyReport : Form
    {
        private BookingController bookingController;
        public bool occupancyReportFormClosed;
        public OccupancyReport(BookingController bookingController)
        {
            InitializeComponent();
            this.bookingController = bookingController;
            occupancyReportFormClosed = false;
            title.Visible = false;
            graph.Visible = false;
        }

        private void OccupancyReport_Load(object sender, EventArgs e)
        {
            
        }
        private  void OccupancyReport_FormClosed(object sender, EventArgs e)
        {
            occupancyReportFormClosed=true;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            title.Visible = true;
            graph.Visible = true;
            graph.ChartAreas["ChartArea1"].AxisY.Maximum = 100;
            graph.ChartAreas["ChartArea1"].AxisY.Title = "Occupancy %";
            graph.ChartAreas["ChartArea1"].AxisX.Title = "Date";
            graph.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            graph.Series["Occupancy"].Points.Clear();
            graph.Series["Occupancy"].BorderWidth = 3;
            graph.Series["Occupancy"].MarkerStyle = MarkerStyle.Circle;
            graph.Series["Occupancy"].MarkerSize = 10;
            DateTime startDay = dateTimePicker1.Value.Date;
            DateTime endDay = dateTimePicker2.Value.Date;
            DateTime day = startDay;
            graph.Series["Occupancy"].Points.AddXY(day.ToShortDateString(), bookingController.validateDate(day.ToString(), day.ToString())*20);
            for (day = startDay+TimeSpan.FromDays(1); day <= endDay; day += TimeSpan.FromDays(1))
            {
                graph.Series["Occupancy"].Points.AddXY(day.ToShortDateString(), bookingController.validateDate(day.ToString(),day.ToString())*20);
            }
        }

        private void graph_Click(object sender, EventArgs e)
        {

        }
    }
}
