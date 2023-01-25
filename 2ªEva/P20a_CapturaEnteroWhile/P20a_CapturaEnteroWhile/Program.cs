using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20a_CapturaEnteroWhile
{
    internal class Program
    {
        const int MIN = 100, MAX = 200;
        static void Main(string[] args)
        {
            string texto = "prueba";
            CapturaEntero(texto, MIN, MAX);
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int numero=0;
            bool ok = false;
            while (!ok) { 
            
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
            } 
            //comentario
            return numero;
        }
    }
}
