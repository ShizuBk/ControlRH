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
    public partial class Practicantes : Form
    {

        Conexion conexion;
        string sqlStatement="";

        public Practicantes(){
            InitializeComponent();
            actualizarTabla(PracticantesDGV);
        }
        private void actualizarTabla(DataGridView data)
        {

            conexion = new Conexion();
            sqlStatement = "select nombre,puesto from practicantes";

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

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (solicitarPin())
            {
                conexion = new Conexion();
                string nombre, rfc, curp, puesto, nss, where;
                nombre = Nombre.Text;
                rfc = RFC.Text;
                curp = CURP.Text;
                puesto = Puesto.Text;
                nss = NIMMS.Text;



                sqlStatement = "update practicantes set rfc='" + rfc + "'," +
                    "nombre='" + nombre + "'," +
                    "curp='" + curp + "'," +
                    "puesto='" + puesto + "'," +
                    "nss='" + nss + "'," +
                    "fecha_nacimiento='" + validarFecha(TimePicker.Value.ToString(), '-') + "'";

                try
                {
                    where = " where curp='" + curp + "'";
                    conexion.executeQuery(sqlStatement + where);
                }
                catch
                {
                    try
                    {
                        where = " where rfc='" + rfc + "'";
                        conexion.executeQuery(sqlStatement + where);
                    }
                    catch
                    {
                        try
                        {
                            where = " where nombre='" + nombre + "'";
                            conexion.executeQuery(sqlStatement + where);
                        }
                        catch
                        {
                            MessageBox.Show("No se pudo encontrar el registro");
                        }
                    }
                }
                MessageBox.Show("Se ha modificado el registro.", "Exito");
            }

        }

        private string validarFecha(string fecha, char formato) //Poner formato de fecha
        {
            string ret = "";
            try
            {
                for (int i = 0; i < 10; i++)
                {

                    ret = ret + fecha[i];
                }
                string[] dma = ret.Split('/');
                if (formato == '-')
                {
                    ret = dma[2] + "-" + dma[1] + "-" + dma[0];
                }
                else
                {
                    ret = dma[0] + "/" + dma[1] + "/" + dma[2];
                }
            }
            catch { return ""; }
            return ret;
        }

        private void PracticantesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conexion = new Conexion();
            try
            {
                string selected = PracticantesDGV.CurrentRow.Cells[0].Value.ToString();
                sqlStatement = "select * from practicantes where nombre='" + selected + "'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement, conexion.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                Nombre.Text = table.Rows[0]["Nombre"].ToString();
                RFC.Text = table.Rows[0]["RFC"].ToString();
                CURP.Text = table.Rows[0]["CURP"].ToString();
                Puesto.Text = table.Rows[0]["Puesto"].ToString();
                TimePicker.Text = table.Rows[0]["Fecha_nacimiento"].ToString();
                Telefono.Text = table.Rows[0]["Telefono"].ToString();
                NIMMS.Text = table.Rows[0]["NSS"].ToString();
            }
            catch
            {

            }
        }

        private void vaciarCampos()
        {
            Nombre.Text = "";
            RFC.Text = "";
            CURP.Text = "";
            Puesto.Text = "";
            TimePicker.Text = "";
            Telefono.Text = "";
            NIMMS.Text = "";
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();
            try
            {
                if (solicitarPin())
                {
                    if (Motivo.Text == "")
                    {
                        MessageBox.Show("La evaluación del practicante es obligatoria", "Aviso");
                    }
                    else
                    {
                        sqlStatement = "call BajaPrac('" + CURP.Text + "','" + Motivo.Text + "')";
                        Console.WriteLine(sqlStatement);
                        conexion.executeQuery(sqlStatement);
                        MessageBox.Show("Se han finalizado las residencias de " + Nombre.Text, "Aviso");
                        actualizarTabla(PracticantesDGV);

                        vaciarCampos();
                        Motivo.Text = "";
                    }

                }
            }
            catch
            {
                MessageBox.Show("No hay elemento seleccionado", "Error");
            }
        }
    }
}
