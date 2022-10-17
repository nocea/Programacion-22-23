using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_d_DesglosaEuros3
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            int dinero, b20, b5, m1,resto;//me ahorro la variable resto aunque despues en la solucion no se podra poner la primera cantidad introducida.
                                    //Se crea una variable para introducir el dinero que se ira actualizando.
                                    //y las variables para guardar la cantidad de billetes y de monedas.

            Console.Write("\n\tIntroduce una cantidad de dinero: ");
            dinero = Convert.ToInt32(Console.ReadLine());
            //Para saber los billetes de 20 que tengo los divido entre 20.
            b20 = dinero / 20;
            //El dinero que me queda lo se al obtener el resto del dinero entre los billetes de 20.
            resto = dinero % 20;
            //Para saber los billetes de 5 divido el resto que he obtenido antes entre 5.
            b5 = resto / 5;
            //El resto que me queda de los billetes de 5 son las monedas de 1 euro.
            m1 = resto % 5;
            //Control si ha billetes de 20,billetes de 5 o monedas de 1.
            if (dinero == 0)  Console.WriteLine("NO ha introducido dinero"); 
            else {
                Console.Write("{0} euros son: ", dinero);
                if(b20>0)
                Console.Write("{0} billetes de 20; ",b20);
                if (b5 > 0)
                    Console.Write("{0} billetes de 5; ",b5);
                if (m1 > 0)
                    Console.Write("{0} monedas de 1;",m1);



            }
               
                
               





            
            /*else if (b20 == 0 && b5 == 0) Console.WriteLine("\n\tSerian {0} monedas de 1 euro.",m1);
                else if (b20 == 0 && m1 == 0) Console.WriteLine("Serian {0} billetes de 5 euros.", b5);
                else if (m1 == 0 && b5 == 0) Console.WriteLine("\n\tSerian {0} billetes de 20", b20);
                else if (m1 == 0) Console.WriteLine("\n\tSerian {0} billetes de 20,{1} billetes de 5", b20, b5);
                else if (b5 == 0) Console.WriteLine("\n\tSerian {0} billetes de 20,{1} monedas de 1", b20, m1);*/


            Console.WriteLine("\n\n\tPulse intro para salir.");
            Console.ReadLine();
        }
    }
}
