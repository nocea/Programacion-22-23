using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P36_Peliculas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(@"./Datos/pelis.TXT");
            List<string> list = new List<string>();
            while (!sr.EndOfStream)
            {
                list.Add(sr.ReadLine().Substring(22));
            }
            sr.Close();
            Console.WriteLine("Nº     Película                               Valor    Form.    Tamaño");
            Console.WriteLine("---    --------------------------------       -----    -----    -------");
            string nombrePeli, valor, formato,nombreFichero;
            double tamaño;
            string[] tablaSplit;
            for (int i = 0; i < list.Count; i++)
            {
                tamaño =Math.Round((Convert.ToDouble(list[i].Substring(0, 13).Trim()) / 1000000000),2);
                
                nombreFichero = list[i].Substring(14).Trim();
                //en el split añado los caracteres que no quiero que se añadan y por tanto son delimitadores
                tablaSplit = nombreFichero.Split('(',')');
                nombrePeli= tablaSplit[0].Trim();
                valor = tablaSplit[1].Trim();
                formato = tablaSplit[2].ToUpper().Trim().Remove(0,1);
                
                Console.WriteLine("{0}    {1}   {2}       {3}     {4}",i.ToString("000"),CuadraTexto(nombrePeli,37),CuadraTextoEspacio(valor,2),formato,tamaño);
            }
            Console.Write("¿Nombre del fichero donde guardar los datos?: ");
            string nombre=Console.ReadLine();
            if (nombre != String.Empty)
            {
                StreamWriter sw = File.CreateText(@"./Datos/" + nombre + ".TXT");
                for (int i = 0; i < list.Count; i++)
                {
                    tamaño = Math.Round((Convert.ToDouble(list[i].Substring(0, 13).Trim()) / 1000000000), 2);

                    nombreFichero = list[i].Substring(14).Trim();
                    //en el split añado los caracteres que no quiero que se añadan y por tanto son delimitadores
                    tablaSplit = nombreFichero.Split('(', ')');
                    nombrePeli = tablaSplit[0].Trim();
                    valor = tablaSplit[1].Trim();
                    formato = tablaSplit[2].ToUpper().Trim().Remove(0, 1);
                    sw.WriteLine("{0};{1};{2};{3}",nombrePeli,valor,formato,tamaño);
                }
                sw.Close();
            }


            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadKey();
        }
        static string CuadraTexto(string texto, int tamaño)
        {
            texto += ".................................................";
            return texto.Substring(0,tamaño);
        }
        static string CuadraTextoEspacio(string texto,int tamaño)
        {
            texto += "                                    ";
            return texto.Substring(0, tamaño);
        }
        

    }
}
