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
            // invocar (llamar o usar) el sp ConsultarReq

            // establecer la conexion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = ene_aiep; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ConsultarReq 0,0,'P'
            sqlCmd = new SqlCommand("ConsultarReq", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tipoReq", 0);
            sqlCmd.Parameters.AddWithValue("@prioridad", 0);
            sqlCmd.Parameters.AddWithValue("@estado", "P");

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
                new {Text ="Base de Datos",Value = "1" },
                new {Text ="Sistemas",Value = "2" },
                new {Text ="Instalacion de Software",Value = "3" },
            };
            cmbRequerimiento.DataSource = itemsReq;

        }
    }
}
