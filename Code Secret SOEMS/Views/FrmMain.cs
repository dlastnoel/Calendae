using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Views;

namespace Code_Secret_SOEMS
{
    public partial class FrmMain : Form
    {
        FormHelper fh;
        private static UserControl currentUserControl;
        private string position;
        private string name;
        public int event_id { get; set; }

        private void setUserControl(string userControl)
        {
            fh.setCurrentForm(this);
            fh.setCurrentLabel(lblTitle);
            currentUserControl = fh.setUserControl(userControl, position);
            fh.setCurrentUserControl(currentUserControl);
        }
        /*private void setUserControl(string userControl)
        {
            fh = new FormHelper();
            try
            {
                this.Controls.Remove(currentUserControl);
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
                        currentUserControl = new CtrlEventDetails(fh.getEventID());
                        break;
                    case "Students":
                        currentUserControl = new CtrlStudents();
                        break;
                    case "Guests":
                        currentUserControl = new CtrlGuests();
                        break;
                }
                currentUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                currentUserControl.Location = new System.Drawing.Point(294, 51);
                currentUserControl.Name = "Current Form";
                currentUserControl.Size = new System.Drawing.Size(940, 614);
                this.Controls.Add(currentUserControl);
                lblTitle.Text = userControl;
            }
        }*/

        private void triggerMaximize()
        {
            currentUserControl = fh.getCurrentUserControl();
            if (this.WindowState == FormWindowState.Maximized)
            {
                currentUserControl.Size = new Size(940, 614);
                WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
            else
            {
                if (Screen.GetBounds(this).Width >= 1920)
                {
                    currentUserControl.Size = new Size(1576, 956);
                }
                WindowState = FormWindowState.Maximized;
            }
        }

        private void setUserControlSize(FormWindowState myFormWindowState)
        {
            currentUserControl = fh.getCurrentUserControl();
            if (myFormWindowState == FormWindowState.Maximized)
            {
                if(Screen.GetBounds(this).Width >= 1920)
                {
                    
                    currentUserControl .Size = new Size(1576, 956);
                }
                else
                {
                    currentUserControl.Size = new Size(940, 614);
                }
            } else
            {
                currentUserControl.Size = new Size(940, 614);
            }
        }

        private void setFormTheme()
        {
            ThemeHelper th = new ThemeHelper();
            th.setFormColor(this);
            th.setDragPanelColor(panelTop);
            th.setGradientPanelColor(panelLeft);
            th.setControlButtonColor(btnMinimize);
            th.setControlButtonColor(btnMaximize);
            th.setControlButtonColor(btnClose);
            th.setIconButtonColor(btnDashboard);
            th.setIconButtonColor(btnOfficers);
            th.setIconButtonColor(btnEvents);
            th.setIconButtonColor(btnStudents);
            th.setIconButtonColor(btnGuests);
            th.setIconButtonColor(btnOfficers);
            th.setIconButtonColor(btnSettings);
            th.setLabelColor(lblTitle);
            th.setStripStatusColor(statusStripMain);
            th.setToolStripStatusLabelColor(toolStripStatusOfficer);
            th.setToolStripStatusLabelColor(toolStripStatusDate);
            th.setToolStripStatusLabelColor(toolStripStatusTime);

        }
        public FrmMain(string position, string name)
        {
            InitializeComponent();
            setFormTheme();
            fh = new FormHelper();
            this.position = position;
            this.name = name;
            toolStripStatusOfficer.Text = this.position + ": " + this.name;

            if(position != "Adviser")
            {
                btnOfficers.Hide();
                btnSettings.Location = btnGuests.Location;
                btnGuests.Location = btnStudents.Location;
                btnStudents.Location = btnEvents.Location;
                btnEvents.Location = btnOfficers.Location;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Logout?", "Calendae", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (prompt == DialogResult.Yes) {
                this.Hide();
                new FrmLogin().Show();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            currentUserControl = fh.getCurrentUserControl();
            triggerMaximize();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            toolStripStatusTime.Text = DateTime.Now.ToString("T");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            setUserControl("Dashboard");
            currentUserControl.Size = new Size(940, 614);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            setUserControl("Dashboard");
            if(this.WindowState == FormWindowState.Maximized && Screen.GetBounds(this).Width == 1920)
            {
                currentUserControl.Size = new Size(1576, 956);
            } else
            {
                currentUserControl.Size = new Size(940, 614);
            }
            
        }

        private void btnOfficers_Click(object sender, EventArgs e)
        {
            setUserControl("Officers");
            if (this.WindowState == FormWindowState.Maximized && Screen.GetBounds(this).Width == 1920)
            {
                currentUserControl.Size = new Size(1576, 956);
            }
            else
            {
                currentUserControl.Size = new Size(940, 614);
            }
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            setUserControl("Events");
            if (this.WindowState == FormWindowState.Maximized && Screen.GetBounds(this).Width == 1920)
            {
                currentUserControl.Size = new Size(1576, 956);
            }
            else
            {
                currentUserControl.Size = new Size(940, 614);
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            setUserControl("Students");
            if (this.WindowState == FormWindowState.Maximized && Screen.GetBounds(this).Width == 1920)
            {
                currentUserControl.Size = new Size(1576, 956);
            }
            else
            {
                currentUserControl.Size = new Size(940, 614);
            }
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            setUserControl("Guests");
            if (this.WindowState == FormWindowState.Maximized && Screen.GetBounds(this).Width == 1920)
            {
                currentUserControl.Size = new Size(1576, 956);
            }
            else
            {
                currentUserControl.Size = new Size(940, 614);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if(position == "Adviser")
            {
                new FrmSettings().ShowDialog();
            } else
            {
                new FrmTheme().ShowDialog();
            }
            setFormTheme();
            setUserControl(lblTitle.Text);
            setUserControlSize(this.WindowState);
        }

        private void panelTop_DoubleClick(object sender, EventArgs e)
        {
            triggerMaximize();
        }
    }
}
