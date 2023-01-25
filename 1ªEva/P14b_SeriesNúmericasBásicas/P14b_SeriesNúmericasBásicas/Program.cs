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
            int opcion;
            //BUCLE:Se utiliza para poder hacer que se repita mientras que no se pulse la opcion de salir (0) y asi se puede mantener en la app sin tener que salir despues de cada opcion.
            do
            {//menu
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
                //Pulsar opcion sin que salga en pantalla con el true
                opcion = Console.ReadKey(true).KeyChar - '0';
                //limpio pantalla
                Console.Clear();
                //Controlo error de opciones para que no se pueda elegir una opcion fuera del rango y doy el mensaje de error
                if (opcion < 0 || opcion > 3) Console.WriteLine("Error tiene que introducir una opcion valida");
                else
                {//opciones
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\n\t1.- Enteros positivos menores de 200\n");
                            for (int i = 1; i < 200; i++)
                            {
                                Console.Write("{0}\t", i);
                            }
                            break;
                        case 2:
                            int num = 0;
                            Console.WriteLine("\n\t2.- Números pares menores de 200\n");
                            while (num < 200)
                            {
                                if (num % 2 == 0) Console.Write("{0}\t", num);
                                num++;
                            }
                            break;
                        case 3:
                            int numero = 201;
                            Console.WriteLine("\n\t3.- Números impares entre 200 y 500\n");
                            while (numero < 500)
                            {
                                Console.Write("{0}\t", numero);
                                numero += 2;
                            }
                            break;
                    }
                    //si la opcion no es la de salir (0) se hace una pausa para pulsar y volver al menu para poder limpiar pantalla.
                    if (opcion != 0)
                    {
                        Console.WriteLine("\n\nPulse volver al menú");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                //si la opcion es 0 sale del bucle y se pulsa una tecla para salir.
            } while (opcion != 0);
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }
    }
}
