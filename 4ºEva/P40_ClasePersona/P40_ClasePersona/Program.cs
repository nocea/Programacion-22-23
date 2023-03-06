using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40_ClasePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Mario","Nocea",1,2,3);
            p1.Mostrar();
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
