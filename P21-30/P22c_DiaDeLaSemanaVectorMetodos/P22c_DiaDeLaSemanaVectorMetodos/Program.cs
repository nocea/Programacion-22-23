using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22c_DiaDeLaSemanaVectorMetodos
{
    internal class Program
    {
        static string[] diaSemana = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
        static void Main(string[] args)
        {
            
            MuestraDiaSemana();
            int dia = CapturaOpcion(0, 6);
            //Registramos el dia de inicio
            string nombreDiaSemana = NombreDiaSemana(dia);
            //Entra si es correcto
            Console.WriteLine("Hoy es {0}", nombreDiaSemana);
            //Capturo el numero de  dias que puedo avanzar con CapturaEntero

            int numDias = CapturaEntero("Introduce el numero de dias que quieres avanzar: ");
            //Guardo el nombre final
            string nombreFinal = ProximoDiaSemana(dia, numDias);

            //Presento el resultado
            Console.WriteLine("Hoy estamos a {0} y dentro de {1} dias sera {2}", nombreDiaSemana, numDias, nombreFinal);

            //salgo
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
        static void MuestraDiaSemana()
        {
            for (int i = 0; i < diaSemana.Length; i++)
            {
                Console.WriteLine("{0}) {1}", i, diaSemana[i]) ;
            }
        }
        static int CapturaOpcion(int min, int max)
        {

            int numero;

            do
            {
                Console.Write("Introduzca su opcion: ");
                numero = Console.ReadKey().KeyChar - '0';
                Console.Clear();
                if (numero < min || numero > max)
                {
                    Console.WriteLine("**Error:Valor fuera de rango**");
                }

            } while (numero < min || numero > max);
            //comentario
            return numero;

        }
        static string NombreDiaSemana(int DiaSemana)
        {
            return diaSemana[DiaSemana];
             
        }
        static string ProximoDiaSemana(int DiaSemana, int numDias)
        { 

             
            return diaSemana[(DiaSemana + numDias) % 7];
        }
        static int CapturaEntero(string txt)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0}", txt);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                Console.Clear();
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
                else if (numero <= 0)
                {
                    Console.WriteLine("**Error:Tienes que avanzar mas de 0 dias**");
                    ok = false;
                }
            } while (!ok);
            //comentario
            return numero;
        }
    }
}
