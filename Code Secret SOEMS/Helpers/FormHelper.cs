using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Code_Secret_SOEMS.Views;

namespace Code_Secret_SOEMS.Helpers
{
    class FormHelper
    {
        // Compares input password and confirm password
        // Sets the message into label
        // myLabel - label for the message

        private static int event_id;
        private static Form currentForm;
        private static UserControl currentUserControl;
        private static Label currentLabel;

        ThemeHelper th = new ThemeHelper();

        public void setEventID(int currentID)
        {
            event_id = currentID;
        }

        public int getEventID()
        {
            return event_id;
        }
        public void setCurrentForm(Form myForm)
        {
            currentForm = myForm;
        }

        public void setCurrentUserControl(UserControl userControl)
        {
            currentUserControl = userControl;
        }

        public UserControl getCurrentUserControl()
        {
            return currentUserControl;
        }

        public void setCurrentLabel(Label myLabel)
        {
            currentLabel = myLabel;
        }

        public UserControl setUserControl(string userControl, string position)
        {
            try
            {
                currentForm.Controls.Remove(currentUserControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                switch (userControl)
                {
                    case "Dashboard":
                        currentUserControl = new CtrlDashboard();
                        break;
                    case "Officers":
                        currentUserControl = new CtrlOfficers();
                        break;
                    case "Events":
                        currentUserControl = new CtrlEvents(position);
                        break;
                    case "Event Details":
                        currentUserControl = new CtrlEventDetails(this.getEventID());
                        break;
                    case "Students":
                        currentUserControl = new CtrlStudents();
                        break;
                    case "Guests":
                        currentUserControl = new CtrlGuests();
                        break;
                }
                if(th.isDark())
                {
                    currentUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                } else
                {
                    currentUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
                currentUserControl.Location = new System.Drawing.Point(294, 51);
                currentUserControl.Name = "Current Form";
                if(currentForm.WindowState == FormWindowState.Maximized)
                {
                    currentUserControl.Size = new System.Drawing.Size(1576, 956);
                } else
                {
                    currentUserControl.Size = new System.Drawing.Size(940, 614);
                }
                currentForm.Controls.Add(currentUserControl);
                currentLabel.Text = userControl;
            }
            return currentUserControl;
        }
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
