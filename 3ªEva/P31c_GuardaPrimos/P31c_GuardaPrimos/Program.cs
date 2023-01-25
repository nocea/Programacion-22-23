//Alumno=Nocea Cabrera,Mario
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace P31c_GuardaPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int top;
            List<int> listaPrimos = new List<int>();
            string nombre=String.Empty;
            //Main
            top =CapturaEntero("Introduce el limite superior", 10, 10000);
            nombre = "C:\\zDatosPrueba\\primos Menores de" + top+".txt";
            StreamWriter sw = File.CreateText(nombre);

            listaPrimos = ListaDePrimos(top);
            sw.Write(listaPrimos[0]);
            for (int i = 1; i < listaPrimos.Count; i++)
            {
                if (i % 5 == 0)
                {
                    sw.WriteLine();
                }
                sw.Write(listaPrimos[i] + " ");
                
            }
            sw.Close();
            Console.WriteLine("Pulsa una tecla para guardar en el fichero y salir");
            Console.ReadKey();
        }
        static bool esPrimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static List<int> ListaDePrimos(int limiteSup)
        {
            List<int> lista = new List<int>();
            for (int i = 2; i < limiteSup; i++)
            {
                if (esPrimo(i) == true)
                {
                    lista.Add(i);
                }
            }
            return lista;
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
