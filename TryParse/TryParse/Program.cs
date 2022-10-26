using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, min = -50, max = 50;
            bool ok;
            do
            {
                Console.WriteLine("Introduce un numero entre {0} y {1}: ",min,max);
                //intenta convertirlo
                //Si lo consigue guarda el valor en el out y guarda true en la variable ok.
                //si no puede devuelve false y guarda un cero en la variable

                //TODO ESTO CONTROLA EL ERROR DE FORMATO
                ok = Int32.TryParse(Console.ReadLine(),out num);
                if(!ok)//Es lo mismo que if(ok==false)
                    Console.WriteLine("Error de formato");
                //TODO ESTO CONTROLA EL ERROR DE RANGO Y PONEMOS OK FALSO PARA FACILITAR EL WHILE
                //ES DECIR SI ENTRA AQUI PONEMOS QUE OK SEA FALSO Y NO SE SALGA DEL BUCLE.
                else if(num<min||num>max)
                {
                    Console.WriteLine("Numero Fuera de rango");
                    ok = false;
                }
                    
                    
            } while (!ok);//El controlar aqui !ok es para si da false que siga preguntando,no hace falta capturar 
            Console.WriteLine("Numero correcto: {0}",num);
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
    }
}
