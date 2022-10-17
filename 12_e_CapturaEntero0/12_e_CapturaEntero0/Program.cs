using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_e_CapturaEntero0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número positivo de dos cifras: ");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num < 10 || num >= 100) { Console.WriteLine("Numero fuera de rango"); }
            else Console.WriteLine("Correcto.El número elegido es {0}",num);







            Console.WriteLine("Pulsa intro para salir");
            Console.ReadLine();
        }
    }
}
