using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[6];

            notas[0] = 2; // asignar un valor a la primera casilla
            notas[1] = 4;// asignar un valor a la segunda casilla
            notas[2] = 5;
            notas[3] = 3;
            notas[4] = 7;
            notas[5] = 6;

            int contador = 0;
            while(contador < 6)
            {
                Console.WriteLine(notas[contador]);
                contador++;
            }
            Console.ReadKey();



        }
    }
}
