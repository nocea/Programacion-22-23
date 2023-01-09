using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheros1
{
    internal class Program
    {
        static void Main(string[] args)
        {   //En lugar de poner la doble barra se puede poner @ antes para evitar los caracteres especiales 
            //Seria:@"C:\\Users\\Mario Nocea\\Desktop\\zDatosPrueba\\texto.txt"
            StreamWriter sw = File.CreateText("C:\\Users\\Mario Nocea\\Desktop\\zDatosPrueba\\prueba.txt"); 
        }
    }
}
