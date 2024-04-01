namespace BookingSystem.Presentation
{
    partial class OccupancyReport
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
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(320, 290);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.MediumAquamarine;
            series2.Legend = "Legend1";
            series2.Name = "Occupancy";
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(706, 322);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            this.graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.DimGray;
            this.start.Location = new System.Drawing.Point(143, 48);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(154, 25);
            this.start.TabIndex = 2;
            this.start.Text = "Enter Start Date:";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.ForeColor = System.Drawing.Color.DimGray;
            this.end.Location = new System.Drawing.Point(627, 48);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(145, 25);
            this.end.TabIndex = 3;
            this.end.Text = "Enter End Date:";
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.generateButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(533, 99);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(209, 60);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate Graph";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 53);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(876, 53);
            this.dateTimePicker2.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DimGray;
            this.title.Location = new System.Drawing.Point(313, 226);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(641, 37);
            this.title.TabIndex = 12;
            this.title.Text = "Graph Showing Occupancy Levels of Chosen Dates:";
            // 
            // OccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 689);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OccupancyReport";
            this.Text = "Occpancy Report";
            this.Load += new System.EventHandler(this.OccupancyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label title;
    }
}