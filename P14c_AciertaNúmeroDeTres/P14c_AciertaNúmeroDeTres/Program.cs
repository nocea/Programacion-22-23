using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14c_AciertaNúmeroDeTres
{
    internal class Program
    { 
        static void Main(string[] args)
        {Random random=new Random();
            int numeroRandom = random.Next(10, 20+1);
            //Prueba dev.
            Console.WriteLine("Prueba dev:"+numeroRandom);
            int numeroElegir=0;
            int contador=0;
            Console.WriteLine("Tienes tres oportunidades para acertar el numero: {10-20} ");
            int puntos = 0;
            do
            {
                contador++;
                Console.Write("{0}: ",contador);
                numeroElegir=Convert.ToInt32(Console.ReadLine());
                if (numeroElegir < 10 || numeroElegir > 20) Console.WriteLine("Numero fuera de rango,intentalo otra vez");
                else
                {
                    if (numeroElegir < numeroRandom) Console.WriteLine("Te has quedado corto");
                        else if (numeroElegir > numeroRandom) Console.WriteLine("Te has pasado");                                   
                }
            } while (contador != 3 && numeroElegir!=numeroRandom);
            if (contador == 3 && numeroElegir != numeroRandom) { puntos = 0; }
            else if (contador == 1) { puntos = 100; }
            else if (contador == 2) { puntos = 60; }
            else if (contador == 3) { puntos = 40; }

            if (contador == 3 && numeroElegir != numeroRandom) Console.WriteLine("Ha fallado el numero era {0}",numeroRandom);
            else Console.WriteLine("Ha acertado,el numero era {0}",numeroRandom);
            Console.WriteLine("Puntos: {0}",puntos);
            Console.WriteLine("Pulsa intro para salir");
            Console.ReadLine();
        }
    }
}
