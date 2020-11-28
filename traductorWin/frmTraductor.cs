using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traductorWin
{
    public partial class frmTraductor : Form
    {
        string[] dic_espanol = new string[20];
        string[] dic_ingles = new string[20];

        // constructor, es lo primero que se ejcuta cuando se crea el objeto
        public frmTraductor()
        {
            InitializeComponent();
        }

        private void frmTraductor_Load(object sender, EventArgs e)
        {
            dic_espanol[0] = "hola";
            dic_espanol[1] = "mundo";
            dic_espanol[2] = "dia";
            dic_espanol[3] = "lunes";
            dic_espanol[4] = "martes";
            dic_espanol[5] = "miercoles";
            dic_espanol[6] = "jueves";
            dic_espanol[7] = "viernes";
            dic_espanol[8] = "sabado";
            dic_espanol[9] = "domingo";
            dic_espanol[10] = "hoy";
            dic_espanol[11] = "es";

            dic_ingles[0] = "hello";
            dic_ingles[1] = "world";
            dic_ingles[2] = "day";
            dic_ingles[3] = "monday";
            dic_ingles[4] = "tuesday";
            dic_ingles[5] = "wednesday";
            dic_ingles[6] = "thursday";
            dic_ingles[7] = "friday";
            dic_ingles[8] = "saturday";
            dic_ingles[9] = "sunday";
            dic_ingles[10] = "today";
            dic_ingles[11] = "is";


        }

        private void btnTraducir_Click(object sender, EventArgs e)
        {
            string palabraBuscada;
            int pos_palabra_buscada;
            string[] palabras = new string[20];

            palabras = txtFraseEspanol.Text.Split(' ');
            txtFraseIngles.Text = "";
            for (int contador = 0; contador < palabras.Length; contador++)
            {

                palabraBuscada = palabras[contador];
                // buscar la posicion de la palaba buscada
                pos_palabra_buscada = -1;
                for (int pos = 0; pos < dic_espanol.Length; pos++)
                {
                    if (palabraBuscada == dic_espanol[pos])
                    {
                        pos_palabra_buscada = pos;
                    }
                }
                //mostrar la palabra traducidad
                if (pos_palabra_buscada >= 0) // Significa que la palabra se encontro
                    txtFraseIngles.Text = txtFraseIngles.Text + " " + dic_ingles[pos_palabra_buscada];
                else
                    txtFraseIngles.Text = txtFraseIngles.Text + " " + palabraBuscada;

            }
        }
    }
}
