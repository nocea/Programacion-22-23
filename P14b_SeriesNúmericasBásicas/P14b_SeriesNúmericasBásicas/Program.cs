using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14b_SeriesNúmericasBásicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n\t\t\t\t   Mario Nocea");
            Console.WriteLine("\t\t\t╔═══════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t║                    MENU                   ║");
            Console.WriteLine("\t\t\t╠═══════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t║                                           ║");
            Console.WriteLine("\t\t\t║    1.- Enteros positivos menores de 200   ║");
            Console.WriteLine("\t\t\t║    2.- Números pares menores de 200       ║");
            Console.WriteLine("\t\t\t║    3.- Números impares entre 200 y 500    ║");
            Console.WriteLine("\t\t\t║                                           ║");
            Console.WriteLine("\t\t\t║                  0) Salir                 ║");
            Console.WriteLine("\t\t\t║                                           ║");
            Console.WriteLine("\t\t\t╚═══════════════════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");
            int opcion = Console.ReadKey(true).KeyChar - '0';
            Console.Clear();
            if (opcion < 0 || opcion > 3) Console.WriteLine("Error tiene que introducir una opcion valida");




            else
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n\t2.- Números pares menores de 200\n");
                        for (int i = 1; i < 200; i++)
                        {
                            Console.Write("{0}\t", i);
                        }
                        break;
                    case 2:int num=0;
                        Console.WriteLine("\n\t1.- Enteros positivos menores de 200\n");
                        while (num < 200) {
                            if (num % 2 == 0) Console.Write("{0}\t",num);
                            num++;
                        
                        }
                        
                        break;
                    case 3:
                        break;






                }
            }
            Console.WriteLine("\nPulse intro para salir");
            Console.ReadLine();
        }
    }
}
