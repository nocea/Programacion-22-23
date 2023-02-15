using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace P35b_DeDimensionadosASeparados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr =File.OpenText(@".\Datos\AlumNotas_CD.TXT");
            StreamWriter sw =File.CreateText(@".\Datos\AlumNotas_CS.TXT");
            string linea;
            while (!sr.EndOfStream)
            {
                linea=sr.ReadLine();
                sw.Write(linea.Substring(0,3)+";");
                sw.Write(linea.Substring(3,26).Trim()+";");
                sw.Write(linea.Substring(29,3).Trim()+";");
                sw.Write(linea.Substring(32,3).Trim()+";");
                sw.WriteLine(linea.Substring(35).Trim()+";");

            }
            sr.Close();
            sw.Close();
            sr =File.OpenText(@".\Datos\AlumNotas_CS.TXT");
            string [] vCampos;
             Console.WriteLine("     Id  Alumno\t\t\t\tProg    Ed      BD ");
		    Console.WriteLine("-----------------------------------------------------------------");
            while (!sr.EndOfStream)
            {
                vCampos=sr.ReadLine().Split(';');
                Console.WriteLine("     {0} {1} {2}\t{3}\t{4}", vCampos[0], CuadraTexto(vCampos[1], 30), vCampos[2], vCampos[3], vCampos[4]);
            }
            
            
            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadKey();
        }
        static string CuadraTexto(string texto, int numCaracteres)
	{
		texto += "                                  ";
		return texto.Substring(0, numCaracteres);
	}
    }
}
