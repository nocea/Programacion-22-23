/* Se trata de repetir la práctica del mismo nombre, pero sin guardar los datos en
listas ni tablas: simplemente leer y presentar. El único vector que se permite es el
de los campos. Por tanto, el enunciado sería:
Realiza un programa que lea el fichero AlumNotas.txt que tienes en la carpeta
Datos dentro del directorio de trabajo. Cada registro se separa del siguiente
mediante salto de línea y contiene los campos id, nombre, nota1, nota2 y nota3
separados por ';':
Importante: 
1. Utiliza Ruta Relativa y mantener la estructura de archivos que se te indica.
2. El archivo debe estar abierto el menor tiempo posible.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LeerDatosEnTxtSeparadoresCampos
{
    class Program
    {
        static void Main(string[] args)
        {


            StreamReader sr = File.OpenText(@".\Datos\AlumNotas.TXT");
            //Creo una lista auxiliar para guardar las filas de el archivo

            //Mientras haya filas se guardan las filas en la lista.
            string[] vectorCampos;
            float media;
            
            Console.WriteLine("     Id  Alumno\t\t\t\tProg    Ed      BD      Media");
            Console.WriteLine("     -----------------------------------------------------------------");
            while (!sr.EndOfStream)
            {
                
                vectorCampos=sr.ReadLine().Split(';');
                media=(float.Parse(vectorCampos[2])+ float.Parse(vectorCampos[3])+ float.Parse(vectorCampos[4]))/3;
                Console.WriteLine("     {0} {1} {2}{3}{4}{5}", vectorCampos[0], CuadraTexto(vectorCampos[1],30), CuadraTexto(float.Parse(vectorCampos[2]),8), CuadraTexto(float.Parse(vectorCampos[3]),8), CuadraTexto(float.Parse(vectorCampos[4]), 8), media);
                
            }
            sr.Close();
            Console.WriteLine("\nPulsa cualquier tecla para salir");
            Console.ReadKey();

        }
        static string CuadraTexto(string texto,int numeroCaracteres)
        {
            //Añado caracteres al texto (suficientes para que no me quede corto si el texto es pequeño)
            texto+= "...............";
            //El substring pilla desde el primer caracter hasta el que se le indica como maximo por eso la cadena de 
            //texto debe ser mayor al maximo del substring.
            return texto.Substring(0, numeroCaracteres);
        }
        static string CuadraTexto(float nota, int numeroCaracteres)
        {
            //combierto la tabla nota de float a string
            string notaString = nota.ToString();
            //Hago lo mismo que en el metodo anterior
            notaString+= "                   ";
            return notaString.Substring(0, numeroCaracteres);
        }
    }
}
