using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using XanderUI;
using XanderUI.Designers;

namespace Code_Secret_SOEMS.Helpers
{
    class ThemeHelper
    {
        //Retrieve properties stored
        
        //Theme
        public string getCurrentTheme()
        {
            return Properties.Settings.Default.theme;
        }

        // Dark Mode
        public bool isDark()
        {
            return Properties.Settings.Default.isDark;
        }

        public void saveTheme(string theme)
        {
            Properties.Settings.Default.theme = theme;
            Properties.Settings.Default.Save();
        }

        public void saveMode(bool mode)
        {
            Properties.Settings.Default.isDark = mode;
            Properties.Settings.Default.Save();
        }
        public void saveBoth(string theme, bool mode)
        {
            Properties.Settings.Default.theme = theme;
            Properties.Settings.Default.isDark = mode; ;
            Properties.Settings.Default.Save();
        }

        // Sets color of Form
        public void setFormColor(Form myForm)
        {
            if (isDark())
            {
                myForm.BackColor = Color.FromArgb(51, 51, 51);
            } else
            {
                myForm.BackColor = Color.White;
            }
        }

        // Set App Logo based from theme
        public void setCalendae(PictureBox myPictureBox)
        {
            if (isDark())
            {
                myPictureBox.Image = Properties.Resources.calendae_white;
            }
            else
            {
                myPictureBox.Image = Properties.Resources.calendae;
            }
        }

        // Set Team Logo based from theme
        public void setCodeSecret(PictureBox myPictureBox)
        {
            if (isDark())
            {
                myPictureBox.Image = Properties.Resources.code_secret_white;
            }
            else
            {
                myPictureBox.Image = Properties.Resources.code_secret;
            }
        }


        // Set User Control (mini forms) color
        public void setUserControlColor(UserControl myUserControl)
        {
            if (isDark())
            {
                myUserControl.BackColor = Color.FromArgb(51, 51, 51);
            }
            else
            {
                myUserControl.BackColor = Color.White;
            }
        }

        // Sets color for panels (based on theme)
        public void setPanelColor(Panel myPanel)
        {
            if (isDark())
            {
                myPanel.BackColor = Color.FromArgb(51, 51, 51);
            } else
            {
                switch (getCurrentTheme())
                {
                    case "Dark Orange":
                        myPanel.BackColor = Color.DarkOrange;
                        break;
                    case "Cool Blue":
                        myPanel.BackColor = Color.FromArgb(96, 120, 234);
                        break;
                    case "Hot Pink":
                        myPanel.BackColor = Color.FromArgb(211, 32, 139);
                        break;
                    case "Mint Green":
                        myPanel.BackColor = Color.FromArgb(87, 202, 133);
                        break;
                    case "Peru":
                        myPanel.BackColor = Color.Peru;
                        break;
                    case "Candy Red":
                        myPanel.BackColor = Color.FromArgb(192, 0, 0);
                        break;

                }
            }
        }

        // Sets color for drag panel (either white or black)
        public void setDragPanelColor(Panel myPanel)
        {
            if (isDark())
            {
                myPanel.BackColor = Color.FromArgb(51, 51, 51);
            }
            else
            {
                myPanel.BackColor = Color.White;
            }
        }

        // Sets color for status strip (either white or black)
        public void setStripStatusColor(StatusStrip myStatusStrip)
        {
            if (isDark())
            {
                myStatusStrip.BackColor = Color.FromArgb(51, 51, 51);
            } else
            {
                myStatusStrip.BackColor = Color.White;
            }
        }

