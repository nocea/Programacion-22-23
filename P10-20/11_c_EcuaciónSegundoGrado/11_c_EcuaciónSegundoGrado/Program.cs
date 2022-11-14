//Alumno:Nocea,Mario.
using System;


namespace _11_c_EcuaciónSegundoGrado
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
            x1 = Math.Round((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a),3);
            x2 = Math.Round((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a),3);

            Console.Write("\n\tPrimera solución: {0}", x1);
            Console.Write("\n\tSegunda solución: {0}", x2);

            Console.WriteLine("\n\n\tPulse Intro para salir.");
            Console.ReadLine();
        }
    }
}
