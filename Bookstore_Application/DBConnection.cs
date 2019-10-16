using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Bookstore_Application
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        //private string query;

        public DBConnection(string server, string database, string user, string password)
        {
            setDBConnection(server, database, user, password);
        }

        public void setDBConnection(string server, string database, string user, string password)
        {
            this.server = server;
            this.database = database;
            this.user = user;
            this.password = password;

            string connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + user + ";PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server: " + server + "! Contact Administrator.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again!");
                        break;
                }
                return false;
            }
        }

        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string ExecuteNonQuery(string query)
        {
            string message = "OK"; 

            if (this.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    message = ex.Message + "Error Code: " + ex.Number;
                }
                finally
                {
                    this.closeConnection();
                }
            }

            return message;
        }

        public DataTable Select(string query)
        {
            if (this.openConnection())
            { 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                this.closeConnection();

                return dt;
            }
            else
            {
                return null;
            }

        }
    }
}
