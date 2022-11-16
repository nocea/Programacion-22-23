using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_EntrenandoConVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vVector1 = new int[10];
            Random r = new Random();
            for (int i = 0; i < vVector1.Length; i++)
            {
                vVector1[i] = r.Next(1, 1001);
            }
            Console.WriteLine("Entrenamiento0");
            for (int i = 0; i < vVector1.Length; i++)
            {
                Console.WriteLine("\n" + vVector1[i]);
            }
            Console.WriteLine("Pulse para el siguiente entrenamiento");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Entrenamiento1");
            int tamaño = CapturaEntero("Introduce el tamaño del vector",10,100);
            int[] vVector2 = new int[tamaño];

            for (int i = 0; i < vVector2.Length; i++)
            {
                vVector2[i]= r.Next(1, 1001);
            }
            for (int i = 0; i < vVector2.Length; i++)
            {
                Console.WriteLine("\n{0}){1}",i,vVector2[i]);
            }

            Console.WriteLine("Pulse para el siguiente entrenamiento");
            Console.ReadLine();
            Console.Clear();

            tamaño= CapturaEntero("Introduce el tamaño del vector", 10, 100);
            char[] vVector3 = new char[tamaño];
            for (int i = 0; i < vVector3.Length; i++)
            {
                vVector3[i] = (char)r.Next(32,126);

            }
            for (int i = 0; i < vVector3.Length; i++)
            {
                Console.WriteLine("\n{0}){1}--->{2}", i, vVector3[i],(int)vVector3[i]);
            }

            Console.WriteLine("Entrenamiento2");
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                Console.Clear();
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
