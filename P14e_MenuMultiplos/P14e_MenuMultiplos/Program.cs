using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P14e_MenuMultiplos
{
    internal class Program
    {
        const int MIN = 500, MAX = 700;
        static void Main(string[] args)
        {
            int opcion = -1;
            int num = 0;
            int contador = 0;
            do
            {
                
                Console.WriteLine("\n\n\n\n\t\t\t\t   Mario Nocea");
                Console.WriteLine("\t\t\t╔════════════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU                   ║");
                Console.WriteLine("\t\t\t╠════════════════════════════════════╣");
                Console.WriteLine("\t\t\t║                                    ║");
                Console.WriteLine("\t\t\t║    1. Multiplos menores de 300     ║");
                Console.WriteLine("\t\t\t║    2. Cien Primeros Multiplos      ║");
                Console.WriteLine("\t\t\t║    3. Multiplos entre limites      ║");
                Console.WriteLine("\t\t\t║    4. Multiplos desde              ║");
                Console.WriteLine("\t\t\t║                                    ║");
                Console.WriteLine("\t\t\t║            0) Salir                ║");
                Console.WriteLine("\t\t\t║                                    ║");
                Console.WriteLine("\t\t\t╚════════════════════════════════════╝");
                Console.WriteLine("\t\t\t\tIntroduce una opción");
                opcion = Console.ReadKey(true).KeyChar - '0';//Para capturar un caracter y no tener que pulsar intro
                if (opcion < 0 || opcion > 4)
                {
                    Console.WriteLine("Opcion no valida pulse una tecla para volver al menú");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    
                    switch (opcion)
                    {
                        case 1: Console.WriteLine("1.Multiplos menores de 300 ");
                            {
                                Console.Write("Introduce un numero entero de dos cifras: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                if (num < 10 || num > 99)
                                {
                                    Console.WriteLine("Numero no valido");
                                }
                                else
                                {
                                    for (int i = 1; i < 300; i++)
                                    {
                                        if (i % num == 0) Console.Write("\t" + i);
                                    }
                                }                                
                                Console.WriteLine();
                            }                           
                            break;
                        case 2:
                            Console.WriteLine("2. Cien Primeros Multiplos");
                            {
                                int multiplo = 0;
                                Console.Write("Introduce un numero entero:");
                                num = Convert.ToInt32(Console.ReadLine());
                                if (num < 10 || num > 99)
                                {
                                    Console.WriteLine("Numero no valido");

                                }
                                else
                                {
                                    for (int i = 1; i <= 100; i++)
                                    {
                                        multiplo = i * num;
                                        Console.Write("\t" + multiplo);
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.WriteLine("3. Multiplos entre limites");
                            {
                                Console.Write("Introduce un numero entero de dos cifras: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                if (num < 10 || num > 99)
                                {
                                    Console.WriteLine("Numero no valido");

                                }
                                else
                                { int multiplo = 0;
                                    for (int i = 1;multiplo<=MAX; i++)
                                    { 
                                        multiplo = i * num;
                                        if(multiplo>MIN&&multiplo<MAX) Console.Write("\t" + multiplo);
                                    }
                                }
                                Console.WriteLine();
                            }
                            
                            break;
                        case 4:
                            Console.WriteLine(opcion);
                            break;
                            
                    }
                    if (opcion != 0)
                    {
                        Console.WriteLine("Pulse para volver al menú");
                        Console.ReadLine();

                    }
                    Console.Clear();
                }
                    
                
                
                
            } while (opcion != 0);














        }
    }
}
