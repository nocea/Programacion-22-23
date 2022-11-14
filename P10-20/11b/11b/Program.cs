//Alumno: Nocea,Mario
//11_b
/*Introduce tres numeros enteros y devuelve la media de los tres (suma de los tres y division entre tres ),
el resultado se presenta con los decimales.*/
using System;

namespace _11b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double media;

            Console.Write("\n\tIntroduce el primer numero: ");
            //Primero se resuelve lo que hay dentro del parentesis y despues lo convierte.
            //Lo captura y lo convierte a int.
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tIntroduce el segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tIntroduce el tercer numero: ");
            c = Convert.ToInt32(Console.ReadLine());
            //Formas de dividir para que salga con los decimales.
            //media =(a+b+c)/3.0
            //media = Convert.ToDouble(a + b + c) / 3;
            media = (double)(a + b + c)/3;

            Console.Write("\n\tLa media de {0}, {1},y {2} es: {3}", a, b, c, media);
            Console.WriteLine("\n\n\n\tPulse intro para salir");
            
            Console.ReadLine();
            

        }
    }
}
