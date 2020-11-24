using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traductor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dic_espanol = new string[10];

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


            string[] dic_ingles = { "hello", "world", "day", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

            
            string palabraBuscada = "mundo";

            // buscar la posicion de la palaba buscada
            int pos_palabra_buscada = -1;
            for(int pos = 0; pos < dic_espanol.Length; pos++)
            {
                if (palabraBuscada == dic_espanol[pos])
                {
                    pos_palabra_buscada = pos;
                }
            }

            if (pos_palabra_buscada >= 0) // Significa que la palabra se encontro
            {
                Console.WriteLine("La palabra " + palabraBuscada + " en ingles se escribe:" + dic_ingles[pos_palabra_buscada]);
            }
            else
                Console.WriteLine("La palabara: " + palabraBuscada + " no se encuentra en el dicionario y no se puede traducir.");


            Console.ReadKey();

        }
    }
}
