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
        public FrmConnectionSettings()
        {
            InitializeComponent();
            ThemeHelper th = new ThemeHelper();
            th.setFormColor(this);
            th.setDragPanelColor(panelTop);
            th.setControlButtonColor(btnClose);
            th.setLabelColor(lblTitle);
            th.setLabelColor(lblServer);
            th.setLabelColor(lblPort);
            th.setLabelColor(lblUser);
            th.setLabelColor(lblPassword);
            th.setLabelColor(lblInfo1);
            th.setLabelColor(lblInfo2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
