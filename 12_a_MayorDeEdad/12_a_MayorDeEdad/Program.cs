//Alumno:Nocea,Mario.
/*El programa pude tu nombre y tu edad.Si tu edad es 18 o más presentará un mensaje:
 "Buenos días nombre.Ya eres mayor de edad".
  En caso contrario presenta otro mensaje:
 "Buenos días fulanito.Te faltan x años para ser mayor de edad"*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_a_MayorDeEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            Console.Write("\n\tIntroduce tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("\n\tIntroduce tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18) Console.WriteLine("\n\tBuenos días {0}.Ya eres mayor de edad", nombre);
            else
            {
                if (edad == 17) 
                { 
                    Console.WriteLine("\n\tBuenos días {0}.Te falta un año para ser mayor de edad"); 
                }
                else
                {
                    Console.WriteLine("\n\tBuenos días {0}.Te faltan {1} años para ser mayor de edad", nombre, 18 - edad);
                }
            }

            Console.WriteLine("\n\n\tPulsa intro para salir");
            Console.ReadLine();






        }
    }
}
