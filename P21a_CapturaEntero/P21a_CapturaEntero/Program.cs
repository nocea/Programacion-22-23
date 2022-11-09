using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21a_CapturaEntero
{
    internal class Program
    {
        const int MIN = 100, MAX = 200;
        static void Main(string[] args)
        {
            string txt = string.Format("Dime un numero entre[{0}...{1}]", MIN, MAX);
            CapturaEntero(txt,MIN,MAX);
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
        static int CapturaEntero(string texto,int min,int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.WriteLine(texto);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
            } while (!ok || numero < min || numero > max);

            return numero;
        }
    }
}
