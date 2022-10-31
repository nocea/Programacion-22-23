//Alumno:Nocea Cabrera,Mario
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P14j_CosteTrabajadoresV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion,cantidad=0,euros=0,dias;
            bool ok;
            
            do
            {
                do
                {
                    Console.WriteLine("id   Trabajador  euros/h hs/día");
                    Console.WriteLine("-- ------------- ------- ------");
                    Console.WriteLine("1  Albañil        12      8");
                    Console.WriteLine("2  Gruista        15      7");
                    Console.WriteLine("3  Electricista   16      5");
                    Console.WriteLine("4  Fontanero      14      5");
                    Console.WriteLine("5  Oficinista     10      2");
                    Console.WriteLine("\nElija el trabajador (0 =salir)");
                    opcion = Console.ReadKey(true).KeyChar - '0';
                    if (opcion < 0 || opcion > 5) Console.WriteLine("Error: Introduce una opcion valida");
                } while (opcion < 0 || opcion > 5);
                
                switch (opcion) {
                    case 1:
                        do
                        {
                            Console.Write("¿Cuantos albañiles necesita?: ");
                            ok = Int32.TryParse(Console.ReadLine(), out cantidad);
                            if (!ok || cantidad <= 0) Console.WriteLine("Error");
                            else
                            {
                                Console.Write("Cuantos dias lo necesita:");
                                ok = Int32.TryParse(Console.ReadLine(), out dias);
                                if (!ok || dias <= 0) Console.WriteLine("No pueden ser menos que 0");
                                else
                                {
                                    euros = euros + (cantidad * 12 * dias * 8);
                                }
                            }
                           
                        } while (!ok);
                        
                        break;  
                    case 2:
                        do
                        {
                            Console.Write("¿Cuantos Gruista necesita?: ");
                            ok = Int32.TryParse(Console.ReadLine(), out cantidad);
                            if (!ok || cantidad <= 0) Console.WriteLine("Error");
                            else
                            {
                                Console.Write("Cuantos dias lo necesita:");
                                ok = Int32.TryParse(Console.ReadLine(), out dias);
                                if (!ok || dias <= 0) Console.WriteLine("No pueden ser menos que 0");
                                else
                                {
                                    euros = euros + (cantidad * 12 * dias * 8);
                                }
                            }

                        } while (!ok);
                        break;
                    case 3:
                        do
                        {
                            Console.Write("¿Cuantos Electricista necesita?: ");
                            ok = Int32.TryParse(Console.ReadLine(), out cantidad);
                            if (!ok || cantidad <= 0) Console.WriteLine("Error");
                            else
                            {
                                Console.Write("Cuantos dias lo necesita:");
                                ok = Int32.TryParse(Console.ReadLine(), out dias);
                                if (!ok || dias <= 0) Console.WriteLine("No pueden ser menos que 0");
                                else
                                {
                                    euros = euros + (cantidad * 12 * dias * 8);
                                }
                            }

                        } while(!ok);
                        break;
                    case 4:
                        do
                        {
                            Console.Write("¿Cuantos Fontanero necesita?: ");
                            ok = Int32.TryParse(Console.ReadLine(), out cantidad);
                            if (!ok || cantidad <= 0) Console.WriteLine("Error");
                            else
                            {
                                Console.Write("Cuantos dias lo necesita:");
                                ok = Int32.TryParse(Console.ReadLine(), out dias);
                                if (!ok || dias <= 0) Console.WriteLine("No pueden ser menos que 0");
                                else
                                {
                                    euros = euros + (cantidad * 12 * dias * 8);
                                }
                            }

                        } while (!ok);
                        break;
                    case 5:
                        do
                        {
                            Console.Write("¿Cuantos Oficinista necesita?: ");
                            ok = Int32.TryParse(Console.ReadLine(), out cantidad);
                            if (!ok || cantidad <= 0) Console.WriteLine("Error");
                            else
                            {
                                Console.Write("Cuantos dias lo necesita:");
                                ok = Int32.TryParse(Console.ReadLine(), out dias);
                                if (!ok || dias <= 0) Console.WriteLine("No pueden ser menos que 0");
                                else
                                {
                                    euros = euros + (cantidad * 12 * dias * 8);
                                }
                            }

                        } while (!ok);
                        break;                                             
                }
                
                
            } while (opcion != 0);
            Console.Clear();
            Console.WriteLine("El coste total de {0} trabajadores es de {1} euros",cantidad,euros);

            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
