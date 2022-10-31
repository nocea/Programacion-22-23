using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14f_SumadorYMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, num, contador = 0;
            bool ok = true;

            while (ok)
            {
                Console.WriteLine("Dime un numero,intro para salir");
                ok = Int32.TryParse(Console.ReadLine(), out num);
                suma += num;
                if (ok) { contador++; }

                Console.WriteLine(contador);
            }


            double media = 1.0 * suma / contador;
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Media: " + media);
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
