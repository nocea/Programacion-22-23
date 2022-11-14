//Alumno:Nocea,Mario
/*El programa pide un numero y te presenta en pantalla si es par o impar y si es multiplo de 3.
 Ejemplo:El numero 75 es impar y ademas múltiplo de 3*/


using System;

namespace _12_c_ParYMultiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\tIntroduzca un número: ");
            int num=Convert.ToInt32(Console.ReadLine());

            

            if (num == 0) Console.WriteLine("\n\tEl cero no es ni par ni impar"); 
            //Si el numero es cero hago eso si no es se ejecuta el else

            else {

                Console.Write("\n\tEl número {0} es ", num);//Se pone esto aqui porque se repite en todos los casos.
                                                            // Y por eso se pone al principio con su formato correcto.

                if (num % 2 == 0) Console.Write("par y ");//Control de par o impar.
                else Console.Write("impar y ");



                if (num % 3 == 0) Console.WriteLine("es múltiplo de 3");//Control de multiplo de 3.
                else Console.WriteLine("no es múltiplo de 3");
            
            }
            
            Console.WriteLine("\n\n\tPulse Intro para salir");
            Console.ReadLine();
        }
    }
}
