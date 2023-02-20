using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P37_FusionDirectaDeFicherosMario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader srN1 = File.OpenText(@"./Datos/n1.txt");
            StreamReader srN2 = File.OpenText(@"./Datos/n2.txt");
            StreamWriter swn3 = File.CreateText(@"./Datos/n3.txt");
            int n1 = 0, n2 = 0;
            bool escritoN1=true,escritoN2=true,finalN1=false,finalN2=false;    
            while (!srN1.EndOfStream || !srN2.EndOfStream)
            {
                if (!srN1.EndOfStream&&escritoN2)
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                }
                if (!srN2.EndOfStream)
                {
                    n2 = Convert.ToInt32(Console.ReadLine());
                }

               
            }
           
        }
    }
}
