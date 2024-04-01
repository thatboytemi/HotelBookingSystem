namespace BookingSystem.Presentation
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salesButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.checkBookingDetails = new System.Windows.Forms.Button();
            this.ManageBookingButton = new System.Windows.Forms.Button();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 92);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingSystem.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(580, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phumla Kamnandi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.salesButton);
            this.panel2.Controls.Add(this.reportButton);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.checkBookingDetails);
            this.panel2.Controls.Add(this.ManageBookingButton);
            this.panel2.Controls.Add(this.addBookingButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1377, 55);
            this.panel2.TabIndex = 12;
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Transparent;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.DimGray;
            this.salesButton.Location = new System.Drawing.Point(1149, -3);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(228, 59);
            this.salesButton.TabIndex = 5;
            this.salesButton.Text = "Generate Sales Report";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.Transparent;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.DimGray;
            this.reportButton.Location = new System.Drawing.Point(896, -8);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(261, 71);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Generate Occupancy Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(0, -5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(201, 63);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // checkBookingDetails
            // 
            this.checkBookingDetails.BackColor = System.Drawing.Color.Transparent;
            this.checkBookingDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBookingDetails.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBookingDetails.ForeColor = System.Drawing.Color.DimGray;
            this.checkBookingDetails.Location = new System.Drawing.Point(421, -2);
            this.checkBookingDetails.Name = "checkBookingDetails";
            this.checkBookingDetails.Size = new System.Drawing.Size(227, 58);
            this.checkBookingDetails.TabIndex = 4;
            this.checkBookingDetails.Text = "Check Booking Details";
            this.checkBookingDetails.UseVisualStyleBackColor = false;
            this.checkBookingDetails.Click += new System.EventHandler(this.checkBookingDetails_Click);
            // 
            // ManageBookingButton
            // 
            this.ManageBookingButton.BackColor = System.Drawing.Color.Transparent;
            this.ManageBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageBookingButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBookingButton.ForeColor = System.Drawing.Color.DimGray;
            this.ManageBookingButton.Location = new System.Drawing.Point(644, -7);
            this.ManageBookingButton.Name = "ManageBookingButton";
            this.ManageBookingButton.Size = new System.Drawing.Size(273, 63);
            this.ManageBookingButton.TabIndex = 5;
            this.ManageBookingButton.Text = "Manage Existing Booking";
            this.ManageBookingButton.UseVisualStyleBackColor = false;
            this.ManageBookingButton.Click += new System.EventHandler(this.ManageBookingButton_Click);
            // 
            // addBookingButton
            // 
            this.addBookingButton.BackColor = System.Drawing.Color.Transparent;
            this.addBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookingButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookingButton.ForeColor = System.Drawing.Color.DimGray;
            this.addBookingButton.Location = new System.Drawing.Point(197, -4);
            this.addBookingButton.Name = "addBookingButton";
            this.addBookingButton.Size = new System.Drawing.Size(232, 63);
            this.addBookingButton.TabIndex = 0;
            this.addBookingButton.Text = "Create New Booking";
            this.addBookingButton.UseVisualStyleBackColor = false;
            this.addBookingButton.Click += new System.EventHandler(this.addBookingButton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 147);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1377, 647);
            this.panelContainer.TabIndex = 13;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 794);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingSystem";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button addBookingButton;
        private System.Windows.Forms.Button checkBookingDetails;
        private System.Windows.Forms.Button ManageBookingButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



