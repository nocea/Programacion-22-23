    /* Leer Datos En Fichero.Txt Con Separadores de Campos: 
Realiza un programa que lea el fichero AlumNotas.txt que tienes en la carpeta Datos. 
Se sabe que cada fila contiene los campos: id, nombre, nota1, nota2 y nota3 separados por ‘;’. 
A partir de estas filas obtenidas, rellena una tabla de byte tabIds, otra de string tabAlums 
y otra de float tabNotas de tres columnas. 
A continuación presentar los datos con su cabecera
 Importante: 
 1.	Utilizar Ruta Relativa y mantener la estructura de archivos que se te entrega. 
 2.	El archivo debe estar abierto el menor tiempo posible.
 3.	Se puede utilizar una lista auxiliar pero tienes que actuar como si no se supiera 
    el número de alumnos que guarda el fichero.
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
            List<string> listaAux = new List<string>(); 
            //Mientras haya filas se guardan las filas en la lista.
            while (!sr.EndOfStream)
            {
               listaAux.Add(sr.ReadLine());
            }
            sr.Close();
            string[] vector;
            byte[] tabIds = new byte[listaAux.Count];
            string[] tabAlums=new string[listaAux.Count];
            float[,]tabNotas= new float[listaAux.Count, 3];
            //Guardar los datos en las tablas correspondientes
            for (int i = 0; i < listaAux.Count; i++)
            {
                vector=listaAux[i].Split(';');
                tabIds[i] = Convert.ToByte(vector[0]);
                tabAlums[i] = vector[1];
                tabNotas[i, 0] = float.Parse(vector[2]);
                tabNotas[i,1]=float.Parse(vector[3]);
                tabNotas[i,2]=float.Parse(vector[4]);
            }
            //Mostrar datos
            //for (int i = 0; i < listaAux.Count; i++)
            //{
            //    Console.WriteLine(listaAux[i]);
            //}
            //-------------- Mostramos los datos  -----------------
            double media;
            Console.WriteLine("     Id  Alumno\t\t\t\tProg    Ed      BD      Media");
            Console.WriteLine("     -----------------------------------------------------------------");
            for (int i = 0; i < listaAux.Count; i++)
            {
                media = Math.Round((tabNotas[i, 0] + tabNotas[i, 1] + tabNotas[i, 2]) / 3,1);
                Console.WriteLine("     {0} {1} {2}{3}{4}{5}", tabIds[i],CuadraTexto(tabAlums[i],30), CuadraTexto(tabNotas[i,0],8), CuadraTexto(tabNotas[i, 1],8), CuadraTexto(tabNotas[i, 2],8), media);
            }
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
