using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace P31b_GuardarNMultiplosDesde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, cantidad, numeroDesde;
            string nombreFichero;
            
            numero = CapturaEntero("Introduce un numero de dos cifras", 10, 99);
            cantidad= CapturaEntero("Introduce la cnatidad de múltiplos a presentar", 10, 100);
            numeroDesde = CapturaEntero("Introduce el numero a partir del cual se presentaran los múltiplos", 100, 2000);
            int[] vectorMultiplos = NMultiplosDesde(numero, cantidad, numeroDesde);
            Console.Write("Introduce el nombre del fichero: ");
            nombreFichero = Console.ReadLine();        
            StreamWriter sw = File.CreateText(@"..\Debug\" + nombreFichero+".TXT");
            
            for (int i = 0; i < vectorMultiplos.Length-1; i++)
            {
                sw.Write(vectorMultiplos[i]+";");
            }
            sw.Write(vectorMultiplos[vectorMultiplos.Length-1]);
            sw.Close();
            CerrarPrograma();
        }
        static int[] NMultiplosDesde(int num,int cantidad,int numDesde)
        {
            int[]vMultiplos=new int[cantidad];
            int multiplo; 
            multiplo=num * (numDesde / num) + num;
            for (int i = 0; i < cantidad; i++)
            {
                vMultiplos[i] = multiplo;
                multiplo += num;
            }
            return vMultiplos;
        }
        static void CerrarPrograma()
        {
            Console.WriteLine("Pulsa una tecla para cerrar el programa");
            Console.ReadKey();
        }
        public static int CapturaEntero(string mensaje, int min, int max)
        {
            int valor = 0;
            bool esCorrecto = false;
            do
            {
                Console.Write("{0} ({1}..{2}): ", mensaje, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);//el usuario escribe algo y pulsa INTRO
                if (!esCorrecto || valor < min || valor > max)
                {
                    Console.WriteLine(" ** NO VALIDO. ({0} a {1})  ** Pulsa Intro", min, max);
                    Console.Beep(400, 400);
                }
            }
            while (!esCorrecto || valor < min || valor > max);

            return valor;
        }
    }
}
