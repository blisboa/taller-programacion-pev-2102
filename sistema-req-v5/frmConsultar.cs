using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace sistema_req_v1
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (chkPendiente.Checked == false && chkResuelto.Checked == false)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar por lo menos un estado para realziar la búsqueda.");
                return;
            }

            // invocar (llamar o usar) el sp ConsultarReq

            // establecer la conexion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = ene_aiep; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // capturar los valores para ser enviados como parametros al SP (esepe) (stored procedure)
            // Tipo de requerimiento y Tipo Prioridad
            int tipoReq, tipoPrioridad;
            tipoReq = Convert.ToInt32(cmbRequerimiento.SelectedValue);
            tipoPrioridad = Convert.ToInt32(cmbPrioridad.SelectedValue);
            // Capturar el estado
            string Estado= "";
            if (chkPendiente.Checked == true)
                Estado = "P";

            if (chkResuelto.Checked == true)
                Estado = "R";

            if (chkPendiente.Checked == true  && chkResuelto.Checked == true)
                Estado = "T";

            // exec ConsultarReq 0,0,'P'
            sqlCmd = new SqlCommand("ConsultarReq", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tipoReq", tipoReq);
            sqlCmd.Parameters.AddWithValue("@prioridad", tipoPrioridad);
            sqlCmd.Parameters.AddWithValue("@estado", Estado);

            // invorcar al sp
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // asignar el resulatdo del sp a la grilla : dgvReq
            dgvReq.DataSource = dtData;

            // cerrar la conexion
            sqlCon.Close();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

            // agregar opciones a combobox cmbRequerimiento
            cmbRequerimiento.DisplayMember = "Text";
            cmbRequerimiento.ValueMember = "Value";
            var itemsReq = new[] {
                new {Text ="Todos",Value = "0" },
                new {Text ="Base de Datos",Value = "1" },
                new {Text ="Sistemas",Value = "2" },
                new {Text ="Instalacion de Software",Value = "3" },
            };
            cmbRequerimiento.DataSource = itemsReq;


            // agregar opciones a combobox cmbPrioridad
            cmbPrioridad.DisplayMember = "Text";
            cmbPrioridad.ValueMember = "Value";
            var itemsPrio = new[] {
                new {Text ="Todos",Value = "0" },
                new {Text ="Alta",Value = "1" },
                new {Text ="Media",Value = "2" },
                new {Text ="Baja",Value = "3" },
            };
            cmbPrioridad.DataSource = itemsPrio;
        }

        private void btnResuelto_Click(object sender, EventArgs e)
        {
            // validar
            if (dgvReq.SelectedRows.Count == 0)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar un requerimiento para poder modificar su estado.");
                return;
            }

              // capturar el requerimiento seleciconado en la grilla           
             int idReq = Convert.ToInt32( dgvReq.SelectedRows[0].Cells[0].Value);
     

            // establecer la conexion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = ene_aiep; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("AsignarResuelto", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@idReq", idReq);


            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // Validar si el usuario tiene o no tiene al Sistema
            if (dtData.Rows.Count > 0)
            {
                MessageBox.Show(dtData.Rows[0]["MensajeRet"].ToString());
                if(Convert.ToInt32( dtData.Rows[0]["CodigoRet"] ) == 0)
                {
                    btnBuscar.PerformClick(); // hacer click en el boton Buscar
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // validar
            if (dgvReq.SelectedRows.Count == 0)
            {
                MessageBox.Show("Estimado usuario, debe seleccionar un requerimiento para poder modificar su estado.");
                return;
            }

            // capturar el requerimiento seleciconado en la grilla           
            int idReq = Convert.ToInt32(dgvReq.SelectedRows[0].Cells[0].Value);


            // establecer la conexion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = ene_aiep; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("EliminarReq", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@idReq", idReq);

            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // Validar si el usuario tiene o no tiene al Sistema
            if (dtData.Rows.Count > 0)
            {
                MessageBox.Show(dtData.Rows[0]["MensajeRet"].ToString());
                if (Convert.ToInt32(dtData.Rows[0]["CodigoRet"]) == 0)
                {
                    btnBuscar.PerformClick(); // hacer click en el boton Buscar
                }
            }

        }
    }
}
