﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Views;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            //Application.Run(new FrmEventRegistration(""));
            //Application.Run(new FrmEventRequests());
            //Application.Run(new FrmStudentRequests());
            //Application.Run(new FrmGuestRequests());
            //RestoreHelper("super");

            
        }
    }
}
