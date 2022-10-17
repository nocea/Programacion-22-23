using System;

namespace _12_g_CapturaEntero2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el primer valor del limite: ");/*Guardo el primer limite*/
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo valor del limite: ");/*Guardo el segundo limite*/
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int num;/*En lugar de crear una variable auxiliar dejamos la num y despues la cambiamos por el numero que introduzcamos por pantalla.*/
            if (min > max) { /*Intercambio las variables de maximo o minimo si el minimo es mas grande que el maximo*/
                
                num = min;
                min = max;
                max = num;
            }
                Console.Write("Introduce un numero entre {0} y {1}: ", min, max);
                num = Convert.ToInt32(Console.ReadLine());/*Aqui se cambia el valor que tuviera num por el que capturemos.*/
                if (num > max || num < min)/*Controlo si el numero introducido esta dentro de rango*/
                {
                    Console.WriteLine("--ERROR:El numero está fuera de rango--");
                }
                else Console.WriteLine("Correcto el numero elegido es: {0}", num);
            Console.WriteLine("Pulsa intro para salir");
            Console.ReadLine();
        }
    }
}
