using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14f_SumadorYMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, num,contador=0;
            int min = -1000, max = 1000;
            bool ok;
           
            Console.Write("\n\tDime un numero,intro para salir: ");
            ok = Int32.TryParse(Console.ReadLine(), out num);
            while (ok && (num > min && num < max))
                {
                suma += num;
                contador++;
                Console.Write("\n\tDime un numero,intro para salir: ");
                ok = Int32.TryParse(Console.ReadLine(), out num);


            }

            double media=(double)(suma/contador);
            Console.WriteLine("Suma= {0}", suma);
            Console.WriteLine("Media= {0}",media);

            
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}
