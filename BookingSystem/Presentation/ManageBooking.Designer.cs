namespace BookingSystem.Presentation
{
    partial class ManageBooking
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
            this.ResNumberLabel = new System.Windows.Forms.Label();
            this.ResNumTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CheckInDateLabel = new System.Windows.Forms.Label();
            this.CheckOutDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UpdateBookingButton = new System.Windows.Forms.Button();
            this.DeleteBookingButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ResErrorLabel = new System.Windows.Forms.Label();
            this.DateErrorLabel = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.dateError = new System.Windows.Forms.Label();
            this.durationError = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.invalidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResNumberLabel
            // 
            this.ResNumberLabel.AutoSize = true;
            this.ResNumberLabel.BackColor = System.Drawing.Color.White;
            this.ResNumberLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResNumberLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ResNumberLabel.Location = new System.Drawing.Point(439, 197);
            this.ResNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResNumberLabel.Name = "ResNumberLabel";
            this.ResNumberLabel.Size = new System.Drawing.Size(244, 25);
            this.ResNumberLabel.TabIndex = 0;
            this.ResNumberLabel.Text = "Enter Reservation Number:";
            this.ResNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResNumTextBox
            // 
            this.ResNumTextBox.Location = new System.Drawing.Point(791, 197);
            this.ResNumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResNumTextBox.Name = "ResNumTextBox";
            this.ResNumTextBox.Size = new System.Drawing.Size(405, 22);
            this.ResNumTextBox.TabIndex = 1;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(788, 406);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(273, 22);
            this.IDTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(788, 468);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(273, 22);
            this.NameTextBox.TabIndex = 4;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.White;
            this.IDLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.DimGray;
            this.IDLabel.Location = new System.Drawing.Point(551, 410);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(91, 25);
            this.IDLabel.TabIndex = 7;
            this.IDLabel.Text = "Guest ID:";
            this.IDLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.White;
            this.NameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.NameLabel.Location = new System.Drawing.Point(551, 471);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 25);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // CheckInDateLabel
            // 
            this.CheckInDateLabel.AutoSize = true;
            this.CheckInDateLabel.BackColor = System.Drawing.Color.White;
            this.CheckInDateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CheckInDateLabel.Location = new System.Drawing.Point(551, 537);
            this.CheckInDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckInDateLabel.Name = "CheckInDateLabel";
            this.CheckInDateLabel.Size = new System.Drawing.Size(140, 25);
            this.CheckInDateLabel.TabIndex = 9;
            this.CheckInDateLabel.Text = "Check-In Date:";
            // 
            // CheckOutDateLabel
            // 
            this.CheckOutDateLabel.AutoSize = true;
            this.CheckOutDateLabel.BackColor = System.Drawing.Color.White;
            this.CheckOutDateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CheckOutDateLabel.Location = new System.Drawing.Point(551, 602);
            this.CheckOutDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckOutDateLabel.Name = "CheckOutDateLabel";
            this.CheckOutDateLabel.Size = new System.Drawing.Size(155, 25);
            this.CheckOutDateLabel.TabIndex = 10;
            this.CheckOutDateLabel.Text = "Check-Out Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(780, 549);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // UpdateBookingButton
            // 
            this.UpdateBookingButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.UpdateBookingButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBookingButton.ForeColor = System.Drawing.Color.White;
            this.UpdateBookingButton.Location = new System.Drawing.Point(476, 82);
            this.UpdateBookingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateBookingButton.Name = "UpdateBookingButton";
            this.UpdateBookingButton.Size = new System.Drawing.Size(288, 78);
            this.UpdateBookingButton.TabIndex = 12;
            this.UpdateBookingButton.Text = "Update Booking Details";
            this.UpdateBookingButton.UseVisualStyleBackColor = false;
            this.UpdateBookingButton.Click += new System.EventHandler(this.UpdateBookingButton_Click);
            // 
            // DeleteBookingButton
            // 
            this.DeleteBookingButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DeleteBookingButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookingButton.ForeColor = System.Drawing.Color.White;
            this.DeleteBookingButton.Location = new System.Drawing.Point(832, 82);
            this.DeleteBookingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBookingButton.Name = "DeleteBookingButton";
            this.DeleteBookingButton.Size = new System.Drawing.Size(319, 78);
            this.DeleteBookingButton.TabIndex = 13;
            this.DeleteBookingButton.Text = "Delete Booking";
            this.DeleteBookingButton.UseVisualStyleBackColor = false;
            this.DeleteBookingButton.Click += new System.EventHandler(this.DeleteBookingButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SearchButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(736, 272);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(168, 48);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(780, 608);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SubmitButton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(736, 743);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(168, 39);
            this.SubmitButton.TabIndex = 16;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ResErrorLabel
            // 
            this.ResErrorLabel.AutoSize = true;
            this.ResErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ResErrorLabel.Location = new System.Drawing.Point(559, 346);
            this.ResErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResErrorLabel.Name = "ResErrorLabel";
            this.ResErrorLabel.Size = new System.Drawing.Size(372, 13);
            this.ResErrorLabel.TabIndex = 17;
            this.ResErrorLabel.Text = "Error: Reservation Not Found. Please check input and try again.";
            // 
            // DateErrorLabel
            // 
            this.DateErrorLabel.AutoSize = true;
            this.DateErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DateErrorLabel.Location = new System.Drawing.Point(559, 672);
            this.DateErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateErrorLabel.Name = "DateErrorLabel";
            this.DateErrorLabel.Size = new System.Drawing.Size(359, 13);
            this.DateErrorLabel.TabIndex = 18;
            this.DateErrorLabel.Text = "Error: Chosen dates not available. Please choose other dates.";
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.ForeColor = System.Drawing.Color.Red;
            this.errorLabel2.Location = new System.Drawing.Point(337, 724);
            this.errorLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(730, 13);
            this.errorLabel2.TabIndex = 19;
            this.errorLabel2.Text = "Error: Chosen dates need to be in the same season as original booking. Advise gue" +
    "st to make new booking and cancel original.";
            // 
            // dateError
            // 
            this.dateError.AutoSize = true;
            this.dateError.BackColor = System.Drawing.Color.White;
            this.dateError.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateError.ForeColor = System.Drawing.Color.Red;
            this.dateError.Location = new System.Drawing.Point(520, 636);
            this.dateError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateError.Name = "dateError";
            this.dateError.Size = new System.Drawing.Size(444, 21);
            this.dateError.TabIndex = 48;
            this.dateError.Text = "Check out date must be at least one day after check in date.";
            // 
            // durationError
            // 
            this.durationError.AutoSize = true;
            this.durationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationError.ForeColor = System.Drawing.Color.Red;
            this.durationError.Location = new System.Drawing.Point(400, 688);
            this.durationError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durationError.Name = "durationError";
            this.durationError.Size = new System.Drawing.Size(683, 13);
            this.durationError.TabIndex = 49;
            this.durationError.Text = "Error: Duration of stay has to be equivalent to original booking. Advise guest to" +
    " make new booking and cancel original.";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cancelButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(1197, 457);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(245, 60);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // invalidLabel
            // 
            this.invalidLabel.AutoSize = true;
            this.invalidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidLabel.Location = new System.Drawing.Point(960, 293);
            this.invalidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidLabel.Name = "invalidLabel";
            this.invalidLabel.Size = new System.Drawing.Size(203, 13);
            this.invalidLabel.TabIndex = 51;
            this.invalidLabel.Text = "Error: Invalid Reservation Number!";
            // 
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1649, 901);
            this.Controls.Add(this.invalidLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.durationError);
            this.Controls.Add(this.dateError);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.DateErrorLabel);
            this.Controls.Add(this.ResErrorLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteBookingButton);
            this.Controls.Add(this.UpdateBookingButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CheckOutDateLabel);
            this.Controls.Add(this.CheckInDateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.ResNumTextBox);
            this.Controls.Add(this.ResNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageBooking";
            this.Text = "ManageBooking";
            this.Activated += new System.EventHandler(this.ManageBooking_Activated_1);
            this.Load += new System.EventHandler(this.ManageBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResNumberLabel;
        private System.Windows.Forms.TextBox ResNumTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CheckInDateLabel;
        private System.Windows.Forms.Label CheckOutDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button UpdateBookingButton;
        private System.Windows.Forms.Button DeleteBookingButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ResErrorLabel;
        private System.Windows.Forms.Label DateErrorLabel;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Label dateError;
        private System.Windows.Forms.Label durationError;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label invalidLabel;
    }
}