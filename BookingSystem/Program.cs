﻿using BookingSystem.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
            if (loginForm.loginSuccess)
            {
                Application.Run(new MainForm(loginForm.HotelDatabase, loginForm.name));
            }
            
        }
    }
}
