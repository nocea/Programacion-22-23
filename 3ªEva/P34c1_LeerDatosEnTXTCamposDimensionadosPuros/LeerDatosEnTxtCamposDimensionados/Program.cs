/*Leer Datos En Fichero.Txt Con Campos dimensionados puros (sin salto de línea)

Si te has dado cuenta, en la práctica anterior, los datos no estaban guardados realmente 
como campos dimensionados: se les había colocado un separador de registros (el salto de línea).
Realiza un programa que lea el fichero AlumNotas_CDpuro.txt  que tienes en la carpeta Datos. 
Este archivo contiene los datos que se guardaron en la práctica de escritura de datos 
con campos dimensionados P34a (pero sin saltos de líneas):
		Dato →			id	Apellidos  Nombre  Nota1  Nota2  Nota3
		Nº Caracteres	3	   18	     12	     3	    3	   3

A partir de estos datos, rellena las tres tablas siguientes:
  ●	Una de byte tabIds
  ●	otra de string tabAlums, con los «Apellidos, Nombre» de cada alumno, 
  ●	y otra de float tabNotas de tres columnas.

A continuación presentar los datos con su cabecera y la media de cada alumno
 Importante: 
 1.	Utilizar Ruta Relativa y mantener la estructura de archivos que se te entrega. 
 2.	El archivo debe estar abierto el menor tiempo posible.
 3.	Se puede utilizar una lista auxiliar pero tienes que actuar como si no se supiera 
    el número de alumnos que guarda el fichero.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		//StreamReader sr = new StreamReader(@".\Datos\AlumNotas_CDpuro.TXT",Encoding.UTF8);
		//Abro el archivo
		StreamReader sr = File.OpenText(@".\Datos\AlumNotas_CDpuro.TXT");
		//Lo guardo en una variable para tenerlo el menor tiempo abierto.
		String fichero = sr.ReadToEnd();
		//Cierro el archivo
		sr.Close();
		List<string> listaDeRegistros = new List<string>();
		//Funcionamiento de este bucle
		/*Recorre todos los caracateres de fichero de 42 en 42(42 es el numero)				
		 * Los primeros 42 hace el substring desde 0 hasta 42 los siguientes desde 43 hasta 84 y asi
		 * Lo que hace es guardar cada substring en una posicion de la lista.
		 */
		for (int i = 0; i < fichero.Length; i+=42)
		{
			listaDeRegistros.Add(fichero.Substring(i, 42));
		}
		int tamañoLista = listaDeRegistros.Count;
		byte[] tabIds = new byte[tamañoLista];
		string[] tabAlumns = new string[tamañoLista];
		float[,] tabNotas = new float[tamañoLista, 3];
		for (int i = 0; i < listaDeRegistros.Count; i++)
		{
			//Guarda los tres primeros Caracteres
			tabIds[i] = Convert.ToByte(listaDeRegistros[i].Substring(0, 3));
			//Guarda        Desde el 3 hasta el final del apellido  coma   Desde el 21 ,12 mas y le hace le trim
			tabAlumns[i] = listaDeRegistros[i].Substring(3, 18).Trim() + "," + listaDeRegistros[i].Substring(21,12).Trim();
			tabNotas[i, 0] = Convert.ToSingle(listaDeRegistros[i].Substring(33, 3));
            tabNotas[i, 1] = Convert.ToSingle(listaDeRegistros[i].Substring(36, 3));
            tabNotas[i, 2] = Convert.ToSingle(listaDeRegistros[i].Substring(39, 3));
			//Console.Write(tabNotas[i,0]+"\t"+ tabNotas[i, 1] + "\t" + tabNotas[i, 2]+"\n");
        }
        Console.WriteLine("\n     Id  Alumno\t\t\t        Prog    Ed      BD      Media");
        Console.WriteLine("     -----------------------------------------------------------------");
		for (int i = 0; i < tamañoLista; i++)
		{			
			Console.WriteLine("\n     {0} {1} {2}    {3}    {4}    {5}", tabIds[i], CuadraTexto(tabAlumns[i], 30), tabNotas[i,0].ToString("0.00"),
				tabNotas[i, 1].ToString("0.00"), tabNotas[i,2].ToString("0.00"), Math.Round((tabNotas[i, 0]+ tabNotas[i, 1]+ tabNotas[i, 2])/3,2));
		}
        Console.WriteLine("\n\n\t Pulsa una tecla para salir");
		Console.ReadKey();
	}
	static string CuadraTexto(string texto,int tamaño)
	{
		texto += "....................................................";
		return texto.Substring(0, tamaño);
	}
}
