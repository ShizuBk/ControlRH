using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRH
{


    class Conexion
    {
        static string connectionString = "Database=controlrh; Data Source=localhost; User Id=root; Password=1234";
        private MySqlConnection connection;
        private MySqlCommand command = new MySqlCommand();
        private MySqlDataReader reader = null;
        public Conexion()
        {
            connection = new MySqlConnection(connectionString);
        }

        public Conexion(string db, string server, string user, string pass)
        {
            connectionString = "Database=" +db+"; Data Source="+server+"; User Id="+user+"; Password="+pass;
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }

        public MySqlDataReader executeQuery(string sqlStatement) {
            command.CommandText = sqlStatement;
            try
            {
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
                return reader;
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar la operación.", "Error");
                return null;
            }
        }
    }
}
