//Alumno:Nocea,Mario
/*Repetir la practica de la ecuacion de segundo grado (p11c) haciendo que,
 * si el discriminante da negativo,presente un mensaje advirtiéndolo en lugar del resultado.
 * "**Sin soluciones reales:Discriminante negativo**"
 */


using System;


namespace _12_b_EcuacionGrado2plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x1, x2;

            Console.Write("\n\tIntroduzca el primer coeficiente (a): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tIntroduzca el segundo coeficiente (b): ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tIntroduzca el tercer coeficiente (c): ");
            c = Convert.ToInt32(Console.ReadLine());
            //Para redondear : Math.Round(numeroaredondear,decimales);
            x1 = Math.Round((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 3);
            x2 = Math.Round((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a), 3);
            if ((b * b - 4 * a * c)<0) { Console.WriteLine("**Sin soluciones reales:Discriminante negativo**"); }
            else
            {

                Console.Write("\n\tPrimera solución: {0}", x1);
                Console.Write("\n\tSegunda solución: {0}", x2);
            }

            Console.WriteLine("\n\n\tPulse Intro para salir.");
            Console.ReadLine();




        }
    }
}
