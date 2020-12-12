using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// libreias para la conexion a la base de datos
using System.Data;
using System.Data.SqlClient;

namespace sistema_req_v1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Usuario, Clave;


            Usuario = txtUsuario.Text;
            Clave = txtClave.Text;


            // invocar al SP ValidarUsuario

            // establecer la conexion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = ene_aiep; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("ValidarUsuario", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@IdUsuario", Usuario);
            sqlCmd.Parameters.AddWithValue("@clave", Clave);

            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // Validar si el usuario tiene o no tiene al Sistema
            if (dtData.Rows.Count > 0)
            {
                MessageBox.Show( Convert.ToString(dtData.Rows[0]["MensajeRet"]));
            }

            sqlCon.Close();
        }
    }
}
