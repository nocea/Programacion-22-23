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
    { const int PUNTMAXIMA = 100, PENALIZACION = 40, MIN=10, MAX=20;
        static void Main(string[] args)
        {Random random=new Random();
            int numeroRandom = random.Next(MIN, MAX+1);
            //Prueba dev.
            Console.WriteLine("Prueba dev:"+numeroRandom);
            int numeroElegir=-1;
            int contador=0;
            Console.WriteLine("Tienes tres oportunidades para acertar el numero: {10-20} ");
            int puntos = PUNTMAXIMA;
            do
            {
                
                Console.Write("Acierta por {0} puntos: ",puntos);
                numeroElegir=Convert.ToInt32(Console.ReadLine());
                if (numeroElegir == numeroRandom) break;
                else
                {
                    if ((numeroElegir < MIN || numeroElegir > MAX) && contador != 3) Console.WriteLine("Numero fuera de rango,intentalo otra vez");
                    else if (numeroElegir < MIN || numeroElegir > MAX) Console.WriteLine("Numero fuera de rango");
                    else
                    {
                        if (numeroElegir < numeroRandom) Console.WriteLine("Te has quedado corto");
                        else if (numeroElegir > numeroRandom) Console.WriteLine("Te has pasado");
                        //control de puntos(se va restando la penalizacion a los puntos maximos)

                    }

                    contador++;
                    puntos -= PENALIZACION;

                }

            } while (contador != 3 && numeroElegir!=numeroRandom);
          
            
            if (contador == 3 && numeroElegir != numeroRandom) Console.Write("Ha fallado");
            else Console.Write("Ha acertado");
            Console.WriteLine(",el numero era {0}",numeroRandom);
            Console.WriteLine("Puntos: {0}",puntos);
            Console.WriteLine("Pulsa intro para salir");
            Console.ReadLine();
        }
    }
}
