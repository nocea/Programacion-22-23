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
        { int num = -1;
            int suma = 0;
            int contador = 0;
            Console.WriteLine("Introduce un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)               
            {
                
                 suma +=num;
                if (num != 0)
                {
                    contador++;
                }
                Console.WriteLine("Introduce un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                
            }
            double media = 1.0*suma / contador;
            Console.WriteLine("Suma: "+suma);
            Console.WriteLine("Media: "+media);
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
