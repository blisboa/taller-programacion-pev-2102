using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistema_req_v1
{
    class Requerimiento
    {

        // Metodo Constructor de la clase Requerimiento
        public Requerimiento()
        {
            IdRequerimiento = 0;
            Descripcion = "nuevo requerimiento.";
            Estado = "P";
            Tipo = 1;
            Prioridad = 3;
            Fecha = DateTime.Now; // Getdate de SQL
            IdUsuario = "";
        }

        public int IdRequerimiento { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public int Tipo { get; set; }
        public int Prioridad { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }


        public string Grabar()
        {
            // establecer la conexion
            string cadenaConexion = "Server = SCLNTB6610290,1433 ; Database = ene_aiep; User Id = sa; Password = Sonda.2020;";
            SqlConnection sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();

            // ejecutar llamada al sp que esta en la base de datos
            SqlCommand sqlCmd;

            // exec ValidarUsuario 'blisboa','123456'
            sqlCmd = new SqlCommand("GrabrarReq", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@tipoReq", Tipo);
            sqlCmd.Parameters.AddWithValue("@usuario", IdUsuario);
            sqlCmd.Parameters.AddWithValue("@desc", Descripcion);
            sqlCmd.Parameters.AddWithValue("@prioridad", Prioridad);

            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            DataTable dtData = new DataTable();
            sqlSda.Fill(dtData);

            // Validar si el usuario tiene o no tiene al Sistema
            if (dtData.Rows.Count > 0)
            {
                return dtData.Rows[0]["MensajeRet"].ToString();
            }
            else
            {
                return "No fue posible grabar el requerimiento.";
            }
            
            sqlCon.Close();
        }

    }
}
