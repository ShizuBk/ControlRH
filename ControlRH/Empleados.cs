using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControlRH
{
    public partial class Empleados : Form
    {
        private Conexion conexion;
        private String sqlStatement = "";
        public Empleados()
        {
            InitializeComponent();
            actualizarTabla(EmpleadosDGV);
            DiasContrato.Text = "";
            FechaTermino.Text = "";
            FechaIngreso.Text = "";
            btnTContrato.Enabled = false;
            Motivo.Enabled = false;
            Antiguedad.Text = "";
        }

        private void Actualizar_Click(object sender, EventArgs e) //Actualizar base de datos
        {
            if (solicitarPin())
            {
                conexion = new Conexion();
                string nombre, rfc, curp, sueldo, puesto,nss, where;
                nombre = Nombre.Text;
                rfc = RFC.Text;
                curp = CURP.Text;
                sueldo = Sueldo.Text;
                puesto = Puesto.Text;
                nss = NIMMS.Text;



                sqlStatement = "update empleados set rfc='" + rfc + "'," +
                    "nombre='" + nombre + "'," +
                    "curp='" + curp + "'," +
                    "sueldo='" + sueldo + "'," +
                    "puesto='" + puesto + "'," +
                    "nss='" + nss + "'," +
                    "fecha_nacimiento='" + validarFecha(TimePicker.Value.ToString(),'-') + "'";

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

        private void actualizarTabla(DataGridView data) //Actualizacion de campos
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

        private void actualizarTabla(DataGridView data, string filter) //Filtro
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


        private void EmpleadosDGV_CellClick(object sender, DataGridViewCellEventArgs e) //Selección de filas
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
            FechaIngreso.Text = validarFecha(table.Rows[0]["Fecha_ingreso"].ToString(),'/');
            FechaTermino.Text = validarFecha(table.Rows[0]["Fecha_termino"].ToString(),'/');
            TimePicker.Text=table.Rows[0]["Fecha_nacimiento"].ToString();
            Telefono.Text = table.Rows[0]["Telefono"].ToString();
            Antiguedad.Text = table.Rows[0]["Antiguedad"].ToString();          
            NIMMS.Text = table.Rows[0]["NSS"].ToString();

            if (FechaTermino.Text == "")
            {
                btnTContrato.Enabled = true;
            }
            else
            {
                btnTContrato.Enabled = false;
            }

        }



        private void btnTContrato_Click(object sender, EventArgs e)
        {

            try
            {

                Fecha fecha = new Fecha();
                if (fecha.ShowDialog() == DialogResult.OK)
                {
                    DateTime dt = fecha.GetDate(), di = DateTime.Parse(FechaIngreso.Text);

                    String diater = validarFecha("" + dt,'-');

                    int diasRestantes = (int)dt.Subtract(di).TotalDays;

                    conexion = new Conexion();
                    sqlStatement = "update empleados set " +
                    "fecha_termino='" + diater +
                    "', dias_contrato=" + diasRestantes+
                    " where rfc='"+RFC.Text+"'";

                    Console.WriteLine(sqlStatement);
                    

                    conexion.executeQuery(sqlStatement);
                    MessageBox.Show("Se ha actualizado la información.", "Aviso");

                    conexion = new Conexion();
                    string selected = EmpleadosDGV.CurrentRow.Cells[0].Value.ToString();
                    sqlStatement = "select * from empleados where nombre='" + selected + "'";

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
                    FechaTermino.Text = table.Rows[0]["Fecha_termino"].ToString();
                    TimePicker.Text = table.Rows[0]["Fecha_nacimiento"].ToString();
                    Telefono.Text = table.Rows[0]["Telefono"].ToString();
                    Antiguedad.Text = table.Rows[0]["Antiguedad"].ToString();
                    NIMMS.Text = table.Rows[0]["NSS"].ToString();

                }
            }catch(Exception)
            {
                MessageBox.Show("No hay elemento seleccionado", "Error");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
            {
                Motivo.Enabled = true;
            }
            else
            {
                Motivo.Enabled = false;
            }
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
                        sqlStatement = "call BajaEmp('" + RFC.Text + "','Termino de contrato')";
                    }
                    else
                    {
                        sqlStatement = "call BajaEmp('" + RFC.Text + "','" + Motivo.Text + "')";
                    }

                    Console.WriteLine(sqlStatement);
                    conexion.executeQuery(sqlStatement);
                    MessageBox.Show("Se ha dado de baja a " + Nombre.Text, "Aviso");
                    actualizarTabla(EmpleadosDGV);

                    vaciarCampos();
                    
                }
            }
            catch
            {
                MessageBox.Show("No hay elemento seleccionado", "Error");
            }
        }

        private void vaciarCampos()
        {
            Nombre.Text = "";
            RFC.Text = "";
            CURP.Text = "";
            Puesto.Text = "";
            Sueldo.Text = "";
            DiasContrato.Text = "";
            FechaIngreso.Text = "";
            FechaTermino.Text = "";
            TimePicker.Text = "";
            Telefono.Text = "";
            Antiguedad.Text = "";
            NIMMS.Text = "";
        }
    }
}
