//Alumno:Nocea Cabrera,Mario
using System;

namespace P14k_BuscaMinimoMaximo
{
    internal class Program
    {
        const int COLUMNAS = 5;
        static void Main(string[] args)
        {
            int limiteMinimo, limiteMaximo, contador = 0;
            int numeroPresentar, numeroMaximo = -1;
            Random rand = new Random();
            //Genero los límites
            limiteMaximo = rand.Next(300, 501);
            limiteMinimo = rand.Next(101);
            //Pongo el máximo como número mínimo para que todos los números que se generen después, si son más pequeños, se guarden.
            int numeroMinimo = limiteMaximo;
            Console.WriteLine("\t   -------Números elegidos-------");
            //Bucle hasta 50 
            for (int i = 0; i < 50; i++)
            {
                numeroPresentar = rand.Next(limiteMinimo, limiteMaximo + 1);
                Console.Write("\t" + numeroPresentar);

                contador++;
                //Control de columnas para presentación
                if (contador % COLUMNAS == 0)
                {
                    Console.WriteLine();
                }
                //Si el número que se genera es mayor que el número máximo(0 al principio) se guarda como máximo.
                if (numeroPresentar > numeroMaximo)
                {
                    numeroMaximo = numeroPresentar;
                }
                //Si es más mequeño se guarda como mínimo.
                if (numeroPresentar < numeroMinimo)
                {
                    numeroMinimo = numeroPresentar;
                }
            }
            //Presento valores
            Console.WriteLine("\n\t   Número más grande: {0}", numeroMaximo);
            Console.WriteLine("\n\t   Número más pequeño: {0}", numeroMinimo);


            Console.WriteLine("\n\t   Pulse una tecla para salir.");
            Console.ReadLine();
        }
    }
}
