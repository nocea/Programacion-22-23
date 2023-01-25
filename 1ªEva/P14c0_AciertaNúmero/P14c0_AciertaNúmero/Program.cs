using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14c0_AciertaNúmero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do//Lo hago una vez y hasta que no sea el numero correcto no salgo del  bucle
            {
                Console.WriteLine("Introduce un numero entre el 10 y el 20: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 10 || a > 20) { Console.WriteLine("El numero introducido tiene que estar entre 10 y 20");
                    Console.WriteLine("Pulsa una tecla para volever a introducir un numero.");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (a < 10 || a > 20);
            Console.Clear();
            int b;
            int contador = 0;
            Console.WriteLine("Introduce un numero entre el 10 y el 20: ");
            b= Convert.ToInt32(Console.ReadLine());//Lo pregunto la primera vez
            Console.Clear();
            //y ya entro en el bucle hasta que sea a igual a b.
            while (b != a) { Console.WriteLine("Ha fallado inténtelo otra vez: ");
                contador++; //aumento e contador  para los intentos.
            b = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }               
            Console.WriteLine("Acertaste en {0} intentos",contador);
            Console.WriteLine("Pulsa intro para salir");
            Console.ReadLine();
        }

    }
}
