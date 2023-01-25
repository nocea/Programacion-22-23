//Alumno:Nocea,Mario
/*Introduces la cantida d de billetes de 20,billetes de5 y monedas de 2 euros.
 El programa averigua el total de euros y los desglosa en billetes de 50,10 y monedas de 1*/
using System;


namespace _11_e_DesglosaEuros2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Variables introduccion.
            int b20, b5, m2, total,resto;
            //Variables desglose;
            int b50, b10, m1;
            Console.Write("\n\tIntroduzca los billetes de 20: ");
            b20 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tIntroduzca los billetes de 5: ");
            b5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tIntroduzca las monedas de 2: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            //Suma de los valores introducidos para averiguar el total de dinero.
            total = (b20 * 20) + (b5 * 5) + (m2 * 2);
            //DESGLOSE EN BILLETES.
            b50 = total / 50;
            //El dinero que me queda lo se al obtener el resto del dinero entre los billetes de 50.
            resto = total % 50;
            //Para saber los billetes de 5 divido el resto que he obtenido antes entre 10.
            b10 = resto / 10;
            //El resto que me queda de los billetes de 5 son las monedas de 1 euro.
            m1 = resto % 10;
            Console.WriteLine("\n\t{0} euros serian:{1} billetes de 50,{2} billetes de 10 y {3} monedas de 1", total,b50,b10,m1);
            Console.WriteLine("\n\n\tPulse intro para salir");
            Console.ReadLine();


        }
    }
}
