using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_01
{
    public partial class frmCalculadora : Form
    {

        // variables globales de toda la clase --> atributos o propiedades de la clase
        int num1, num2, resultado;


        private void btnSumar_Click(object sender, EventArgs e)
        {
            Calcular(0);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Calcular(1); 
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calcular(2);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calcular(3);
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Validar si se presino la tecla ENTER 
            if( (int) e.KeyChar == (int) Keys.Enter) { 
                txtNumero2.Focus(); // Si se presiona ENTER el foco pasa a la siguinete caja de texto
            }

            // Validar si se ingresa un numero o cualquier teclka que no sea numero
            if (Char.IsDigit(e.KeyChar) == true)  // Si la tecla presionada es un numero (digito)
                e.Handled = false; // Continuar con el evento KeyPress ---> mostrar en la caja de texto la tecla presionada
            else  // Si la tecla presionada no es un un digito, entonces cancelamos el evento KepPress
                e.Handled = true; // cancelar el evento KeyPress--> que no se muestra en la caja texto la tecla presionada
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            txtNumero2.Focus();// asignar el foco a la caja de texto txtNumero2
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))  // Si es numero
                e.Handled = false; // Continuar con el evento KeyPress ---> mostrar en la caja de texto la tecla presionada
            else  // No es un numero
                e.Handled = true; // c
        }

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Calcular(int tipoCalculo)
        {

            try { 
                // caputar los 2 numeros que queremos sumar
                num1 = Convert.ToInt32(txtNumero1.Text);
                num2 = Convert.ToInt32(txtNumero2.Text);
           }catch (Exception Ex)
            {
                MessageBox.Show("Estimado usuario, debe ingresar solo numeros, por favor corriga el error e intenete nuevamente.");
            }

            switch (tipoCalculo)
            {
                case 0:
                    resultado = num1 + num2;
                    break;
                case 1:
                    resultado = num1 - num2;
                    break;
                case 2:
                    resultado = num1 * num2;
                    break;
                case 3:
                    try { 
                    resultado = num1 /num2;
                    }catch(Exception Ex)
                    {
                        MessageBox.Show("Estimado usuario no puede dividir por cero, corrija el segundo operador e intenete nuevamente.");
                    }
                    break;
            }

            // mostrra el resultado
            txtResultado.Text = Convert.ToString(resultado);

        }
    }
}
