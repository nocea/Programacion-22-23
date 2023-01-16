using System;
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
            StreamWriter sw = File.CreateText("C:\\zDatosPrueba\\archivo.txt");
            string frase=String.Empty;
            Console.Write("Escribe lo que quieras incluir en el fichero[fin=salir]: ");
            int i=1;
            do
            {
                Console.Write("\nFrase "+i+": ");
                frase = Console.ReadLine();
                if (frase != "fin")
                {
                    //Escribe la frase en el archivo
                    sw.Write(frase+" ");
                }   
                else
                {
                    Console.WriteLine("Se ha escrito todo en el fichero");
                }
                i++;
                
            } while (frase != "fin");
            //Hay que cerrarlo para que se escriba todo.    
            sw.Close();
            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}
