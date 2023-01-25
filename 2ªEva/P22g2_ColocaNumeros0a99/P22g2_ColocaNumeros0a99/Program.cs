using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22g2_ColocaNumeros0a99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MuestraNums099();
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadKey();
        }
        static void MuestraNums099()
        {
            Console.WriteLine();
            for (int num = 0; num < 10; num++)           
                Console.Write("    {0}  ",num);
            
            for (int num = 10; num < 100; num++)
            {
                if (num%10==0)
                    Console.WriteLine("\n");
                    Console.Write("   {0}  ",num);
                
            }
        }
    }
}
