using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14f_SumadorYMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, num, contador = 0; ;
            bool ok;
            string captura;//Se declara la variable captura para poder obtner un valor vacio
            Console.WriteLine("\t\t--Introduce numero para sumar,Intro para salir--");
            
            do
            {
                Console.Write("NÚMERO {0}: ", contador + 1);//Se pone el contador +1 pero no se incrementa y se guarda saldria mas uno en todos los intentos.
                captura = Console.ReadLine();//se captura una primera vez.
                if (captura != "")//Si no está vacío entra
                {
                    ok = Int32.TryParse(captura, out num);//intenta guardar captura en num.
                    if (ok)//Si puede lo suma e incrementa
                    {
                        suma += num;
                        contador++;
                    }
                    else//si no puede guardarlo se da el mensaje de error
                    {
                        Console.WriteLine("Error de formato");
                    }
                }



            } while (captura!="");//Se repite siempre que no sea vacio.

            if (contador > 0)//control si el contador no se ha incrementado (si se ha introducido algun valor valido se hace la suma y media)
            {
                double media = 1.0 * suma / contador;
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Media: " + media);
            }
            else
            {
                Console.WriteLine("No hay nada que sumar");
            }
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
