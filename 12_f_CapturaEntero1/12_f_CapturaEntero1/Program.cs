using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_f_CapturaEntero1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el minimo del rango: ");
            int min=Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el máximo del rango: ");
            int max=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (max < min) { Console.WriteLine("--Error: No puede ser el máximo menor que el mínimo--"); }
            else
            {
                Console.Write("Introduce un numero entre {0} y {1}: ", min, max);
                int num=Convert.ToInt32(Console.ReadLine());
                if (num > max || num < min)
                {
                    Console.WriteLine("El numero está fuera de rango");
                }
                else Console.WriteLine("Correcto el numero elegido es: {0}", num);




            }
            







            Console.WriteLine("Pulsa intro para salir");
            Console.ReadLine();
        }
    }
}
