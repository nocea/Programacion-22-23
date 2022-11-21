using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22a_VectorConDimensionDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamaño;
            int valor;
            string frase;
            //Capturo el tamaño.
            tamaño = CapturaEntero("Introduce el tamaño del vector: ",5,20);
            //Declaro la tabla con ese tamaño.
            int[] vEnt = new int[tamaño];
      
            for (int i = 0; i < vEnt.Length; i++)
            {   //Pido los valores de la tabla para cada uno de sus indices.
                frase = String.Format("Introduce un valor para la posicion {0} ", i);
                valor = CapturaEntero(frase, -30, 50);
                //Si el valor es 0 que se salga del bucle.
                if (valor == 0)
                {
                    break;
                }
                //Si no lo es que lo guarde en el indice.
                else
                {
                    vEnt[i] = valor;
                }
            }
            Pausa("Pulse una tecla para mostrar la tabla");
            //Muestro la tabla en una sola columna.
            for (int i = 0; i < vEnt.Length; i++)
            {
                Console.WriteLine("{0}) {1}",i,vEnt[i]);
            }
            Pausa("Pulse una tecla para salir");
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
        static void Pausa(string frase)
        {
            Console.WriteLine(frase);
            Console.ReadKey();            
            Console.Clear();
        }
    }
}
