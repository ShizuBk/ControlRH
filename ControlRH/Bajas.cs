using MySql.Data.MySqlClient;

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
            Descripcion.Text = "";
        }

        private void btnReingresar_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();
            if (solicitarPin())
            {
                string selected = BajasDGV.CurrentRow.Cells[0].Value.ToString();
                if (rbEmp.Checked == true)
                {
                    sqlStatement = "call ReingresarEmp('" + selected + "')";
                }
                else
                {
                    sqlStatement="call EmplearPrac('"+selected + "')";
                }

                Console.WriteLine(sqlStatement);

                try
                {
                    conexion.executeQuery(sqlStatement);
                    MessageBox.Show("Se ha reingresado con exito", "Aviso");
                    actualizarTabla(BajasDGV);
                    txtDes.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error", "Error");
                }

            }
        }


        private void actualizarTabla(DataGridView data)
        {
            conexion = new Conexion();

            if (rbEmp.Checked == true)
            {
                sqlStatement = "select Nombre,Puesto,Telefono from bajasemp";
            }
            else
            {
                sqlStatement = "select Nombre,Puesto,Telefono from bajasprac";
            }

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

        private void actualizarTabla(DataGridView data,string filter)
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
            BajasDGV.Columns[0].Width = 200;
            BajasDGV.Columns[1].Width = 120;
            BajasDGV.Columns[2].Width = 120;
        }

        private void rbEmp_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTabla(BajasDGV);
            Descripcion.Text = "Motivo de baja:";
        }

        private void rbPrac_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTabla(BajasDGV);
            Descripcion.Text = "Evaluación:";
        }

        private void BajasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conexion = new Conexion();
            try
            {
                if (rbEmp.Checked == true)
                {
                    string selected = BajasDGV.CurrentRow.Cells[0].Value.ToString();
                    sqlStatement = "select motivo from bajasemp where nombre='" + selected + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement, conexion.GetConnection());
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    txtDes.Text = table.Rows[0]["motivo"].ToString();
                }
                else
                {
                    string selected = BajasDGV.CurrentRow.Cells[0].Value.ToString();
                    sqlStatement = "select evaluacion from bajasprac where nombre='" + selected + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement, conexion.GetConnection());
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    txtDes.Text = table.Rows[0]["evaluacion"].ToString();
                }
            }
            catch { }
        }

        private bool solicitarPin() //Llamada a ventana de pin
        {
            String pinSeg;
            secPin pin = new secPin();
            if (pin.ShowDialog() == DialogResult.OK)
            {
                pinSeg = pin.getPin();
                pin.Dispose();
                if (pinSeg != "1234")
                {
                    MessageBox.Show("Pin incorrecto.", "Error");
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();
            if (solicitarPin())
            {
                if (rbEmp.Checked == true)
                {
                    sqlStatement = "delete from bajasemp where nombre='" + BajasDGV.CurrentRow.Cells[0].Value.ToString() + "'";
                }
                else
                {
                    sqlStatement = "delete from bajasprac wherenombre = '" + BajasDGV.CurrentRow.Cells[0].Value.ToString() + "'";
                }

                try
                {
                    conexion.executeQuery(sqlStatement);
                    MessageBox.Show("Se ha descartado el registro", "Aviso");
                    actualizarTabla(BajasDGV);
                    txtDes.Text = "";
                }
                catch { MessageBox.Show("Ha ocurrido un error", "Error"); }
            }
        }
    }
}
