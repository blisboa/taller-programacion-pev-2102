using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            // imprimir la parte superior del rectangulo
            while(contador < 10)
            {
                Console.Write("A");
                contador++;
            }

            // repetir 5 veces          
            int linea = 0;
            while (linea < 5) {

                // imprimir la linea "B         B"
                Console.WriteLine();
                Console.Write("B");
                contador = 0;
                while(contador < 8)
                {
                    Console.Write(" ");
                    contador++;
                }
                Console.Write("B");

                linea++;
            }

            // imprime la parte inferior del rectangulo
            Console.WriteLine();
            contador = 0;
            while (contador < 10)
            {
                Console.Write("A");
                contador++;
            }

            Console.ReadKey();
        }
    }
}
