using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Code_Secret_SOEMS.Helpers
{
    class FormHelper
    {
        // Compares input password and confirm password
        // Sets the message into label
        // myLabel - label for the message
        public void passwordMessage(string password, string confirmPassword, Label myLabel)
        {
            if(password == confirmPassword)
            {
                if(password.Length >= 8)
                {
                    myLabel.Text = "Password matched";
                    myLabel.ForeColor = Color.Green;
                } else
                {
                    myLabel.Text = "Password should be atleast 8 char(s) long";
                    myLabel.ForeColor = Color.Red;
                }
            } else
            {
                myLabel.Text = "Password mismatch";
                myLabel.ForeColor = Color.Red;
            }
        }
    }
}
