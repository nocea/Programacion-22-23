using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20b_PracticasMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entero1, entero2, entero3;
            double media;
            
           
            entero1 = Captura("a");
            
            
            entero2 = Captura("b");
          
            
            entero3 = Captura("c");

            media = MediaDeTres(entero1, entero2, entero3);

            //media = MediaDeTres(entero1, entero2, entero3);
            Console.WriteLine(entero1);

            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
        static int Captura(string nombre)
        {
            int numero;

            Console.Write("Introduce el valor de {0}: ", nombre);
            numero = Convert.ToInt32(Console.ReadLine());

            return numero;

        }
        static double MediaDeTres(int numero1, int numero2, int numero3)
        {
            double media;
            media = (double)((numero1 + numero2 + numero3)) / 3;
            Console.WriteLine("La media es de : {0}", media);
            return media;
        }
    }
}

