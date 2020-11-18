using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS
{
    public partial class CtrlOfficers : UserControl
    {
        private OfficerPresenter officerPresenter = new OfficerPresenter();
        public CtrlOfficers()
        {
            InitializeComponent();
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            new FrmOfficers().ShowDialog();
        }

        private void CtrlOfficers_SizeChanged(object sender, EventArgs e)
        {
            if(this.Size == new Size(940, 614))
            {
                btnOpenForm.Show();
            } else
            {
                btnOpenForm.Hide();
            }
        }

        private void CtrlOfficers_Load(object sender, EventArgs e)
        {
            ThemeHelper th = new ThemeHelper();
            th.setUserControlColor(this);
            th.setGroupBoxColor(groupPersonalInfo);
            th.setGroupBoxColor(groupSchoolInfo);
            th.setGroupBoxColor(groupSecurity);
            th.setButtonColor(btnOpenForm);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setRadioButtonColor(rbnMale);
            th.setRadioButtonColor(rbnFemale);

            th.setLabelColor(lblFirstName);
            th.setLabelColor(lblMiddleName);
            th.setLabelColor(lblLastName);
            th.setLabelColor(lblAddress);
            th.setLabelColor(lblContactNo);
            th.setLabelColor(lblEmailAddress);
            th.setLabelColor(lblIDNo);
            th.setLabelColor(lblCourse);
            th.setLabelColor(lblYearAndSection);
            th.setLabelColor(lblPassword);
            th.setLabelColor(lblConfirmPassword);

            officerPresenter.loadOfficers(dataOfficers);
        }
    }
}
