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
    public partial class OIdentificador : Form
    {
        private string ID;
        public OIdentificador()
        {
            InitializeComponent();
        }

        public OIdentificador(string type)
        {
            InitializeComponent();

            if (type == "empleado")
            {
                Textbx.Text = "Ingrese RFC";
            }
            else
            {
                Textbx.Text = "Ingrese CURP";
            }
            
        }


        private void txtbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.ID = txtbID.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        public string getID()
        {
            return this.ID;
        }

        private void OIdentificador_Load(object sender, EventArgs e)
        {

        }

        private void txtbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
