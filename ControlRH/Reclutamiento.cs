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
            actualizarTabla();
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
            actualizarTabla();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            sqlStatement = "insert into reclutamiento (nombre,telefono,puesto) values ('" + Nombre.Text + "','" + Telefono.Text + "','" + Puesto.Text + "')";
            reader=conexion.executeQuery(sqlStatement);
            if (reader != null)
            {
                MessageBox.Show("Se ha agregado el registro con exito.", "Registro exitoso");
                actualizarTabla();
            }
            
        }


        private void actualizarTabla()
        {

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from reclutamiento",conexion.GetConnection());
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            this.listView1.Items.Clear();
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow filas = dataTable.Rows[i];
                ListViewItem item = new ListViewItem(filas["Nombre"].ToString());
                for (int j = 0; j < dataTable.Columns.Count; j++) {

                    DataColumn columnas = dataTable.Columns[j];
                    item.SubItems.Add(columnas.ToString());
                    
                }
            
                
               
                listView1.Items.Add(item);
            }
        }
    }
}
