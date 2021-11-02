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
    public partial class Empleados : Form
    {
        Conexion conexion;
        String sqlStatement = "";
        public Empleados()
        {
            InitializeComponent();
            actualizarTabla(EmpleadosDGV);
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (solicitarPin())
            {
                conexion = new Conexion();
                string nombre, rfc, curp, sueldo, puesto, where;
                nombre = Nombre.Text;
                rfc = RFC.Text;
                curp = CURP.Text;
                sueldo = Sueldo.Text;
                puesto = Puesto.Text;



                sqlStatement = "update empleados set rfc='" + rfc + "'," +
                    "nombre='" + nombre + "'," +
                    "curp='" + curp + "'," +
                    "sueldo='" + sueldo + "'," +
                    "puesto='" + puesto + "'," +
                    "fecha_nacimiento='" + validarFecha(TimePicker.Value.ToString()) + "'";

                try
                {
                    where = " where rfc='" + rfc + "'";
                    conexion.executeQuery(sqlStatement + where);
                }
                catch
                {
                    try
                    {
                        where = " where curp='" + curp + "'";
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

        private bool solicitarPin()
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

        private string validarFecha(string fecha)
        {
            string ret = "";

            for(int i = 0; i <10;i++){
                
                    ret = ret + fecha[i];                    
            }
            string[] dma = ret.Split('/');
            ret = dma[2] + "-" + dma[1] + "-" + dma[0];
            return ret;
        }

        private void actualizarTabla(DataGridView data)
        {
            conexion = new Conexion();
            sqlStatement = "select nombre,puesto from empleados";

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
        private void accionesTabla() { 
        }

        private void EmpleadosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conexion = new Conexion();
            string selected = EmpleadosDGV.CurrentRow.Cells[0].Value.ToString();
            sqlStatement = "select * from empleados where nombre='"+selected+"'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlStatement, conexion.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            Nombre.Text = table.Rows[0]["Nombre"].ToString();
            RFC.Text = table.Rows[0]["RFC"].ToString();
            CURP.Text = table.Rows[0]["CURP"].ToString();
            Puesto.Text = table.Rows[0]["Puesto"].ToString();
            Sueldo.Text = table.Rows[0]["Sueldo"].ToString();
            DiasContrato.Text = table.Rows[0]["Dias_contrato"].ToString();
            FechaIngreso.Text = table.Rows[0]["Fecha_ingreso"].ToString();
        }

        private void btnTContrato_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Prueba");
            
                Fecha fecha = new Fecha();
                if (fecha.ShowDialog() == DialogResult.OK)
                {
                    DateTime dt = fecha.GetDate(), di = DateTime.Parse(FechaIngreso.Text), dr;
                    double asdf=dt.Subtract(di).TotalDays;
                
                    
                int ffff = ((int)asdf);
                MessageBox.Show(ffff.ToString());
                }
            
        }
    }
}
