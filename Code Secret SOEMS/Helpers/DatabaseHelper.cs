using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Code_Secret_SOEMS.Helpers
{
    class DatabaseHelper
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string port;
        private string password;
        private MySqlCommand commandQuery;

        public DatabaseHelper()
        {
            server = Properties.Settings.Default.server;
            user = Properties.Settings.Default.user;
            database = Properties.Settings.Default.database;
            port = Properties.Settings.Default.port;
            password = Properties.Settings.Default.password;
            connection = new MySqlConnection
                ("SERVER=" + server + ";DATABASE=" + database + ";USER=" + user + ";PORT=" + port + ";PASSWORD=" + password + ";");
        }

        public void openConnection()
        {
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }

        public void selectData(string query)
        {
            openConnection();

            commandQuery = new MySqlCommand(query, connection);

            closeConnection();
        }

        public void populateDataGridView(DataGridView myDataGridView)
        {
            openConnection();

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(commandQuery);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            myDataGridView.DataSource = dataSet.Tables[0];

            closeConnection();

        }
    }
}
