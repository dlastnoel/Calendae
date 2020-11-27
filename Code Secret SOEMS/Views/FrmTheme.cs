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
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS
{
    public partial class FrmTheme : Form
    {
        SettingsPresenter settingsPresenter;
        ThemeHelper th;
        private void setFormTheme()
        {
            th = new ThemeHelper();
            th.setFormColor(this);
            th.setDragPanelColor(panelTop);
            th.setLabelColor(lblTitle);
            th.setControlButtonColor(btnClose);
            th.setCheckBoxColor(checkDarkMode);
            th.setButtonColor(btnThemeApply);
        }
        public FrmTheme()
        {
            InitializeComponent();
            setFormTheme();
            settingsPresenter = new SettingsPresenter();

            checkDarkMode.Checked = settingsPresenter.getCurrentMode();
            cmbTheme.SelectedIndex = cmbTheme.FindStringExact(settingsPresenter.getCurrentTheme());
        }

        private void btnThemeApply_Click(object sender, EventArgs e)
        {
            if(cmbTheme.Text != settingsPresenter.getCurrentTheme() && checkDarkMode.Checked != settingsPresenter.getCurrentMode())
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
            MessageBox.Show("Theme applied successfully", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setFormTheme();
            this.Close();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