        // Sets the gradient color for the left panel of the main form
        public void setGradientPanelColor(XUIGradientPanel myPanel)
        {
            if (isDark())
            {
                myPanel.BottomLeft = Color.FromArgb(51, 51, 51);
                myPanel.BottomRight = Color.FromArgb(51, 51, 51);
                myPanel.TopLeft = Color.FromArgb(51, 51, 51);
                myPanel.TopRight = Color.FromArgb(51, 51, 51);
            }
            else
            {
                switch (getCurrentTheme())
                {
                    case "Dark Orange":
                        myPanel.BottomLeft = Color.FromName("Red");
                        myPanel.BottomRight = Color.FromName("Gold");
                        myPanel.TopLeft = Color.FromName("Gold");
                        myPanel.TopRight = Color.FromName("Red");
                        break;
                    case "Cool Blue":
                        myPanel.BottomLeft = Color.FromArgb(23, 234, 217);
                        myPanel.BottomRight = Color.FromArgb(96, 120, 234);
                        myPanel.TopLeft = Color.FromArgb(23, 234, 217);
                        myPanel.TopRight = Color.FromArgb(96, 120, 234);
                        break;
                    case "Hot Pink":
                        myPanel.BottomLeft = Color.FromArgb(211, 32, 139);
                        myPanel.BottomRight = Color.FromArgb(253, 160, 0);
                        myPanel.TopRight = Color.FromArgb(211, 32, 139);
                        myPanel.TopLeft = Color.FromArgb(135, 154, 242);
                        break;
                    case "Mint Green":
                        myPanel.BottomLeft = Color.FromArgb(24, 78, 104);
                        myPanel.BottomRight = Color.FromArgb(87, 202, 133);
                        myPanel.TopRight = Color.FromArgb(87, 202, 133);
                        myPanel.TopLeft = Color.FromArgb(24, 78, 104);
                        break;
                    case "Peru":
                        myPanel.BottomLeft = Color.FromArgb(255, 255, 192);
                        myPanel.BottomRight = Color.FromArgb(255, 255, 192);
                        myPanel.TopRight = Color.FromArgb(255, 128, 0);
                        myPanel.TopLeft = Color.FromArgb(255, 128, 0);
                        break;
                    case "Candy Red":
                        myPanel.BottomLeft = Color.Red;
                        myPanel.BottomRight = Color.Red;
                        myPanel.TopRight = Color.FromArgb(64, 0, 64);
                        myPanel.TopLeft = Color.Red;
                        break;

                }
            }
        }

        // Sets color for group box (either white or black)
        public void setGroupBoxColor(GroupBox myGroupBox)
        {
            if (isDark())
            {
                myGroupBox.ForeColor = Color.White;
            } else
            {
                myGroupBox.ForeColor = Color.Black;
            }
        }


        // Sets color for buttons (based from theme)
        public void setButtonColor(Button myButton)
        {
            switch (getCurrentTheme())
            {
                case "Dark Orange":
                    myButton.BackColor = Color.DarkOrange;
                    break;
                case "Cool Blue":
                    myButton.BackColor = Color.FromArgb(96, 120, 234);
                    break;
                case "Hot Pink":
                    myButton.BackColor = Color.FromArgb(211, 32, 139);
                    break;
                case "Mint Green":
                    myButton.BackColor = Color.FromArgb(87, 202, 133);
                    break;
                case "Peru":
                    myButton.BackColor = Color.Peru;
                    break;
                case "Candy Red":
                    myButton.BackColor = Color.FromArgb(192, 0, 0);
                    break;
            }
        }

        // Sets the hover color for the icon buttons (based from theme)
        public void setIconButtonColor(IconButton myButton)
        {
            switch (getCurrentTheme())
            {
                case "Dark Orange":
                    myButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 125, 0);
                    break;
                case "Cool Blue":
                    myButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 107, 210);
                    break;
                case "Hot Pink":
                    myButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 32, 139);
                    break;
                case "Mint Green":
                    myButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 202, 133);
                    break;
                case "Peru":
                    myButton.FlatAppearance.MouseOverBackColor = Color.Peru;
                    break;
                case "Candy Red":
                    myButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
                    break;
            }
        }

        // Sets the color for control buttons (either white or black)
        public void setControlButtonColor(Button myButton)

        {
            if (isDark())
            {
                myButton.BackColor = Color.FromArgb(51, 51, 51);
                myButton.ForeColor = Color.White;
            }
            else
            {
                myButton.BackColor = Color.Transparent;
                myButton.ForeColor = Color.Black;
            }
        }

        // Sets the color for labels (either white or black)
        public void setLabelColor(Label myLabel)
        {
            if (isDark())
            {
                myLabel.ForeColor = Color.White;
            }
            else
            {
                myLabel.ForeColor = Color.Black;
            }
        }

        // Sets the color for labels inside status strips (either white or black)
        public void setToolStripStatusLabelColor(ToolStripStatusLabel myToolStripStatusLabel)
        {
            if (isDark())
            {
                myToolStripStatusLabel.ForeColor = Color.White;
            } else
            {
                myToolStripStatusLabel.ForeColor = Color.Black;
            }
        }

        // Sets the color for radio buttons (either white or black)
        public void setRadioButtonColor(RadioButton myRadioButton)
        {
            if (isDark())
            {
                myRadioButton.ForeColor = Color.White;
            }
            else
            {
                myRadioButton.ForeColor = Color.Black;
            }
        }

        // Sets the color for check box (either white or black)
        public void setCheckBoxColor(CheckBox myCheckBox)
        {
            if (isDark())
            {
                myCheckBox.ForeColor = Color.White;
            }
            else
            {
                myCheckBox.ForeColor = Color.Black;
            }
        }
    }
}
