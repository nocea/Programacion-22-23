//Alumno:Nocea Cabrera,Mario
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P14h_MultiplosEnColumnas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok;
            int cant,num,min,nc;
           
            do {
                Console.WriteLine("Introduce la cantidad de numeros a presentar[100-300]");
                
                ok = Int32.TryParse(Console.ReadLine(), out cant);
                if (!ok) Console.WriteLine("Error de formato");
                else if (cant < 100 || cant > 300) Console.WriteLine("Valor fuera de rango");
            } while (!ok|| cant < 100 || cant > 300);
            do
            {
                Console.WriteLine("Introduce el numero del que vamos a sacar sus multiplos[11-77]");

                ok = Int32.TryParse(Console.ReadLine(), out num);
                if (!ok) Console.WriteLine("Error de formato");
                else if (num <11 || num > 77) Console.WriteLine("Valor fuera de rango");
            } while (!ok || num < 11 || num > 77);
            do
            {
                Console.WriteLine("Introduce el valor a partir del cual hallaremos sus multiplos[1000-2000]");

                ok = Int32.TryParse(Console.ReadLine(), out min);
                if (!ok) Console.WriteLine("Error de formato");
                else if (min < 1000 || min > 2000) Console.WriteLine("Valor fuera de rango");
            } while (!ok || min < 1000 || min > 2000);
            do
            {
                Console.WriteLine("Introduce el numero de columnas de la presentacion[3-8]");

                ok = Int32.TryParse(Console.ReadLine(), out nc);
                if (!ok) Console.WriteLine("Error de formato");
                else if (nc <3 || nc > 8) Console.WriteLine("Valor fuera de rango");
            } while (!ok || nc < 3 || nc > 8);
            int multiplo = (min / num) * num;

            if (multiplo < min)
                multiplo += num;
            for (int i = 0; i < cant; i++)
            {
                
                if (i % nc == 0)
                    Console.WriteLine();

                Console.Write(" "+ multiplo);
                multiplo += num;
            }




            Console.WriteLine("\n\nPulse una tecla para salir");
            Console.ReadLine();
        }
    }
}
