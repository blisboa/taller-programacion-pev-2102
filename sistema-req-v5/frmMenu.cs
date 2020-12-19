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
            frmIngresar fIngresar = new frmIngresar();
            fIngresar.MdiParent = this;
            fIngresar.Show();

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
