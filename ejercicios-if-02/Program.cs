using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_if_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int edad = 0;
            string continuar;

            do
            {
                Console.Clear(); // esta instrucion limpia la pantalla
                //////////////////////////////////////////////
                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                int.TryParse(Console.ReadLine(), out edad);
                while (edad <= 0)// Mientras edad menor o igual a cero (edad sea un valor invalido), 
                                 //vuelva a solicitar el ingreso de la edad
                {
                    // aqui van las intruciocnes de repeticion
                    Console.WriteLine("Por favor ingrese una edad valida");
                    int.TryParse(Console.ReadLine(), out edad);
                }
                if (edad >= 18 && edad <= 80)
                {
                    Console.WriteLine(nombre + ", usted si puede votar porque tiene " + edad + " años.");
                }
                else
                {// estas instrucicones se ejecutan si edad < 18 or edad >80  
                    Console.Write(nombre);
                    if (edad < 18)
                    {
                        Console.WriteLine(", su edad es " + edad + ", y no puede votar por ser menor de edad");
                    }
                    else  // edad > 80
                    {
                        Console.WriteLine(", su edad es " + edad + ", y no puede votar por ser mayor de 80");
                    }
                }
                ///////////////////////////////////////////

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                //Console.WriteLine("Estimado usuario, si desea continuar escriba una S y presione Enter.");
                Console.WriteLine("Estimado usuario, si desea continuar presiones la teclas S, sino presione cualquier tecla.");
                Console.WriteLine("--------------------------------------------------------------------");
                //continuar = Console.ReadLine();
                //} while (continuar == "S" || continuar =="s");
            } while ( Console.ReadKey().Key == ConsoleKey.S);

        }
    }
}
