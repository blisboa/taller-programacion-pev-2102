using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_if_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int edad = 0;


            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            //edad = Console.ReadLine(); // esta linea genera un error porque no se puede asignar un string a un int
            //edad = Convert.ToInt32( Console.ReadLine() ); // Convert sin control de error
            int.TryParse( Console.ReadLine(), out edad) ;

            // las persoans pueden votar solo las persoans entre 18 y 80 años
            // edad >= 18 y edad <= 80, se deben cumplir ambasa condiciones
            // tenemos que usar el operador logico AND  --> &&
            // P AND Q --> Verdad, si ambas condiciones son verdaderas
            // P --> edad >= 18
            // Q --> edad <= 80
            // P AND Q --> edad >= 18 AND edad <= 80 --> edad >= 18 && edad <= 80 
            if (edad >= 18  && edad <= 80) 
            { // la condicion sera verdad para 18,19,20, etc.
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
            Console.ReadKey();

        }
    }
}
