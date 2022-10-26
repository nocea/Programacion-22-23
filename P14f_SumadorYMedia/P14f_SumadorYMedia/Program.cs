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
            string captura;

            Console.Write("\n\tDime sumando {0} (intro=salir): ", contador + 1);
            captura = Console.ReadLine();
            while (captura != "")
            {
                num = Convert.ToInt32(captura);
                suma += num;   // <-- Acumulamos el número
                contador++;    // <-- incrementamos el contador
                               // y pedimos el siguiente
                Console.Write("\n\tDime sumando {0} (intro=salir): ", contador + 1);
                captura = Console.ReadLine();
            }
            double media = 1.0*suma / contador;
            Console.WriteLine("Suma: "+suma);
            Console.WriteLine("Media: "+media);
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
