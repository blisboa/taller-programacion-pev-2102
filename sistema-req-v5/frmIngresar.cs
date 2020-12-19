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
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {


            cmbTipoReq.DisplayMember = "Text";
            cmbTipoReq.ValueMember = "Value";
            var itemsReq = new[] {
                new {Text ="Base de Datos",Value = "1" },
                new {Text ="Sistemas",Value = "2" },
                new {Text ="Instalacion de Software",Value = "3" },
            };
            cmbTipoReq.DataSource = itemsReq;

            cmbUsuario.DisplayMember = "Text";
            cmbUsuario.ValueMember = "Value";
            var itemsUsuario = new[]
            {
            new {Text = "Bernardo Lisboa" , Value = "blisboa"},
            new {Text = "Gonzalo Moya" , Value = "gmoya"},
            };
            cmbUsuario.DataSource = itemsUsuario;

            cmbPriodidad.DisplayMember = "Text";
            cmbPriodidad.ValueMember = "Value";
            var itemsReq1 = new[]
            {
            new {Text = "Alta" , Value = "1"},
            new {Text = "Media" , Value = "2"},
            new {Text = "Baja" , Value = "3"},
            };

            cmbPriodidad.DataSource = itemsReq1;


            // dejar todo slos combobox sin ninguna seleccion
            cmbTipoReq.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbPriodidad.SelectedIndex = -1;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // Validar
            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar el usauro responsable antes de Grabar");
                return;
            }

            if (txtDesc.TextLength ==0)
            {
                MessageBox.Show("Estimado usuario, debe ingresar la descripcion del requerimientos antes de Grabar");
                return;
            }

            if (cmbTipoReq.SelectedIndex == -1 )
            {
                MessageBox.Show("Estimado usuario, debe seleccionar el tipo de requerimientos antes de Grabar");
                return;
            }

            if (cmbPriodidad.SelectedIndex == -1)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar el tipo prioridad antes de Grabar");
                return;
            }

            // Crear el objeto REQ de tipo Requerimiento
            Requerimiento req = new Requerimiento();


            // capturar la infomracion ingresada por el usuario
            // y la ssigaremso al objet REQ
            req.Descripcion = txtDesc.Text;
            req.IdUsuario = cmbUsuario.SelectedValue.ToString();
            req.Tipo =  Convert.ToInt32( cmbTipoReq.SelectedValue);
            req.Prioridad = Convert.ToInt32(cmbPriodidad.SelectedValue);

            string MensajeRetorno;
            MensajeRetorno = req.Grabar();

            MessageBox.Show(MensajeRetorno);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            cmbTipoReq.SelectedIndex = -1;
            cmbPriodidad.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmConsultar fConsulta = new frmConsultar();
            fConsulta.MdiParent = this.ParentForm ; // asignando un valor en tiempo/modo de ejecucion
            fConsulta.Show();
        }
    }
}
