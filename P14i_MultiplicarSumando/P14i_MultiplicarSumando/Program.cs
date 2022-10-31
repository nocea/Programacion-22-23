//Alumno:Nocea Cabrera,Mario
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace P14i_MultiplicarSumando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok;
            int a, b,solucion=0;
            char opcion;
            do
            {
                do
                {
                    Console.WriteLine("Introduce un numero: ");

                    ok = Int32.TryParse(Console.ReadLine(), out a);
                    if (!ok) Console.WriteLine("Error de formato");

                } while (!ok);
                do
                {
                    Console.WriteLine("Introduce otro un numero: ");

                    ok = Int32.TryParse(Console.ReadLine(), out b);
                    if (!ok) Console.WriteLine("Error de formato");

                } while (!ok);
                if (a > b)
                {
                    for (int i = 0; i < a; i++)
                        solucion += b;
                    Console.WriteLine(solucion);
                }
                else {
                    for (int i = 0; i < b; i++)
                        solucion += a;
                    Console.WriteLine(solucion);
                }
                solucion = 0;
                do
                {
                    Console.WriteLine("Quiere hacer otra multipliacion[s=si-n=no]");
                    ok = char.TryParse(Console.ReadLine(), out opcion);
                } while (!ok||(opcion!='n'&&opcion!='s'));
                if (opcion == 's') Console.Clear();
                else if (opcion == 'n') Console.WriteLine("Gracias por usar el programa");
            } while (opcion == 's');
            

            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadLine();
        }
    }
}
