using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22d_VectorNones
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            
            
                int tamaño = CapturaEntero("Introduce el tamaño de la tabla", 5, 100);
                int[] vNones = new int[tamaño];
                CargaTablaNones(vNones);
                int columnas = CapturaEntero("Introduce el numero de columnas para presentar la tabla", 1, 8);
                MuestraTabla(columnas, vNones);
                Console.WriteLine("\tPulse una tecla para salir");
                Console.ReadKey();
            
            
        }
        static bool PreguntaSiNo(char sino)
        {
            bool vf = false;
            if (sino == 's' || sino == 'S')
                return true;
            else if (sino == 'n' || sino == 'n')
                return false;
            else Console.WriteLine("Debe introducir una opcion correcta");
            return vf;
        }
        static void CargaTablaNones(int[]array) {
            
            int impar = 1;
            for (int i = 0; i<array.Length; i++) {
                
                array[i] = impar;
                impar += 2;
                

            }

        }
        static void MuestraTabla(int columnas, int[]array)
        {
            for (int i = 0; i <array.Length; i++)
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
            //comentario
            return numero;
        }
    }
}
