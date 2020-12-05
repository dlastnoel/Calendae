using System;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS
{
    public partial class FrmSettings : Form
    {
        private SettingsPresenter settingsPresenter;
        private ThemeHelper th;

        private void setFormTheme()
        {
            th = new ThemeHelper();
            settingsPresenter = new SettingsPresenter();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setGroupBoxColor(groupSecurity);
            th.setGroupBoxColor(groupTheme);
            th.setButtonColor(btnSecurityApply);
            th.setButtonColor(btnThemeApply);
        }

        public FrmSettings()
        {
            InitializeComponent();
            setFormTheme();

            checkLoginLock.Checked = settingsPresenter.isLoginLocked();
            checkDarkMode.Checked = settingsPresenter.getCurrentMode();
            cmbTheme.SelectedIndex = cmbTheme.FindStringExact(settingsPresenter.getCurrentTheme());
            txtTime.Text = settingsPresenter.getMinutes();

            if (checkLoginLock.Checked)
            {
                txtTime.ReadOnly = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemeApply_Click(object sender, EventArgs e)
        {
            if (cmbTheme.Text != settingsPresenter.getCurrentTheme() && checkDarkMode.Checked != settingsPresenter.getCurrentMode())
            {
                settingsPresenter.applyBoth(cmbTheme.Text, checkDarkMode.Checked);
            }
            else if (cmbTheme.Text == settingsPresenter.getCurrentTheme() && checkDarkMode.Checked != settingsPresenter.getCurrentMode())
            {
                settingsPresenter.applyMode(checkDarkMode.Checked);
            }
            else if (cmbTheme.Text != settingsPresenter.getCurrentTheme() && checkDarkMode.Checked == settingsPresenter.getCurrentMode())
            {
                settingsPresenter.applyTheme(cmbTheme.Text);
            }
            MessageBox.Show("Theme applied successfully", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setFormTheme();
        }

        private void btnSecurityApply_Click(object sender, EventArgs e)
        {
            if(checkLoginLock.Checked != settingsPresenter.isLoginLocked())
            {
                if(checkLoginLock.Checked)
                {
                    if(!String.IsNullOrEmpty(txtTime.Text))
                    {
                        settingsPresenter.enableLoginLock(byte.Parse(txtTime.Text));
                    } else
                    {
                        MessageBox.Show("Time cannot be empty", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    settingsPresenter.disableLoginLock();
                }
            }
            MessageBox.Show("Login lock enabled successfully", "Setings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkLoginLock_CheckedChanged(object sender, EventArgs e)
        {
            if(checkLoginLock.Checked)
            {
                txtTime.ReadOnly = false;
            } else
            {
                txtTime.ReadOnly = true;
            }
        }
    }
}
