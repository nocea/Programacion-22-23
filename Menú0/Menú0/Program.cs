using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menú0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("\n\n\n\n\t\t\t\t   Mario Nocea");
            Console.WriteLine("\t\t\t╔══════════════════════════════╗");
            Console.WriteLine("\t\t\t║             MENU             ║");
            Console.WriteLine("\t\t\t╠══════════════════════════════╣");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║    1.- Lista de Clientes     ║");
            Console.WriteLine("\t\t\t║    2.- Añadir Cliente        ║");
            Console.WriteLine("\t\t\t║    3.- Eliminar Cliente      ║");
            Console.WriteLine("\t\t\t║    4.- Modificar Datos       ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║          0) Salir            ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t╚══════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");
            opcion=Console.ReadKey().KeyChar-'0';//Para capturar un caracter y no tener que pulsar intro
            
                Console.Clear();
            if (opcion > 0 || opcion <= 4)
                Console.Write("\t\tHa elegido la opción nº ");
            
                switch (opcion) {

                    case 0: Console.WriteLine("0: “Salir”");
                        break;
                    case 1:
                        Console.WriteLine("1: “Lista de Clientes”");
                        break;
                    case 2:
                        Console.WriteLine("2: “Añadir Cliente”");
                        break;
                    case 3:
                        Console.WriteLine("3: “Elminar Cliente”");
                        break;
                    case 4:
                        Console.WriteLine("4: “Modificar Cliente”");
                        break;
                default:Console.WriteLine("\t\t*-ERROR:HA ELEGIDO UNA OPCIÓN NO VÁLIDA-*");
                    break;
                
            }
            Console.WriteLine("\t\tPulsa intro para salir");
            Console.ReadLine();
        }
    }
}
