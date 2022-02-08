using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresntacion
{
    public partial class frmPrincipal3 : Form
    {
        public frmPrincipal3()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
