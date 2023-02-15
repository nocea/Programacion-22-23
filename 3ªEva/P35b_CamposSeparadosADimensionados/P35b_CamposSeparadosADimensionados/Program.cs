using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P35b_CamposSeparadosADimensionados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(@".\Datos\PacientesPeso_CS.txt");
            StreamWriter sw = File.CreateText(@".\Datos\PacientesPeso_CD.txt");
            string[] vCampos;
            while (!sr.EndOfStream)
            {
                vCampos=sr.ReadLine().Split('$');
                sw.Write(CuadraTexto(vCampos[0],3));
                sw.WriteLine(CuadraTexto(vCampos[1], 28));

            }
            sr.Close();
            sw.Close();      
        }
        static string CuadraTexto(string texto, int numChar)
        {
            texto += "                                               ";
            return texto.Substring(0,numChar);
        }

    }
}
