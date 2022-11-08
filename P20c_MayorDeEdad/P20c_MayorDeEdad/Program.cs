using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20c_MayorDeEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Introduzca su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            EsMayorDeEdad(edad);

            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadLine();

            
        }
        static bool EsMayorDeEdad(int edad) {
            bool esMayor;
            
            if (edad >= 18) 
                esMayor = true;

           
            else 
                esMayor = false; 

            if(esMayor==true)
                Console.WriteLine("Mayor de Edad");
            else
                Console.WriteLine("Menor de Edad");
            return esMayor;
        }
    }
}
