using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22g_VectorFloats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamaño,columnas;
            tamaño=CapturaEntero("Introduce el tamaño del vetor: ",10,100);
            columnas= CapturaEntero("Introduce el numero de columnas: ", 1, 7);
            MuestraVectorFloats(ConstruyeVectorFloat(tamaño), 7);
            Pausa("para salir");
        }
        static float[] ConstruyeVectorFloat(int tamanyo)
        {
            float[]vFloats = new float[tamanyo];
            float numero;
            
            Random r = new Random();
            for (int i = 0; i < vFloats.Length; i++)
            {
                numero = ((float)r.Next(1000, 10000))/100;              
                vFloats[i] = numero;
                
            }
            
            return vFloats;
        }
        static void MuestraVectorFloats(float[]vFloats,int columnas)
        {
            for (int i = 0; i < vFloats.Length; i++)
            {
                if (i%columnas==0)
                {
                    Console.WriteLine();
                }
                Console.Write(i.ToString("00")+") "+vFloats[i].ToString("00.00")+" ");
            }
        }
        static void Pausa(string texto)
        {
            Console.WriteLine("\nPulse para "+texto);
            Console.ReadKey();
        }

             static int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                Console.Clear();
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
                else if (numero < min || numero > max)
                {
                    Console.WriteLine("**Error:Numero fuera de rango**");
                    ok = false;
                }
            } while (!ok);
            //comentario
            return numero;
        }
    }
}
