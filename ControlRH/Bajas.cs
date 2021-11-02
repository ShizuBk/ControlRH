using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRH
{
    public partial class Bajas : Form
    {
        Conexion conexion;
        string sqlStatement = "";
        public Bajas()
        {
            InitializeComponent();
            actualizarTabla(BajasDGV);
        }

        private void btnReingresar_Click(object sender, EventArgs e)
        {

        }
        private void actualizarTabla(DataGridView data)
        {
            conexion = new Conexion();
            sqlStatement = "select * from bajas";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement, conexion.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindingSource form = new BindingSource();
                form.DataSource = table;
                data.DataSource = form;
            }
            catch (Exception e)
            {
                e.GetType();
                MessageBox.Show("Ha ocurrido un error inesperado", "Error");
            }

            accionesTabla();
        }

        private void actualizarTabla(DataGridView data, string filter)
        {
            sqlStatement = "select * from reclutamiento where puesto='" + filter + "'";

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement, conexion.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindingSource form = new BindingSource();
                form.DataSource = table;
                data.DataSource = form;
            }
            catch (Exception e)
            {
                e.GetType();
                MessageBox.Show("Ha ocurrido un error inesperado", "Error");
            }

            accionesTabla();
        }
        private void accionesTabla()
        {
        }
    }
}
