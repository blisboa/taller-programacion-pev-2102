using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[6];

            notas[0] = 4; // en C# la primera casilla se indica con la posicion 0
            notas[1] = 5;
            notas[2] = 6;
            notas[3] = 3;
            notas[4] = 2;
            notas[5] = 7; // la ultima casilla se indica con la posicion N-1, N la dimension ( la cantidad total de casillas) del arreglo 

            int contador = 0;
            // mostrar el contenido del arreglo
            Console.WriteLine("El contenido del arreglo es:");
            while (contador < 6)
            {
                Console.WriteLine(notas[contador]);
                contador++;
            }

            // encontra un elemento y mostrar la posicion donde se encontro ese elemento
            int valorBuscado = 4;
            contador = 0; // volver a inicializar la variable contador en cero
            while(contador < 6) // Si contador < 6 es Verdad el ciclo while continua
                                // Si contador < 6 es Falso el ciclo while NO continua, se termina el ciclo
            {
                Console.WriteLine("Comparar el elemento notas[" + contador + "]");
                if (notas[contador] == valorBuscado)
                {
                    Console.WriteLine("El elemento buscado (" + valorBuscado + ") está en la posicion " + contador);
                    contador = 1000; // Asignar un valor que haga que la condicion "contador < 6" sea Falsa
                }
                contador++;
            }

            Console.WriteLine("Fin de programa");

            Console.ReadKey();
        }
    }
}
