﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31a_GuardarDesdeTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = File.CreateText("C:\\Users\\Mario Nocea\\source\\repos\\nocea\\c-\\zDatosPrueba\\archivo.txt");
            string frase=String.Empty;
            do
            {
                Console.WriteLine("Escribe lo que quieras incluir en el fichero[fin=salir]");
                frase = Console.ReadLine();
                if (frase != "fin")
                {
                    //Escribe la frase en el archivo
                }
                else
                {
                    Console.WriteLine("Se ha escrito todo en el fichero");
                }
                
            } while (frase != "fin");
            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}