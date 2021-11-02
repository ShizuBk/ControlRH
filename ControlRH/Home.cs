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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.panelCont.Controls.Clear();
            Empleados empleados = new Empleados();
            empleados.TopLevel = false;
            empleados.FormBorderStyle = FormBorderStyle.None;
            empleados.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(empleados);
            this.panelCont.Tag = empleados;
            empleados.Show();
        }

        private void btnReclutamiento_Click(object sender, EventArgs e)
        {
            this.panelCont.Controls.Clear();
            Reclutamiento reclutamiento = new Reclutamiento();
            reclutamiento.TopLevel = false;
            reclutamiento.FormBorderStyle = FormBorderStyle.None;
            reclutamiento.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(reclutamiento);
            this.panelCont.Tag = reclutamiento;
            reclutamiento.Show();
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            this.panelCont.Controls.Clear();
            Bajas bajas = new Bajas();
            bajas.TopLevel = false;
            bajas.FormBorderStyle = FormBorderStyle.None;
            bajas.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(bajas);
            this.panelCont.Tag = bajas;
            bajas.Show();
        }

        private void btnPracticantes_Click(object sender, EventArgs e)
        {
            this.panelCont.Controls.Clear();
            Practicantes practicantes= new Practicantes();
            practicantes.TopLevel = false;
            practicantes.FormBorderStyle = FormBorderStyle.None;
            practicantes.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(practicantes);
            this.panelCont.Tag = practicantes;
            practicantes.Show();
        }
    }
}
