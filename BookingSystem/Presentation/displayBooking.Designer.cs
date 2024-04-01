namespace BookingSystem.Presentation
{
    partial class displayBooking
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
            this.resIDtextBox = new System.Windows.Forms.TextBox();
            this.DetailsListView = new System.Windows.Forms.ListView();
            this.errorLabel = new System.Windows.Forms.Label();
            this.checkDetailsButton = new System.Windows.Forms.Button();
            this.ResNumLabel = new System.Windows.Forms.Label();
            this.invalidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resIDtextBox
            // 
            this.resIDtextBox.Location = new System.Drawing.Point(636, 112);
            this.resIDtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resIDtextBox.Name = "resIDtextBox";
            this.resIDtextBox.Size = new System.Drawing.Size(385, 22);
            this.resIDtextBox.TabIndex = 0;
            this.resIDtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DetailsListView
            // 
            this.DetailsListView.HideSelection = false;
            this.DetailsListView.Location = new System.Drawing.Point(323, 222);
            this.DetailsListView.Margin = new System.Windows.Forms.Padding(4);
            this.DetailsListView.Name = "DetailsListView";
            this.DetailsListView.Size = new System.Drawing.Size(1091, 128);
            this.DetailsListView.TabIndex = 2;
            this.DetailsListView.UseCompatibleStateImageBehavior = false;
            this.DetailsListView.SelectedIndexChanged += new System.EventHandler(this.DetailsListView_SelectedIndexChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(557, 185);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(300, 13);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "There is no booking with that Reservation Number! ";
            // 
            // checkDetailsButton
            // 
            this.checkDetailsButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.checkDetailsButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDetailsButton.ForeColor = System.Drawing.Color.White;
            this.checkDetailsButton.Location = new System.Drawing.Point(1192, 102);
            this.checkDetailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkDetailsButton.Name = "checkDetailsButton";
            this.checkDetailsButton.Size = new System.Drawing.Size(223, 62);
            this.checkDetailsButton.TabIndex = 4;
            this.checkDetailsButton.Text = "Check Details";
            this.checkDetailsButton.UseVisualStyleBackColor = false;
            this.checkDetailsButton.Click += new System.EventHandler(this.checkDetailsButton_Click);
            // 
            // ResNumLabel
            // 
            this.ResNumLabel.AutoSize = true;
            this.ResNumLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResNumLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ResNumLabel.Location = new System.Drawing.Point(281, 112);
            this.ResNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResNumLabel.Name = "ResNumLabel";
            this.ResNumLabel.Size = new System.Drawing.Size(239, 25);
            this.ResNumLabel.TabIndex = 5;
            this.ResNumLabel.Text = "Enter Reservation Number";
            // 
            // invalidLabel
            // 
            this.invalidLabel.AutoSize = true;
            this.invalidLabel.BackColor = System.Drawing.Color.White;
            this.invalidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidLabel.Location = new System.Drawing.Point(601, 151);
            this.invalidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidLabel.Name = "invalidLabel";
            this.invalidLabel.Size = new System.Drawing.Size(168, 13);
            this.invalidLabel.TabIndex = 6;
            this.invalidLabel.Text = "Invalid Reservation Number!";
            // 
            // displayBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1628, 614);
            this.Controls.Add(this.invalidLabel);
            this.Controls.Add(this.ResNumLabel);
            this.Controls.Add(this.checkDetailsButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.DetailsListView);
            this.Controls.Add(this.resIDtextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "displayBooking";
            this.Text = "displayBooking";
            this.Activated += new System.EventHandler(this.displayBooking_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.displayBooking_FormClosed);
            this.Load += new System.EventHandler(this.displayBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resIDtextBox;
        private System.Windows.Forms.ListView DetailsListView;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button checkDetailsButton;
        private System.Windows.Forms.Label ResNumLabel;
        private System.Windows.Forms.Label invalidLabel;
    }
}