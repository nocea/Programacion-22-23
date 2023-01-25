using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22p1_TablaDoubles
{
    internal class Program
    {
        const int FILASTABLA = 9;
        const int COLUMNASTABLA = 7;
        static void Main(string[] args)
        {
            // En esta versión DECLARAMOS la tabla LOCAL y se construye desde CargaTabla
            double[,] tDoubles2D = CargaTabla(FILASTABLA, COLUMNASTABLA);
            MostrarValores(tDoubles2D);


            Console.Write("\n\n\t\tPulsa una tecla para salir");
            Console.ReadKey();
        }

        private static double[,] CargaTabla(int filas, int columnas)
        {
            // Construimos una tabla de doubles con las dimensiones recibidas
            double[,] tDoubles = new double[filas, columnas];
            Random azar = new Random();
            for (int f = 0; f < filas; f++) // <-- Recorremos las filas
                for (int c = 0; c < columnas; c++) // <-- Recorremos las columnas
                    tDoubles[f, c] = 0.1 * azar.Next(100, 1000); // <-- guardamos en esa posición el valor aleatorio

            // devolvemos la tabla
            return tDoubles;
        }


        private static void MostrarValores(double[,] tDoubles)
        {
            // Pontamos en verde las cabeceras de las filas y las columnas
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n  ");
            // cabecera de las columnas
            for (int i = 0; i < tDoubles.GetLength(1); i++)
                Console.Write("      c{0}", i);//6 IZQUIERDA NADA DERECHA
            Console.WriteLine("\n");
            // cabecera de las filas
            for (int i = 0; i < tDoubles.GetLength(0); i++)
                Console.WriteLine(" f{0}->\n", i);
            Console.ResetColor();

            for (int f = 0; f < tDoubles.GetLength(0); f++)     // <-- Recorremos las filas
                for (int c = 0; c < tDoubles.GetLength(1); c++) // <-- Recorremos las columnas
                    ColocaValor(f, c, tDoubles[f, c]);  // <-- Llamamos a ColocaValor enviándole el valor a mostrar
        }

        private static void ColocaValor(int fTabla, int cTabla, double valor)
        {
            int filaPantalla, columnaPantalla; // <-- fila y columna de la pantalla
            columnaPantalla = 7 + 8 * cTabla;// columna de la pantalla en función de la columna de la tabla 
            filaPantalla = 4 + 2 * fTabla;   // fila de la pantalla en función de la fila de la tabla
            Console.SetCursorPosition(columnaPantalla, filaPantalla); // <-- Coloco el cursor en la posición calculada...
            Console.Write(valor.ToString("00.00"));                // <-- ...Escribimos el valor en dicha posición
        }




    }
}
