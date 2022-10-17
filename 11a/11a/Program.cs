//Alumno: Nocea,Mario
/*Pilla Area y el perimetro de un Circulo
 * Se introduce el radio de un circulo
 * Imprimira la longitud de su circunferencia y su área
 * longitud= 2*pi*r area=pi*r al cuadrado.
 */
using System;


namespace _11a
{
    internal class Program
    {
        const double PI = 3.14159;
        static void Main(string[] args)
        {
            int radio;
            double perimetro,area;
            
            Console.Write("\n\tHola, introduce el radio de la circunferencia: ");
            radio=Convert.ToInt32(Console.ReadLine());
            perimetro = 2 * PI * radio;
            area = PI * radio * radio;
            Console.Write("\n\tLa longitud de la circunferencia es: {0}", perimetro);
            Console.Write("\n\tEl área de la circunferencia es: {0}",area);

            Console.WriteLine("\n\tPulse intro para salir");
            Console.ReadLine();
            


        }
    }
}
