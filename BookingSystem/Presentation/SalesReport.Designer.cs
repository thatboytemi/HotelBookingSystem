namespace BookingSystem.Presentation
{
    partial class SalesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salesLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.figure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(531, 340);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "PieChart";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(377, 346);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.dateLabel.Location = new System.Drawing.Point(491, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(114, 25);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Select Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(621, 14);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.ForeColor = System.Drawing.Color.DimGray;
            this.salesLabel.Location = new System.Drawing.Point(535, 140);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(271, 47);
            this.salesLabel.TabIndex = 3;
            this.salesLabel.Text = "Projected Sales: ";
            this.salesLabel.Click += new System.EventHandler(this.salesLabel_Click);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.generateButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(531, 40);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(209, 60);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DimGray;
            this.title.Location = new System.Drawing.Point(246, 300);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(897, 37);
            this.title.TabIndex = 11;
            this.title.Text = "Pie Chart Showing The Number of Confirmed Bookings on Chosen Date:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(526, 115);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(267, 25);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "No Bookings on Chosen Date.";
            // 
            // figure
            // 
            this.figure.AutoSize = true;
            this.figure.Font = new System.Drawing.Font("Yu Gothic UI", 66F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figure.ForeColor = System.Drawing.Color.DimGray;
            this.figure.Location = new System.Drawing.Point(523, 187);
            this.figure.Name = "figure";
            this.figure.Size = new System.Drawing.Size(286, 116);
            this.figure.TabIndex = 13;
            this.figure.Text = "R1000";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 689);
            this.Controls.Add(this.figure);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label figure;
    }
}