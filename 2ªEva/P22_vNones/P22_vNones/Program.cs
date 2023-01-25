using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_vNones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetir;
            int columnas;
            do
            {
                Console.Clear();
                int tamaño = CapturaEntero("Introduce el tamaño de la tabla", 5, 100);
                int[] vNones = new int[tamaño];

                CargaTablaNones(vNones);
                columnas = CapturaEntero("Introduce el numero de columnas para presentar la tabla", 1, 8);
                MuestraTabla(columnas, vNones);

                repetir = PreguntaSiNo("Quiere repetir?");
            } while (repetir);
            Console.WriteLine("\tPulse una tecla para salir");
            Console.ReadKey();
        }
        static bool PreguntaSiNo(string pregunta)
        {
            char letra;
            bool ok = false;

            do
            {

                Console.Write(pregunta);
                letra = Console.ReadKey().KeyChar;
                if (letra == 's' || letra == 'S')
                    ok = true;
                else if (letra == 'n' || letra == 'N')
                    ok = false;
                Console.Clear();
            } while (letra != 's' && letra != 'S' && letra != 'n' && letra != 'N');
            return ok;
        }
        static void CargaTablaNones(int[] array)
        {

            int impar = 1;
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = impar;
                impar += 2;


            }

        }
        static void MuestraTabla(int columnas, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % columnas == 0)
                {
                    Console.WriteLine(" ");
                }
                Console.Write("\t{0}) {1}\t", i, array[i]);
            }
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

            return numero;
        }
    }
}
