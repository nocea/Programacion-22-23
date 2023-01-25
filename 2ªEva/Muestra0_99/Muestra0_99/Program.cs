using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muestra0_99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            ColocaNumsAlAzar();
            do
            {
                Console.ResetColor();
                
                num = CapturaEntero("Introduce el numero a colocar", 0, 99);
                
                ColocaNumero(num);
                
            } while (num != 0);


            Console.SetCursorPosition(0, 23);
            Console.ResetColor();
            Console.WriteLine("Gracias por usar el programa");

            Console.ReadLine();
        }
        static void MuestraNums0a99()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("    "+i+"  ");
            }
            
            for (int i = 10; i < 100; i++)
            {
                
                if (i % 10 == 0)
                {
                    Console.WriteLine("\n");
                }
                Console.Write("   " + i + "  ");
            }
            
        }
        static void ColocaNumero(int num)
        {   
            int fila = 1 + 2 * (num / 10);
            int columna = 10 + 5 * (num%10);
            Console.SetCursorPosition(columna, fila);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(num.ToString("00"));
        }
        static void ColocaNumsAlAzar()
        {
            Random random = new Random();
            int numero;
            int fila;
            int columna;
            for (int i = 0; i < 200; i++)
            {
                numero = random.Next(0, 100);
                fila = 1 + 2 * (numero / 10);
                columna = 10 + 5 * (numero % 10);
                Console.SetCursorPosition(columna, fila);
                Console.Write(numero.ToString("00"));

            }
            

        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            
            do
            {
                Console.SetCursorPosition(0, 22); 
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);                                                               
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
               
                else if (numero < min || numero > max)
                {
                    Console.WriteLine("**Error:Numero fuera de rango**");
                    ok = false;
                }
                Console.SetCursorPosition(40, 22);
                
                Console.Write("   ");
            } while (!ok);
            //comentario
            return numero;
        }
    }
}
