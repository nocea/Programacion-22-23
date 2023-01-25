using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaEnteroConIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = CapturaEnteroConIntro("Introduce un valor", 10, 20,true);
            Console.WriteLine(numero);
            Console.ReadLine();
        }
        static int CapturaEnteroConIntro(string txt,int min, int max, bool conSinIntro)
        {
            int valor = 0;
            bool ok;
            string captura;
            do
            {
                Console.WriteLine("{0}: [{1}...{2}]", txt, min, max);
                captura = Console.ReadLine();
                if (captura == "" && conSinIntro)
                    return 0;
                ok = Int32.TryParse(captura, out valor);
                if (ok)
                {
                    if (valor > max || valor < min)
                    {
                        Console.WriteLine("Valor fuera de Rango");
                        ok = false;
                    }
                }
                else
                {
                    Console.WriteLine("El valor introducido no es válido.");
                }
            } while (!ok);
            return valor;
        }
        static int CapturaEntero(string txt,int min,int max)
        {
            int valor=0;
            bool ok;
            string captura;
            do
            {
                Console.WriteLine("{0}:[{1}...{2}]",txt,min,max);
                captura = Console.ReadLine();
                if (captura == "")
                    return 0;
                
                ok = Int32.TryParse(captura, out valor);
                if (ok)
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine("El valor introducido está fuera de rango");
                        ok = false;
                    }
                }
            } while (!ok);
            return valor;

        }

    }
}
