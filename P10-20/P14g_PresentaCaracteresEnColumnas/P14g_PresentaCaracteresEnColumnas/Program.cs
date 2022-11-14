using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14g_PresentaCaracteresEnColumnas
{
    internal class Program
    {
        const int COLUMNAS = 7;
        static void Main(string[] args)
        {
            int contador = 0;
            for (int i = 32; i <= 255; i++)
            {  //Forma de fina de controlar las columnas
               if (contador++ % COLUMNAS==0) Console.WriteLine();
               //Forma menos fina.
                //if (contador % COLUMNAS == 0)
                //{
                //    Console.WriteLine();

                //}
                //contador++;

                //Si el codigo es menor de 100 espacio
                if (i < 100) Console.Write(" ");
                //Presento el codigo y su caracter.
                Console.Write("{0}) {1}\t", i, (char)i);
            }




            Console.WriteLine("\nPulse intro para salir");
            Console.ReadLine(); 
        }
    }
}
