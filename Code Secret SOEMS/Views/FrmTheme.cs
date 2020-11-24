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
        ThemePresenter themePresenter = new ThemePresenter();
        private void setFormTheme()
        {
            ThemeHelper th = new ThemeHelper();
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

            checkDarkMode.Checked = themePresenter.getCurrentMode();
            cmbTheme.SelectedIndex = cmbTheme.FindStringExact(themePresenter.getCurrentTheme());
        }

        private void btnThemeApply_Click(object sender, EventArgs e)
        {
            if(cmbTheme.Text != themePresenter.getCurrentTheme() && checkDarkMode.Checked != themePresenter.getCurrentMode())
            {
                themePresenter.applyBoth(cmbTheme.Text, checkDarkMode.Checked);
            } 
            else if (cmbTheme.Text == themePresenter.getCurrentTheme() && checkDarkMode.Checked != themePresenter.getCurrentMode())
            {
                themePresenter.applyMode(checkDarkMode.Checked);
            }
            else if (cmbTheme.Text != themePresenter.getCurrentTheme() && checkDarkMode.Checked == themePresenter.getCurrentMode())
            {
                themePresenter.applyTheme(cmbTheme.Text);
            }
            MessageBox.Show("Theme applied successfully", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setFormTheme();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
