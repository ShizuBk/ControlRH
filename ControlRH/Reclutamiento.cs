using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControlRH
{
    public partial class Reclutamiento : Form
    {
        Conexion conexion;
        private string sqlStatement = "";
        private MySqlDataReader reader = null;



        public Reclutamiento()
        {
            InitializeComponent();
            actualizarTabla(ReclutamientoDGV);
            
        }


        private void botonAceptar_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();
            string nombre, puesto, identificador, tipo,tel;
            nombre = ReclutamientoDGV.CurrentRow.Cells[0].Value.ToString();
            tel = ReclutamientoDGV.CurrentRow.Cells[1].Value.ToString();
            puesto = ReclutamientoDGV.CurrentRow.Cells[2].Value.ToString();
            

            OIdentificador nid; 
            if (rbEmp.Checked)
            {
                tipo = "empleado";
                nid = new OIdentificador(tipo);
                if (nid.ShowDialog() == DialogResult.OK)
                {
                    nid.Dispose();
                    if (solicitarPin()) {
                        try
                        {
                            identificador = nid.getID();
                            Console.WriteLine(identificador);
                            
                            sqlStatement = "call AceptarV('" + nombre + "','" + puesto + "','" + tipo + "','" + identificador + "','" + tel + "')";
                            Console.WriteLine(sqlStatement);
                            conexion.executeQuery(sqlStatement);
                            MessageBox.Show("Se ha completado la operación.","Operación exitosa");
                        }
                        catch {
                            MessageBox.Show("No se ha podido realizar la operación", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pin incorrecto","Error");
                    }
                    rbEmp.Checked = false;
                }
            } else if (rbPrac.Checked)
            {
                tipo = "practicante";
                nid = new OIdentificador(tipo);
                if (nid.ShowDialog() == DialogResult.OK)
                {
                    nid.Dispose();
                    if (solicitarPin())
                    {
                        try
                        {                         
                            identificador = nid.getID();
                            sqlStatement = "call AceptarV('" + nombre + "','" + puesto + "','" + tipo + "','" + identificador +","+tel+ "')";
                            conexion.executeQuery(sqlStatement);
                            MessageBox.Show("Se ha completado la operación.", "Operación exitosa");
                        }
                        catch
                        {
                            MessageBox.Show("No se ha podido realizar la operación", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pin incorrecto", "Error");
                    }
                }
                rbPrac.Checked = false;
            }
            else {
                MessageBox.Show("Especifique si será empleado o practicante","Error");
            }
            ReclutamientoDGV.ClearSelection();
            actualizarTabla(ReclutamientoDGV);
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
                    MessageBox.Show("Pin incorrecto.","Error");
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }

        

        private void botonRechazar_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();
            try
            {
                sqlStatement = "delete from reclutamiento where nombre='" + labelNomP.Text + "'";
                conexion.executeQuery(sqlStatement);
                MessageBox.Show("Se ha eliminado el registro.","Operación exitosa");
                actualizarTabla(ReclutamientoDGV);
                labelNomP.Text = "";
                ReclutamientoDGV.ClearSelection();
            }
            catch (Exception err)
            {
                err.GetType();
                MessageBox.Show("No se ha podido procesar la operación","Error");
            }
        }


        private void Reclutamiento_Load(object sender, EventArgs e)
        {
            actualizarTabla(ReclutamientoDGV);
            cargarComboBox();
            labelNomP.Text = "";
        }

        private void cargarComboBox()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("select puestos from puestos",conexion.GetConnection());
            DataTable cmbRtable=new DataTable();
            adapter.Fill(cmbRtable);
            cmbPuestos.DisplayMember = "Puestos";
            cmbPuestos.DisplayMember = "Puestos";
            cmbPuestos.DataSource = cmbRtable;
            cmbPuestos.Text = "Selecionar";


            adapter=new MySqlDataAdapter("select puesto from reclutamiento",conexion.GetConnection());
            DataTable cmbPtable = new DataTable();
            adapter.Fill(cmbPtable);
            
            cmbFiltro.DisplayMember = "Puesto";
            cmbFiltro.DisplayMember = "Puesto";
            cmbFiltro.DataSource = cmbPtable;
            cmbFiltro.Text = "Todos";


        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();

            if (Nombre.Text=="" || Telefono.Text=="") {
                MessageBox.Show("Por favor rellene todos los campos", "Error");
            }
            else
            {
                sqlStatement = "insert into reclutamiento (nombre,telefono,puesto) values ('" + Nombre.Text + "','" + Telefono.Text + "','" + cmbPuestos.Text + "')";
                reader = conexion.executeQuery(sqlStatement);
                if (reader != null)
                {
                    MessageBox.Show("Se ha agregado el registro con exito.", "Registro exitoso");
                    actualizarTabla(ReclutamientoDGV);
                    Nombre.Text = "";
                    Telefono.Text = "";
                }
                else
                {
                    MessageBox.Show("No se ha podido conectar a la base de datos.", "Error");
                }
            }
            cmbPuestos.Text = "Seleccionar";
        }


        private void actualizarTabla(DataGridView data)
        {
            conexion = new Conexion();
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



        public void accionesTabla()
        {
            ReclutamientoDGV.Columns[0].Width = 150;
            ReclutamientoDGV.Columns[1].Width = 70;
        }



        private void ReclutamientoDGV_Load(object sender, DataGridViewCellEventArgs e)
        {
            actualizarTabla(ReclutamientoDGV);
        }


        private void Filtrar_Click(object sender, EventArgs e)
        {
            actualizarTabla(ReclutamientoDGV, cmbFiltro.Text);
        }

        private void noFilter_Click(object sender, EventArgs e)
        {
            cmbFiltro.Text = "Todos";
            actualizarTabla(ReclutamientoDGV);
        }

        private void ReclutamientoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelNomP.Text = ReclutamientoDGV.CurrentRow.Cells[0].Value.ToString();
        }
    }

   
    }
