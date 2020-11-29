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
        // DB connection fields
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string port;
        private string password;
        private MySqlCommand commandQuery;
        private MySqlDataReader sqlDataReader;


        // Default constructor
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

        // Test constructor
        public DatabaseHelper(string server, string user, string port, string password)
        {
            this.server = server;
            this.user = user;
            database = Properties.Settings.Default.database;
            this.port = port;
            this.password = password;
            connection = new MySqlConnection
                ("SERVER=" + this.server + ";DATABASE=" + this.database + ";USER=" + this.user + 
                ";PORT=" + this.port + ";PASSWORD=" + this.password + ";");
        }

        // Tests connection settings and returns result as string
        public string testConnection()
        {
            string message;
            try
            {
                openConnection();
                message = "Test connection succeeded";
                closeConnection();
            }
            catch
            {
                message = "Test connection failed";
            }

            return message;
        }

        // Open MySQL Connection
        public void openConnection()
        {
            connection.Open();
        }

        // Close MySQL Connection
        public void closeConnection()
        {
            connection.Close();
        }

        // Creates command query
        public void createQuery(string query)
        {
            openConnection();

            commandQuery = new MySqlCommand(query, connection);

            closeConnection();
        }

        // Binds parameters from commannd query if any
        // param - parameter name
        // value - parameter value
        public void bindParam(string param, dynamic value)
        {
            openConnection();

            commandQuery.Parameters.AddWithValue(param, value);

            closeConnection();
        }

        // Executes command query
        public void executeQuery()
        {
            openConnection();

            commandQuery.ExecuteNonQuery();

            closeConnection();
        }

        // Tests command query if readable by sqlDataReader
        // Returns result as bool
        public bool executeReader()
        {
            bool reader;
            openConnection();
            sqlDataReader = commandQuery.ExecuteReader();
            if (sqlDataReader.Read())
            {
                reader = true;
            } else
            {
                reader = false;
            }
            closeConnection();
            return reader;
        }

        // Extracts value from reader
        // item - field from reader to be read
        public string getFromReader(string item)
        {
            string data = "";
            openConnection();

            sqlDataReader = commandQuery.ExecuteReader();
            if(sqlDataReader.Read())
            {
                data = sqlDataReader[item].ToString();
            }

            closeConnection();

            return data;
        }

        public List<string> getResultList(string item)
        {
            List<string> myList = new List<string>();
            openConnection();
            sqlDataReader = commandQuery.ExecuteReader();
            while(sqlDataReader.Read())
            {
                myList.Add(sqlDataReader[item].ToString());
            }
            closeConnection();

            return myList;
        }

        // Executes command query and populates dataGridView
        // myDataGridView - dataGridView to be populated
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
