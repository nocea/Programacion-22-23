// Alumno: Nocea,Mario.
/* P11f)	Intercambia enteros: 
 Añade el código necesario, SIN MODIFICAR EL QUE YA ESTÁ ESCRITO, para que el programa haga lo siguiente:
 Se introducen los valores de dos variables enteros (x e y) 
 Se intercambia sus valores, es decir, el valor de x tiene que quedar en y, y viceversa.
 Para comprobar que el intercambio se ha realizado correctamente, se escribirán sus valores, antes y después del intercambio. 
*/
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int x, y,a;


        Console.Write("\nDime el valor de la variable x: ");
        x = Convert.ToInt32(Console.ReadLine());


        Console.Write("\nDime el valor de la variable y: ");
        y = Convert.ToInt32(Console.ReadLine());    


        Console.WriteLine("\n\tValores ANTES del intercambio:  \t x={0};  y={1}", x, y);
        a = x;
        x = y;
        y = a;

        Console.WriteLine("Pulse intro para intercambiar valores");
        Console.ReadLine();

        Console.WriteLine("\n\tValores DESPUÉS del intercambio:\t x={0};  y={1}", x, y);

        Console.Write("\n\n\n\t\tPulsa Intro para salir");
        Console.ReadLine();
    }
}
