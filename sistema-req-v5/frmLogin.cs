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

            // Validar que se hayan ingresado usuario y clave
            if (txtUsuario.TextLength ==0)
            {
                MessageBox.Show("Debe ingresar el usuario.");
                return; // se acabó la ejecucion del evento clic del boton
            }

            if (txtClave.TextLength == 0)
            {
                MessageBox.Show("Debe ingresar la clave.");
                return; // se acabó la ejecucion del evento clic del boton
            }
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
                if (Convert.ToInt32(dtData.Rows[0]["CodigoRet"]) != 0)
                    MessageBox.Show("No puede acceder al sistema");
                else {
                    // desplegar la pantalla de Ingreso de Requerimientos
                    this.Hide(); // ocultar pantall de login
                    frmMenu fMenu = new frmMenu();
                    fMenu.ShowDialog();

                }

            }

            sqlCon.Close();
        }

        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {

            txtClave.UseSystemPasswordChar = !chkVer.Checked;

            //if (chkVer.Checked== true)
            //{
            //    // mostrar clave
            //    txtClave.UseSystemPasswordChar = false;//--> mostrar clave

            //}
            //else
            //{
            //    // ocultar clave
            //    txtClave.UseSystemPasswordChar = true; //--> oculta clave
            //}
       
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtClave.UseSystemPasswordChar == true) { 
                // Mostrar la clave
                txtClave.UseSystemPasswordChar = false;
                btnVer.Text = "Ocultar clave";
            }
            else { 
                txtClave.UseSystemPasswordChar = true;
                btnVer.Text = "Mostrar clave";
            }
        }
    }
}
