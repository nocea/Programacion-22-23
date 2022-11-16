using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21e_MetodoMenu
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num = 0;
            int opcion = -1;
            while (opcion != 0)
            {
                opcion = MetodoMenu();
                if (opcion != 0)
                {
                    num = CapturaEntero("Dime un numero de dos cifras: ", 10, 99);
                }

                switch (opcion)
                {
                    case 1:
                        MultiplosMenoresDe(num, 300);
                        break;
                    case 2:
                        PrimerosMultiplos(num, 100);
                        break;
                    case 3:
                        MultiplosEntre(num, 500, 700);
                        break;
                    case 4:
                        NMultiplosDesde(num, 80, 700);                     
                        break;
                }
                if (opcion != 0)
                {
                    Console.WriteLine("\nPulse intro para volver al menu");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            Console.WriteLine("Gracias por usar el programa.");
            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadLine();
        }
        static int MetodoMenu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\t\t\t\t   Mario Nocea");
                Console.WriteLine("\t\t\t╔════════════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU                   ║");
                Console.WriteLine("\t\t\t╠════════════════════════════════════╣");
                Console.WriteLine("\t\t\t║                                    ║");
                Console.WriteLine("\t\t\t║    1. Multiplos menores de 300     ║");
                Console.WriteLine("\t\t\t║    2. Cien Primeros Multiplos      ║");
                Console.WriteLine("\t\t\t║    3. Multiplos entre limites      ║");
                Console.WriteLine("\t\t\t║    4. 80 Multiplos desde   700     ║");
                Console.WriteLine("\t\t\t║                                    ║");
                Console.WriteLine("\t\t\t║            0) Salir                ║");
                Console.WriteLine("\t\t\t║                                    ║");
                Console.WriteLine("\t\t\t╚════════════════════════════════════╝");
                Console.WriteLine("\t\t\t\tIntroduce una opción");
                opcion = Console.ReadKey(true).KeyChar - '0';
                
            } while (opcion < 0 || opcion > 4);
            return opcion;

        }
        static void MultiplosMenoresDe(int n, int limiteSup)
        {
            Console.WriteLine("1.Multiplos menores de 300 ");
            //--- Resuelto con while
            int mult = n; // <-- El primer múltiplo.
            int suma = 0; // <-- Importante la inicialización.
            while (mult < limiteSup)  // Mientras el múltiplo sea menor del límite superior
            {
                Console.Write("{0}\t", mult);
                mult += n;// <-- Obtengo el siguiente 
                suma += mult;                   // <-- Lo añadimos a la suma
                                                // <-- Obtengo el siguiente
            }
            Console.WriteLine("\nLa suma de los numeros multiplos de {0} menores de 300 es igual a {1}", n, suma);

            // Lo mismo, hecho con for
            // int suma = 0; // <-- Importante la inicialización.

            //for (int mult = n; mult < limiteSup; mult+=n)
            //{
            //   Console.Write("{0}\t", mult);   // <-- Escribo el múltiplo
            //   suma += mult;                   // <-- Lo añadimos a la suma
            //}


        }
        static int CapturaEntero(string texto, int min, int max)
        {
            
            bool esCorrecto;
            int valor;
            do
            {
                Console.Write("{0} [{1}..{2}]:", texto, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto)
                    Console.WriteLine("\n\n\t** Error: el valor introducido no es un número entero");
                else if (valor < min || valor > max)
                {
                    esCorrecto = false;
                    Console.WriteLine("\n\n\t** Error: el valor introducido no está dentro del rango");
                }
            } while (!esCorrecto);
            return valor;
        }
        static void PrimerosMultiplos(int num, int limite)
        {
             Console.WriteLine("2. Cien Primeros Multiplos");
            int multiplo = 0;




            for (int i = 1; i <= limite; i++)
            {
                multiplo = i * num;
                Console.Write("\t" + multiplo);
            }

            Console.WriteLine();

        }
        static void MultiplosEntre(int num, int min, int max)
        {

            Console.WriteLine("3. Multiplos entre limites");

            int multiplo = 0;
            multiplo = (min / num) * num;//Genero el primer multiplo

            if (multiplo < min)
                multiplo += num;// múltiplo de num inmediatamente superior a 500

            //---- Busco y muestro todos los demás múltiplos (menores o iguales a 700)
            while (multiplo <= max)
            {


                Console.Write("\t{0}", multiplo);
                multiplo += num;
            }

        }
        static void NMultiplosDesde(int num,int max,int aPartir)
        {
            Console.WriteLine("4.Multiplos desde 700");
            int multiplo = 0;
            //---- Averiguamos el primer múltiplo:
            // Múltiplo igual o inmediatamente anterior a 700
            multiplo = (700 / num) * num;
            //Como el 700 está incuido, sólo incremento múltiplo si ha salido menor
            if (multiplo < 700)
                multiplo += num;

            // A partir de ese número incluido, escribo 80 más 
            for (int i = 0; i < 80; i++)
            {
                

                Console.Write("\t" + multiplo);
                multiplo += num;
            }
        }
    }
    
}
