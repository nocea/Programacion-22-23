using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFloatsPrueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int tamanyo = CapturaEntero("Introduce el tamaño del vector: ", 10, 100);
            int columnas= CapturaEntero("Introduce el numero de columnas: ", 1, 7);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            MuestraVectorFloats(ConstruyeVectorFloats(tamanyo), columnas);
            
            Console.ReadLine();
        }
        static float[] ConstruyeVectorFloats(int tamanyo)
        {   
            Random random = new Random();
            float[] vFloat = new float[tamanyo];
            for (int i = 0; i < vFloat.Length; i++)               
                vFloat[i] = (float)random.Next(1000, 10000) / 100;
            return vFloat;
        }
        static void MuestraVectorFloats(float[] vFloats,int columnas)
        {
            for (int i = 0; i < vFloats.Length; i++)
            {
                if (i % columnas == 0)
                    Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("{0})",(i+1).ToString("00"));
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" "+vFloats[i].ToString("00.00"));
               
            }
        }
        static int CapturaEntero(string txt,int min,int max)
        {
            int valor;
            bool ok;
            do
            {
                Console.WriteLine("{0}:[{1}...{2}]",txt,min,max);
                ok = Int32.TryParse(Console.ReadLine(),out valor);
                if (ok)
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine("Valor fuera de rango");
                        ok = false;
                    }
                }
                else
                {
                    Console.WriteLine("Valor introducido no válido");
                }
            } while (!ok);
            return valor;
            
        }
    }
}
