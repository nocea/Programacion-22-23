//Alumno:Nocea Cabrera,Mario
/*P13e_Profesiones
 Tenemos una empresa que tiene 5 tipos de empleados. En la tabla siguiente se muestra
 cada tipo su sueldo por hora y el numero de horas que trabajan diariamente en la empresa

       id           Profesión          euros/h      hs/dia

         1            Albañil               12           8
         2            Gruista               15           7
         3            Electricista          16           5
         4            Fontanero             14           5
         5            Oficinista            10           2

El programa servirá para calcular cuánto nos va a costar un empleado para un trabajo,
sabiendo el número de días que tendría que trabajar

Al usuario se le presenta la tabla anterior y se le pregunta
 *    ¿Qué tipo de empleado necesitas [1..5]?
 *    ¿Cuántos días lo vas a necesitar?

Escribirá
 *    Un <tipo de empleado> durante <nº de días>  cuesta <tantos euros>

 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace P13e_CosteTrabajadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("id       Profesión         euros / h     hs / dia");

            Console.WriteLine("1        Albañil               12           8");
            Console.WriteLine("2        Gruista               15           7");
            Console.WriteLine("3        Electricista          16           5");
            Console.WriteLine("4        Fontanero             14           5");
            Console.WriteLine("5        Oficinista            10           2");
            Console.WriteLine("\n\t\t¿Qué tipo de empleado necesita?");

            //No se necesita hacer el convert.toin32 porque ya hace lo mismo.

            int opcion = Console.ReadKey(true).KeyChar - '0';
            if (opcion > 5 || opcion < 1)
            { Console.WriteLine("Tienes que elegir una opcion de trabajador."); }
            else
            {

                Console.Write("\n\t\t¿Cuantos dias lo vas a necesitar?: ");
                int dias = Convert.ToInt32(Console.ReadLine());
                if (dias < 0) Console.WriteLine("No puede ser menos de 1 dia");
                else
                {
                    switch (opcion)
                    {
                        case 1:

                            Console.WriteLine("Un albañil durante {0} dias cuesta {1} euros", dias, dias * 12 * 8);
                            break;
                        case 2:

                            Console.WriteLine("Un Gruista durante {0} dias cuesta {1} euros", dias, dias * 15 * 7);
                            break;
                        case 3:

                            Console.WriteLine("Un Electricista durante {0} dias cuesta {1} euros", dias, dias * 16 * 5);
                            break;
                        case 4:

                            Console.WriteLine("Un Fontanero durante {0} dias cuesta {1} euros", dias, dias * 14 * 5);
                            break;
                        case 5:

                            Console.WriteLine("Un Oficinista durante {0} dias cuesta {1} euros", dias, dias * 10 * 2);
                            break;


                    }
                }
            }


            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
