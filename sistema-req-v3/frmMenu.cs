using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_req_v1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ingresarRequerimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se selecciono la opcion de ingreso de requerimeito.");
        }

        private void consultarRequerimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar fConsulta = new frmConsultar();
            fConsulta.MdiParent = this; // asignando un valor en tiempo/modo de ejecucion
            // progamatibily
            fConsulta.Show();


            // Data Grid View ---> Grilla  --> Table
        }
    }
}
