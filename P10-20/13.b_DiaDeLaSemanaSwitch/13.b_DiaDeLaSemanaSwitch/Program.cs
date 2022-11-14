using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.b_DiaDeLaSemanaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce un dia del 0 al 6 siendo 0 el domingo y 6 el sabado: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            if (dia < 0 || dia > 6) Console.WriteLine("ERROR:El dia esta fuera de rango.");
            else
            {
                Console.WriteLine("Introduce el numero de dias que quieres avanzar: ");
                int numDias = Convert.ToInt32(Console.ReadLine());
                if (numDias < 0) Console.WriteLine("Debe introducir un numero mayor que 0.");


                //El else if significa que si es esa opcion que ejecute esa y ya no lea mas el if if if if hace que lea todas las opciones.
                else
                {
                    int resto = (dia + numDias) % 7;

                    switch (resto) {
                        case 0:
                            Console.WriteLine("Dentro de {0} dia/s será Domingo", numDias);
                            break;
                        case 1:
                            Console.WriteLine("Dentro de {0} dia/s será Lunes", numDias);
                            break;
                        case 2:
                            Console.WriteLine("Dentro de {0} dia/s será Martes", numDias);
                            break;
                        case 3:
                            Console.WriteLine("Dentro de {0} dia/s será Miércoles", numDias);
                            break;
                        case 4:
                            Console.WriteLine("Dentro de {0} dia/s será Jueves", numDias);
                            break;
                        case 5:
                            Console.WriteLine("Dentro de {0} dia/s será Viernes", numDias);
                            break;
                        case 6:
                            Console.WriteLine("Dentro de {0} dia/s será Sábado", numDias);
                            break;
                    }  
                }
            }
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
