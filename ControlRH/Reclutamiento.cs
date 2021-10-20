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
    public partial class Reclutamiento : Form
    {
        Conexion conexion = new Conexion();
        private string sqlStatement = "";
        private MySqlDataReader reader = null;



        public Reclutamiento()
        {
            InitializeComponent();
            actualizarTabla(ReclutamientoDGV);
        }


        private void botonAceptar_Click(object sender, EventArgs e)
        {


            

        }

        private void botonRechazar_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reclutamiento_Load(object sender, EventArgs e)
        {
            actualizarTabla(ReclutamientoDGV);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            sqlStatement = "insert into reclutamiento (nombre,telefono,puesto) values ('" + Nombre.Text + "','" + Telefono.Text + "','" + Puesto.Text + "')";
            reader=conexion.executeQuery(sqlStatement);
            if (reader != null)
            {
                MessageBox.Show("Se ha agregado el registro con exito.", "Registro exitoso");
                actualizarTabla(ReclutamientoDGV);
            }
            
        }


        private void actualizarTabla(DataGridView data)
        {
            sqlStatement = "select * from reclutamiento";
            
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement,conexion.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindingSource form = new BindingSource();
                form.DataSource = table;
                data.DataSource = form;
            }
            catch(Exception e)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error");
            }
        }

        private void ReclutamientoDGV_Load(object sender, DataGridViewCellEventArgs e)
        {
            actualizarTabla(ReclutamientoDGV);
        }
    }

   
    }
