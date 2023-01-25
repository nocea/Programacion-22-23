using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace P22b_BusquedaCompletaEnVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamaño, numBuscar,contador=0;

            tamaño = CapturaEntero("Introduce el tamaño del vector: ",5,100);
            int[] vEnt = new int[tamaño];
            Random random = new Random();

            for (int i=0; i<vEnt.Length; i++)
            {
                vEnt[i]=random.Next(10,100);  
            }
            for (int i = 0; i < vEnt.Length; i++)
            {
                Console.WriteLine("{0}) {1}", i, vEnt[i]);

            }
            
            do
            {
                numBuscar = CapturaEntero("Introduce le numero a buscar (0=salir): ", 0, 99);
                Console.WriteLine("El numero que ha introducido se encuentra en la posicion: ");
                for (int i = 0; i < vEnt.Length; i++)
                {   
                    if (numBuscar == vEnt[i])
                    {
                        
                        contador++;
                        Console.WriteLine("\t{0}",i);
                        

                    }
                    

                }
                
                if (contador == 0)
                {
                    Console.WriteLine("El numero {0} no se encuentra en la lista.", numBuscar);
                }
                
            } while (numBuscar != 0);
            Console.WriteLine("Pulse una tecla para salir.");
            Console.ReadKey();

        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
                else if (numero < min || numero > max)
                {
                    Console.WriteLine("**Error:Numero fuera de rango**");
                    ok = false;
                }
            } while (!ok);
            //comentario
            return numero;
        }
    }
}
