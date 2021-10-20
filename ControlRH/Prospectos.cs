using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ControlRH
{
    public partial class Prospectos : Form
    {

        //Conexión con la base de datos
        string SQLsentence = "";
        static string cadenaConexion = "Database=controlrh; Data Source=localhost; User Id=root; Password=1234";
        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
        MySqlDataReader reader = null;
        
       
    



        public Prospectos()
        {
            InitializeComponent();

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            SQLsentence="insert into reclutamiento (nombre,telefono,puesto) values ('"+Nombre.Text+"','"+Telefono.Text+"','"+Puesto.Text+"')";
            MySqlCommand command = new MySqlCommand(SQLsentence);
            try
            {
                command.Connection = conexionBD;
                conexionBD.Open();
                reader = command.ExecuteReader();
                conexionBD.Close();

                MessageBox.Show("Se ha agregado el registro con exito.", "Registro exitoso");
                
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al ingresar los datos.","Error");
            }

        }
    }
}
