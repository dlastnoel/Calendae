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
    public partial class FrmGuests : Form
    {
        public FrmGuests()
        {
            InitializeComponent();
            ThemeHelper th = new ThemeHelper();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setControlButtonColor(btnBack);
            th.setGroupBoxColor(groupPersonalInfo);
            th.setGroupBoxColor(groupSchoolInfo);
            th.setGroupBoxColor(groupWorkInfo);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setRadioButtonColor(rbnStudent);
            th.setRadioButtonColor(rbnWorking);
            th.setRadioButtonColor(rbnMale);
            th.setRadioButtonColor(rbnFemale);

            th.setLabelColor(lblFirstName);
            th.setLabelColor(lblMiddleName);
            th.setLabelColor(lblLastName);
            th.setLabelColor(lblAddress);
            th.setLabelColor(lblEvents);
            th.setLabelColor(lblContactNo);
            th.setLabelColor(lblEmailAddress);
            th.setLabelColor(lblSchoolName);
            th.setLabelColor(lblCourse);
            th.setLabelColor(lblYear);
            th.setLabelColor(lblWorksAt);
            th.setLabelColor(lblPosition);
        }

        private void rbnStudent_CheckedChanged(object sender, EventArgs e)
        {
            groupWorkInfo.Hide();
            groupSchoolInfo.Show();
        }

        private void rbnWorking_CheckedChanged(object sender, EventArgs e)
        {
            groupSchoolInfo.Hide();
            groupWorkInfo.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
