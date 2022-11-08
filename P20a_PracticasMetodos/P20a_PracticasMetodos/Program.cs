using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20a_PracticasMetodos
{
    internal class Program
    {
        const double PI = 3.14159;
        static void Main(string[] args)
        {
            int radio;


            Console.Write("\n\tHola, introduce el radio de la circunferencia: ");
            radio = Convert.ToInt32(Console.ReadLine());

            AreaCirculo(radio);
            PerimetroCirculo(radio);

            Console.WriteLine("\n\tPulse intro para salir");
            Console.ReadLine();
        }

        static double AreaCirculo(int radio)
        {

            double area = PI * radio * radio;

            Console.Write("\n\tEl área de la circunferencia es: {0}", area);
            return area;
        }
        static double PerimetroCirculo(int radio)
        {
            double perimetro = 2 * PI * radio;
            Console.Write("\n\tEl perimetro de la circunferencia es: {0}", perimetro);
            return perimetro;
        }
    }
}s
