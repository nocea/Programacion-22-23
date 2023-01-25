using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22f1_CapturaFechaString
{
    internal class Program
    {   static int[]maxdias= { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static string[]nombreMes={ "", "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
        static void Main(string[] args)
        {
            Console.WriteLine(CapturaFechaString());
            Console.ReadLine();
        }
        static string CapturaFechaString()
        {
            int año, mes, dia=0;
            Console.WriteLine("Introduce un año: ");
            año = Convert.ToInt32(Console.ReadLine());
            mes = CapturaEntero("Introduce un mes:", 1, 12);
            dia = CapturaEntero("Introduce el dia:", 1, maxdias[mes]);
            return String.Format("{0} de {1} de {2}", dia, nombreMes[mes], año);
        }
        static int CapturaEntero(string txt,int min,int max)
        {
            int valor;
            bool ok;
            do
            {
                Console.WriteLine("{0}: [{1}...{2}]",txt,min,max);
                ok = Int32.TryParse(Console.ReadLine(), out valor);
                if (ok)
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine("Valor fuera de rango");
                        ok = false;
                    }

                }
            } while (!ok);
            return valor;
        }
    }
}
