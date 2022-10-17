//Alumno: Nocea;mario
/*Pilla Area y el preimetro de un Circulo
 * Se introduce el radio de un circulo
 * Imprimira la longitud de su circunferencia y su área
 * longitud= 2*pi*r area=pi*r al cuadrado.
 */
using System;

namespace Introducción
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.Write("\n\tDime tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("\n\tBuenos dias {0}", nombre);
            Console.Write("\n\tPorfavor dime tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            /*
            de la otra forma que no es con las llaves es la siguiente
            CONCATENANDO CON EL +
            Console.Write("\n\t" + nombre + " tienes " + edad + " años, el año que viene cumples " + (edad+1));
             */

            Console.Write("\n\t{0} tienes {1} años,el año que viene cumples {2}.", nombre, edad, edad + 1);
            Console.Write("\n\tEL número de trienios cumplidos es: " + (edad / 3));


            Console.Write("\n\n\tPulsa into para salir.");
            Console.ReadLine();


        }
    }
}
