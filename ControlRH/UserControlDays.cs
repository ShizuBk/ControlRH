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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays(string names)
        {
            InitializeComponent();
            Names.Text = names;
        }

        public void days(int numday)
        {
            Cumpleaños.Text = numday+"";
        }
    }
}
