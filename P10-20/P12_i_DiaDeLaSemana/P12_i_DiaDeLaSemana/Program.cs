// Alumno: Nocea Cabrera,Mario

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_i_DiaDeLaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un dia del 0 al 6 siendo 0 el domingo y 6 el sabado: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            if (dia < 0 || dia > 6) Console.WriteLine("ERROR:El dia esta fuera de rango.");
            else {
                Console.WriteLine("Introduce el numero de dias que quieres avanzar: ");
                int numDias = Convert.ToInt32(Console.ReadLine());
                if (numDias < 0) Console.WriteLine("Debe introducir un numero mayor que 0.");


                //El else if significa que si es esa opcion que ejecute esa y ya no lea mas el if if if if hace que lea todas las opciones.
                else {
                    if ((dia + numDias) % 7 == 0) Console.WriteLine("Dentro de {0} dia/s será Domingo",numDias);
                    else if ((dia + numDias) % 7 == 1) Console.WriteLine("Dentro de {0} dia/s será Lunes", numDias);
                    else if ((dia + numDias) % 7 == 2) Console.WriteLine("Dentro de {0} dia/s será Martes", numDias);
                    else if ((dia + numDias) % 7 == 3) Console.WriteLine("Dentro de {0} dia/s será Miercoles", numDias);
                    else if ((dia + numDias) % 7 == 4) Console.WriteLine("Dentro de {0} dia/s será Jueves", numDias);
                    else if ((dia + numDias) % 7 == 5) Console.WriteLine("Dentro de {0} dia/s será Viernes", numDias);
                    else if ((dia + numDias) % 7 == 6) Console.WriteLine("Dentro de {0} dia/s será Sabado", numDias);
                }
            }
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
                  
        }
    }
}
