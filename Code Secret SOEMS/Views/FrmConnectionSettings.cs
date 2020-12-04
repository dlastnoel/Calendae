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
    public partial class FrmConnectionSettings : Form
    {
        SettingsHelper sh;
        DatabaseHelper dh;
        ThemeHelper th;

        public FrmConnectionSettings()
        {

            InitializeComponent();
            sh = new SettingsHelper();
            th = new ThemeHelper();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setButtonColor(btnTest);
            th.setButtonColor(btnSave);
            th.setLabelColor(lblServer);
            th.setLabelColor(lblPort);
            th.setLabelColor(lblUser);
            th.setLabelColor(lblPassword);
            th.setLabelColor(lblInfo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtServer.Text) && !String.IsNullOrEmpty(txtUser.Text) &&
                !String.IsNullOrEmpty(txtPort.Text))
            {
                sh.setConnectionSettings(txtServer.Text, txtUser.Text, txtPort.Text, txtPassword.Text);

                MessageBox.Show("Connection settings updated successfully", "Connection Settings", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            } else if(String.IsNullOrEmpty(txtServer.Text) && String.IsNullOrEmpty(txtUser.Text) &&
                String.IsNullOrEmpty(txtPort.Text) && String.IsNullOrEmpty(txtPassword.Text))
            {
                sh.setDefaultConnectionSettings();
                MessageBox.Show("Connection settings reverted to default", "Connection Settings", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Please fill up the fields correctly", "Connection Settings", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtServer.Text) && !String.IsNullOrEmpty(txtUser.Text) &&
                !String.IsNullOrEmpty(txtPort.Text))
            {
                dh = new DatabaseHelper(txtServer.Text, txtUser.Text, txtPort.Text, txtPassword.Text);
                if(dh.testConnection())
                {
                    MessageBox.Show("Test connection succeeded", "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Test connection failed", "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Please fill up the fields correctly", "Connection Settings", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
