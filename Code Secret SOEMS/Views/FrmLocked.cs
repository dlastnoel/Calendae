using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmLocked : Form
    {
        SettingsHelper sh;
        ThemeHelper th;
        DateTime time;
        byte mode;
        public FrmLocked(byte mode)
        {
            InitializeComponent();
            sh = new SettingsHelper();
            th = new ThemeHelper();
            th.setFormColor(this);
            th.setCalendae(pictureBoxCalendae);
            th.setDragPanelColor(panelTop);
            th.setGradientPanelColor(panelLeft);
            th.setControlButtonColor(btnClose);
            th.setControlButtonColor(btnMinimize);
            th.setLabelColor(lblTitle);
            th.setLabelColor(lblText);
            th.setLabelColor(lblTime);
            time = DateTime.Now.AddMinutes(double.Parse(sh.getMinutes()));

            this.mode = mode;
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = time.Subtract(DateTime.Now);
            lblTime.Text = timeSpan.ToString("mm':'ss");

            if(timeSpan.Minutes == 0 && timeSpan.Seconds == 0)
            {
                tmrCountdown.Stop();
                MessageBox.Show("You may now try to log in again", "Calendae", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                sh.unlockLogin();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                this.Close();
                new FrmLogin().Show();
            } else
            {
                this.Close();
            }
        }
    }
}
