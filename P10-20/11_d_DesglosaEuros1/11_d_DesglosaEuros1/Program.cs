//Alumno:Nocea,Mario
//11_d_DesglosaEuros
/*Introduces una cantidad de euros y la desglosa en billetes de 20,billetes de 5 y monedas de 1 euro*/
using System;


namespace _11_d_DesglosaEuros1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinero,b20,b5,m1;//me ahorro la variable resto aunque despues en la solucion no se podra poner la primera cantidad introducida.
            //Se crea una variable para introducir el dinero que se ira actualizando.
            //y las variables para guardar la cantidad de billetes y de monedas.
           
            Console.Write("\n\tIntroduce una cantidad de dinero: ");
            dinero=Convert.ToInt32(Console.ReadLine());
            //Para saber los billetes de 20 que tengo los divido entre 20.
            b20 = dinero / 20;
            //El dinero que me queda lo se al obtener el resto del dinero entre los billetes de 20.
            dinero = dinero % 20;
            //Para saber los billetes de 5 divido el resto que he obtenido antes entre 5.
            b5 = dinero/5;
            //El resto que me queda de los billetes de 5 son las monedas de 1 euro.
            m1 = dinero % 5;
            
            Console.WriteLine("\n\tSerian {0} billetes de 20,{1} billetes de 5 y {2} monedas de 1 euro", b20,b5,m1);
            Console.WriteLine("\n\n\tPulse intro para salir.");
            Console.ReadLine();











        }
    }
}
