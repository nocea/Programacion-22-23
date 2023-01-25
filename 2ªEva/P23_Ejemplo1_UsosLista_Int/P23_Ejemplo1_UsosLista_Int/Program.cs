using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_Ejemplo1_UsosLista_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> miLista;
            int tamaño;
            int numero;
            Random r = new Random();
            miLista = new List<int>();
            tamaño=CapturaEntero("Introduce el tamaño de la lista",10,24);
            for (int i = 0; i < tamaño; i++)
            {
                numero = r.Next(10, 100);
                miLista.Add();
            }

        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                Console.Clear();
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
                else if (numero < min || numero > max)
                {
                    Console.WriteLine("**Error:Numero fuera de rango**");
                    ok = false;
                }
            } while (!ok);
            //comentario
            return numero;
        }
    }
}
