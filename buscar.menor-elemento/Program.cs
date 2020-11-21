using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscar.menor_elemento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[6];
            int contador;
            Random aleatorio = new Random() ;

            do
            {
                Console.Clear();
                // asignar valore aleatorios a cada elemento del arreglo
                for (contador = 0; contador < 6; contador++)
                {
                    arreglo[contador] = aleatorio.Next(1, 100);
                }

                // mostrar el arreglo
                Console.WriteLine("Contenido del arreglo:");
                for (contador = 0; contador < 6; contador++)
                {
                    Console.Write(arreglo[contador] + " ");
                }
                Console.WriteLine();

                // buscar el menor elemento
                int menor;
                // Comparra el primer elemenot con el segundo elemento
                if (arreglo[0] < arreglo[1])
                    menor = arreglo[0];
                else
                    menor = arreglo[1];

                for (contador = 2; contador < 6; contador++)
                {
                    if (arreglo[contador] < menor) // si encontramos un nuevo MENOR
                    {
                        // antiguo menor = nuevo menor
                        menor = arreglo[contador];
                    }
                }

                Console.WriteLine("El menor elemento del arreglo es:" + menor);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Si desea ejecutar nuevamente, presiones la tecla S, para terminar presiones cualquier otra tecla.");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
    }
}
