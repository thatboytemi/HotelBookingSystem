namespace BookingSystem.Presentation
{
    partial class addBooking
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
            this.GuestIDLabel = new System.Windows.Forms.Label();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.CheckOutDateLabel = new System.Windows.Forms.Label();
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.CheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StreetNameLabel = new System.Windows.Forms.Label();
            this.SuburbLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StrNameTextBox = new System.Windows.Forms.TextBox();
            this.SuburbTextBox = new System.Windows.Forms.TextBox();
            this.PostCodeTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.counterLabel = new System.Windows.Forms.Label();
            this.submitBookingButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.FindGuestButton = new System.Windows.Forms.Button();
            this.newGuest = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.nowButton = new System.Windows.Forms.Button();
            this.laterButton = new System.Windows.Forms.Button();
            this.cardNumLabel = new System.Windows.Forms.Label();
            this.cardNumTextBox = new System.Windows.Forms.TextBox();
            this.processPaymentButton = new System.Windows.Forms.Button();
            this.paymentSuccessLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.invalidID = new System.Windows.Forms.Label();
            this.dateError = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuestIDLabel
            // 
            this.GuestIDLabel.AutoSize = true;
            this.GuestIDLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestIDLabel.ForeColor = System.Drawing.Color.DimGray;
            this.GuestIDLabel.Location = new System.Drawing.Point(457, 135);
            this.GuestIDLabel.Name = "GuestIDLabel";
            this.GuestIDLabel.Size = new System.Drawing.Size(91, 25);
            this.GuestIDLabel.TabIndex = 1;
            this.GuestIDLabel.Text = "Guest ID:";
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CheckInLabel.Location = new System.Drawing.Point(457, 9);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(136, 25);
            this.CheckInLabel.TabIndex = 2;
            this.CheckInLabel.Text = "Check in Date:";
            // 
            // CheckOutDateLabel
            // 
            this.CheckOutDateLabel.AutoSize = true;
            this.CheckOutDateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CheckOutDateLabel.Location = new System.Drawing.Point(457, 43);
            this.CheckOutDateLabel.Name = "CheckOutDateLabel";
            this.CheckOutDateLabel.Size = new System.Drawing.Size(152, 25);
            this.CheckOutDateLabel.TabIndex = 3;
            this.CheckOutDateLabel.Text = "Check Out Date:";
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(593, 141);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(273, 20);
            this.guestIDTextBox.TabIndex = 5;
            this.guestIDTextBox.TextChanged += new System.EventHandler(this.guestIDTextBox_TextChanged);
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.CheckInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(630, 14);
            this.CheckInDateTimePicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.CheckInDateTimePicker.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CheckInDateTimePicker.TabIndex = 6;
            this.CheckInDateTimePicker.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.CheckOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(630, 48);
            this.CheckOutDateTimePicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.CheckOutDateTimePicker.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CheckOutDateTimePicker.TabIndex = 7;
            this.CheckOutDateTimePicker.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.CheckOutDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.NameLabel.Location = new System.Drawing.Point(457, 216);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 25);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name:";
            // 
            // StreetNameLabel
            // 
            this.StreetNameLabel.AutoSize = true;
            this.StreetNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.StreetNameLabel.Location = new System.Drawing.Point(457, 247);
            this.StreetNameLabel.Name = "StreetNameLabel";
            this.StreetNameLabel.Size = new System.Drawing.Size(125, 25);
            this.StreetNameLabel.TabIndex = 11;
            this.StreetNameLabel.Text = "Street Name:";
            // 
            // SuburbLabel
            // 
            this.SuburbLabel.AutoSize = true;
            this.SuburbLabel.BackColor = System.Drawing.Color.Transparent;
            this.SuburbLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuburbLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SuburbLabel.Location = new System.Drawing.Point(457, 285);
            this.SuburbLabel.Name = "SuburbLabel";
            this.SuburbLabel.Size = new System.Drawing.Size(78, 25);
            this.SuburbLabel.TabIndex = 12;
            this.SuburbLabel.Text = "Suburb:";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.PostalCodeLabel.Location = new System.Drawing.Point(457, 355);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(118, 25);
            this.PostalCodeLabel.TabIndex = 13;
            this.PostalCodeLabel.Text = "Postal Code:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(605, 216);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(273, 20);
            this.NameTextBox.TabIndex = 14;
            // 
            // StrNameTextBox
            // 
            this.StrNameTextBox.Location = new System.Drawing.Point(605, 252);
            this.StrNameTextBox.Name = "StrNameTextBox";
            this.StrNameTextBox.Size = new System.Drawing.Size(273, 20);
            this.StrNameTextBox.TabIndex = 16;
            // 
            // SuburbTextBox
            // 
            this.SuburbTextBox.Location = new System.Drawing.Point(605, 291);
            this.SuburbTextBox.Name = "SuburbTextBox";
            this.SuburbTextBox.Size = new System.Drawing.Size(273, 20);
            this.SuburbTextBox.TabIndex = 17;
            // 
            // PostCodeTextBox
            // 
            this.PostCodeTextBox.Location = new System.Drawing.Point(605, 360);
            this.PostCodeTextBox.Name = "PostCodeTextBox";
            this.PostCodeTextBox.Size = new System.Drawing.Size(273, 20);
            this.PostCodeTextBox.TabIndex = 18;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.Color.DimGray;
            this.CityLabel.Location = new System.Drawing.Point(457, 319);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(51, 25);
            this.CityLabel.TabIndex = 22;
            this.CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(605, 325);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(273, 20);
            this.CityTextBox.TabIndex = 23;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.ForeColor = System.Drawing.Color.DimGray;
            this.counterLabel.Location = new System.Drawing.Point(484, 114);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(365, 21);
            this.counterLabel.TabIndex = 24;
            this.counterLabel.Text = "There are 5 available rooms on the chosen dates.";
            // 
            // submitBookingButton
            // 
            this.submitBookingButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.submitBookingButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBookingButton.ForeColor = System.Drawing.Color.White;
            this.submitBookingButton.Location = new System.Drawing.Point(576, 589);
            this.submitBookingButton.Name = "submitBookingButton";
            this.submitBookingButton.Size = new System.Drawing.Size(184, 41);
            this.submitBookingButton.TabIndex = 27;
            this.submitBookingButton.Text = "Submit Booking";
            this.submitBookingButton.UseVisualStyleBackColor = false;
            this.submitBookingButton.Click += new System.EventHandler(this.submitBookingButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.searchButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(593, 74);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 37);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FindGuestButton
            // 
            this.FindGuestButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.FindGuestButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindGuestButton.ForeColor = System.Drawing.Color.White;
            this.FindGuestButton.Location = new System.Drawing.Point(906, 135);
            this.FindGuestButton.Name = "FindGuestButton";
            this.FindGuestButton.Size = new System.Drawing.Size(134, 36);
            this.FindGuestButton.TabIndex = 29;
            this.FindGuestButton.Text = "Find Guest";
            this.FindGuestButton.UseVisualStyleBackColor = false;
            this.FindGuestButton.Click += new System.EventHandler(this.FindGuestButton_Click);
            // 
            // newGuest
            // 
            this.newGuest.AutoSize = true;
            this.newGuest.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGuest.ForeColor = System.Drawing.Color.DimGray;
            this.newGuest.Location = new System.Drawing.Point(522, 164);
            this.newGuest.Name = "newGuest";
            this.newGuest.Size = new System.Drawing.Size(286, 21);
            this.newGuest.TabIndex = 30;
            this.newGuest.Text = "This is a new guest, enter their details:";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.Color.DimGray;
            this.paymentLabel.Location = new System.Drawing.Point(589, 476);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(141, 21);
            this.paymentLabel.TabIndex = 31;
            this.paymentLabel.Text = "Pay Now or Later?";
            this.paymentLabel.Click += new System.EventHandler(this.paymentLabel_Click);
            // 
            // nowButton
            // 
            this.nowButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.nowButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowButton.ForeColor = System.Drawing.Color.White;
            this.nowButton.Location = new System.Drawing.Point(488, 500);
            this.nowButton.Name = "nowButton";
            this.nowButton.Size = new System.Drawing.Size(134, 36);
            this.nowButton.TabIndex = 32;
            this.nowButton.Text = "Now";
            this.nowButton.UseVisualStyleBackColor = false;
            this.nowButton.Click += new System.EventHandler(this.nowButton_Click);
            // 
            // laterButton
            // 
            this.laterButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.laterButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laterButton.ForeColor = System.Drawing.Color.White;
            this.laterButton.Location = new System.Drawing.Point(715, 500);
            this.laterButton.Name = "laterButton";
            this.laterButton.Size = new System.Drawing.Size(134, 36);
            this.laterButton.TabIndex = 33;
            this.laterButton.Text = "Later";
            this.laterButton.UseVisualStyleBackColor = false;
            this.laterButton.Click += new System.EventHandler(this.laterButton_Click);
            // 
            // cardNumLabel
            // 
            this.cardNumLabel.AutoSize = true;
            this.cardNumLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumLabel.ForeColor = System.Drawing.Color.DimGray;
            this.cardNumLabel.Location = new System.Drawing.Point(433, 542);
            this.cardNumLabel.Name = "cardNumLabel";
            this.cardNumLabel.Size = new System.Drawing.Size(149, 21);
            this.cardNumLabel.TabIndex = 34;
            this.cardNumLabel.Text = "Enter card number:";
            // 
            // cardNumTextBox
            // 
            this.cardNumTextBox.Location = new System.Drawing.Point(593, 542);
            this.cardNumTextBox.Name = "cardNumTextBox";
            this.cardNumTextBox.Size = new System.Drawing.Size(273, 20);
            this.cardNumTextBox.TabIndex = 35;
            // 
            // processPaymentButton
            // 
            this.processPaymentButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.processPaymentButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processPaymentButton.ForeColor = System.Drawing.Color.White;
            this.processPaymentButton.Location = new System.Drawing.Point(906, 548);
            this.processPaymentButton.Name = "processPaymentButton";
            this.processPaymentButton.Size = new System.Drawing.Size(134, 36);
            this.processPaymentButton.TabIndex = 36;
            this.processPaymentButton.Text = "Process";
            this.processPaymentButton.UseVisualStyleBackColor = false;
            this.processPaymentButton.Click += new System.EventHandler(this.processPaymentButton_Click);
            // 
            // paymentSuccessLabel
            // 
            this.paymentSuccessLabel.AutoSize = true;
            this.paymentSuccessLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentSuccessLabel.ForeColor = System.Drawing.Color.DimGray;
            this.paymentSuccessLabel.Location = new System.Drawing.Point(603, 565);
            this.paymentSuccessLabel.Name = "paymentSuccessLabel";
            this.paymentSuccessLabel.Size = new System.Drawing.Size(157, 21);
            this.paymentSuccessLabel.TabIndex = 37;
            this.paymentSuccessLabel.Text = "Payment Successful.";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.ForeColor = System.Drawing.Color.DimGray;
            this.depositLabel.Location = new System.Drawing.Point(572, 455);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(134, 21);
            this.depositLabel.TabIndex = 39;
            this.depositLabel.Text = "Deposit Amount:";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLabel.ForeColor = System.Drawing.Color.DimGray;
            this.phoneNumLabel.Location = new System.Drawing.Point(457, 393);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(147, 25);
            this.phoneNumLabel.TabIndex = 40;
            this.phoneNumLabel.Text = "Phone Number:";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Location = new System.Drawing.Point(605, 393);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(273, 20);
            this.phoneNumTextBox.TabIndex = 41;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.White;
            this.balanceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.Red;
            this.balanceLabel.Location = new System.Drawing.Point(468, 185);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(420, 21);
            this.balanceLabel.TabIndex = 42;
            this.balanceLabel.Text = "Booking places guest over credit limit. Do not allow this.";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
            this.emailLabel.Location = new System.Drawing.Point(457, 430);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(152, 25);
            this.emailLabel.TabIndex = 43;
            this.emailLabel.Text = "Email (optional):";
            this.emailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(605, 430);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(273, 20);
            this.emailTextBox.TabIndex = 44;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(782, 600);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(469, 21);
            this.errorLabel.TabIndex = 45;
            this.errorLabel.Text = "*One or more of the guest\'s details are not valid. Please fix this.";
            // 
            // invalidID
            // 
            this.invalidID.AutoSize = true;
            this.invalidID.BackColor = System.Drawing.Color.White;
            this.invalidID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidID.ForeColor = System.Drawing.Color.Red;
            this.invalidID.Location = new System.Drawing.Point(1063, 144);
            this.invalidID.Name = "invalidID";
            this.invalidID.Size = new System.Drawing.Size(128, 21);
            this.invalidID.TabIndex = 46;
            this.invalidID.Text = "Invalid Guest ID.";
            // 
            // dateError
            // 
            this.dateError.AutoSize = true;
            this.dateError.BackColor = System.Drawing.Color.White;
            this.dateError.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateError.ForeColor = System.Drawing.Color.Red;
            this.dateError.Location = new System.Drawing.Point(854, 27);
            this.dateError.Name = "dateError";
            this.dateError.Size = new System.Drawing.Size(444, 21);
            this.dateError.TabIndex = 47;
            this.dateError.Text = "Check out date must be at least one day after check in date.";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cancelButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(1067, 295);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(184, 49);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 689);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dateError);
            this.Controls.Add(this.invalidID);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.paymentSuccessLabel);
            this.Controls.Add(this.processPaymentButton);
            this.Controls.Add(this.cardNumTextBox);
            this.Controls.Add(this.cardNumLabel);
            this.Controls.Add(this.laterButton);
            this.Controls.Add(this.nowButton);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.newGuest);
            this.Controls.Add(this.FindGuestButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.submitBookingButton);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.PostCodeTextBox);
            this.Controls.Add(this.SuburbTextBox);
            this.Controls.Add(this.StrNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.SuburbLabel);
            this.Controls.Add(this.StreetNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CheckOutDateTimePicker);
            this.Controls.Add(this.CheckInDateTimePicker);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.CheckOutDateLabel);
            this.Controls.Add(this.CheckInLabel);
            this.Controls.Add(this.GuestIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addBooking";
            this.Text = "addBooking";
            this.Activated += new System.EventHandler(this.addBooking_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addBooking_FormClosed);
            this.Load += new System.EventHandler(this.addBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GuestIDLabel;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.Label CheckOutDateLabel;
        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.DateTimePicker CheckInDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StreetNameLabel;
        private System.Windows.Forms.Label SuburbLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StrNameTextBox;
        private System.Windows.Forms.TextBox SuburbTextBox;
        private System.Windows.Forms.TextBox PostCodeTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button submitBookingButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button FindGuestButton;
        private System.Windows.Forms.Label newGuest;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Button nowButton;
        private System.Windows.Forms.Button laterButton;
        private System.Windows.Forms.Label cardNumLabel;
        private System.Windows.Forms.TextBox cardNumTextBox;
        private System.Windows.Forms.Button processPaymentButton;
        private System.Windows.Forms.Label paymentSuccessLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label invalidID;
        private System.Windows.Forms.Label dateError;
        private System.Windows.Forms.Button cancelButton;
    }
}