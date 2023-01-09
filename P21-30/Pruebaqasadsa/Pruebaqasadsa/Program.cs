using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebaqasadsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabla = new int[100];
            List<int> list = new List<int>();
            list=tabla.ToList();    
            tabla=list.ToArray();
            char x=Console.ReadKey().KeyChar;  
        }
    }
}
