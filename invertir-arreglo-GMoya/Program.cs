using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo1 = new int[10];
            int[] arreglo2 = new int[10];

            Random azarin = new Random();
            int cont = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("");

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("- Arreglo 1 -");
                Console.ResetColor();

                for (cont = 0; cont < arreglo1.Length; cont++)
                {
                    arreglo1[cont] = azarin.Next(10, 100);
                    Console.Write(arreglo1[cont] + " ");
                }

                Console.WriteLine("");

                int total = arreglo1.Length;

                cont = 0;

                Console.WriteLine("");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("- Arreglo 2 -");
                Console.ResetColor();

                //for (cont = 0; cont < total; cont++)
                //{
                //    arreglo2[cont] = arreglo1[(total - 1) - cont];
                //    Console.Write(arreglo2[cont] + " ");
                //}
                int cnt_der = arreglo1.Length-1;
                for (cont = 0; cont < total; cont++, cnt_der--)
                {
                    arreglo2[cont] = arreglo1[cnt_der];
                    Console.Write(arreglo2[cont] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                string txt = "Para realizar de nuevo presione S. Para salir presione cualquier tecla.";
                while (!System.Console.KeyAvailable)
                {
                    Parpadeo(txt, 900, true);
                    Parpadeo(txt, 300, false);
                }

                //Console.WriteLine("Para realizar de nuevo presione S. Para salir presione cualquier tecla.");

            } while (Console.ReadKey().Key == ConsoleKey.S);
        }

        private static void Parpadeo(string text, int delay, bool visible)
        {

            if (visible)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(text);
                Console.ResetColor();
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                    Console.Write(" ");
            }
            Console.CursorLeft -= text.Length;
            System.Threading.Thread.Sleep(delay);
        }
    }
}
