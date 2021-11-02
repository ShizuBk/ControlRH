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
    public partial class secPin : Form
    {
        private string inPin;
        public secPin()
        {
            InitializeComponent();
        }
        

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.inPin = pin.Text;
                this.DialogResult = DialogResult.OK; 
            }
        }

        public string getPin()
        {
            return this.inPin;
        }
    }
}
