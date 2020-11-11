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

namespace Code_Secret_SOEMS
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            ThemeHelper th = new ThemeHelper();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setLabelColor(lblTitle);
            th.setControlButtonColor(btnClose);
            th.setGroupBoxColor(groupCourses);
            th.setGroupBoxColor(groupSecurity);
            th.setGroupBoxColor(groupTheme);

            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setCheckBoxColor(checkLoginLock);
            th.setCheckBoxColor(checkDarkMode);
            th.setLabelColor(lblCourse);
            th.setLabelColor(lblInfo1);
            th.setLabelColor(lblTime);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
