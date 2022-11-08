using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20d_FechaEnTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            Console.Write("Introduzca el dia: ");
            dia = Captura();
            Console.Write("Introduzca el mes: ");
            mes = Captura();
            Console.Write("Introduzca el año: ");
            año = Captura();
            Console.Write( FechaEnTexto(dia, mes, año));

            Console.WriteLine("\nPulse intro para salir");
            Console.ReadLine();
            
        }
        static int Captura()
        {
            int numero;

            
            numero = Convert.ToInt32(Console.ReadLine());

            return numero;

        }
        static string FechaEnTexto(int dia, int mes, int año) {
            string fecha = dia + " del " + mes + " del " + año;



            return fecha;
        }
    }
}
