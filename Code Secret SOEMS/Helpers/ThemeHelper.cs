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
    public class ThemeHelper
    {
        public string getCurrentTheme()
        {
            return Properties.Settings.Default.Theme;
        }

        private bool isDark()
        {
            return Properties.Settings.Default.isDark;
        }

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

        public void setPanelColor(Panel myPanel)
        {
            if (isDark())
            {
                myPanel.BackColor = Color.FromArgb(51, 51, 51);
            } else
            {
                myPanel.BackColor = Color.FromName(getCurrentTheme());
            }
        }

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
                    case "DarkOrange":
                        myPanel.BottomLeft = Color.FromName("Red");
                        myPanel.BottomRight = Color.FromName("Gold");
                        myPanel.TopLeft = Color.FromName("Gold");
                        myPanel.TopRight = Color.FromName("Red");
                        break;

                    case "LightCoral":
                        myPanel.BottomLeft = Color.FromName("IndianRed");
                        myPanel.BottomRight = Color.FromName("Violet");
                        myPanel.TopLeft = Color.FromName("Violet");
                        myPanel.TopRight = Color.FromName("IndianRed");
                        break;
                }
            }
        }

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

        public void setButtonColor(Button myButton)
        {
            myButton.BackColor = Color.FromName(getCurrentTheme());
        }

        public void setIconButtonColor(IconButton myButton)
        {
            switch (getCurrentTheme())
            {
                case "DarkOrange":
                    myButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 125, 0);
                    break;
            }
        }

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
