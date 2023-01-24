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
           
            //-------------- Mostramos los datos  -----------------

            Console.WriteLine("     Id  Alumno\t\t\t\tProg    Ed      BD      Media");
            Console.WriteLine("     -----------------------------------------------------------------");

        }
    }
}
