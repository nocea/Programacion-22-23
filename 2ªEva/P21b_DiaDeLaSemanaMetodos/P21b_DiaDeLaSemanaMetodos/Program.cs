using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace P21b_DiaDeLaSemanaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MuestraDiaSemana();
            int dia = CapturaOpcion(0, 6);
            //Registramos el dia de inicio
            string nombreDiaSemana=NombreDiaSemana(dia);
            //Entra si es correcto
            Console.WriteLine("Hoy es {0}",nombreDiaSemana);
            //Capturo el numero de  dias que puedo avanzar con CapturaEntero
           
            int numDias = CapturaEntero("Introduce el numero de dias que quieres avanzar: ");
            //Guaroo el nombre final
                string nombreFinal = ProximoDiaSemana(dia, numDias);
            //Presento el resultado
                Console.WriteLine("Hoy estamos a {0} y dentro de {1} dias sera {2}",nombreDiaSemana,numDias,nombreFinal);
            
            //salgo
            Console.WriteLine("Pulse intro para salir");
            Console.ReadLine();
        }
        static void MuestraDiaSemana()
        {
            
            
                
                    Console.WriteLine("0)Domingo");
                   
                
                    Console.WriteLine("1)Lunes" );
                    
               
                    Console.WriteLine("2)Martes" );
                    
               
                    Console.WriteLine("3)Miércoles" );
                    
                
                    Console.WriteLine("4)Jueves" );
                  
                
                    Console.WriteLine("5)Viernes");
                    
                
                    Console.WriteLine("6)Sábado" );
                    
            
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

            } while (numero<min||numero>max);
            //comentario
            return numero;

        }
        static string NombreDiaSemana(int DiaSemana)
        { string dia=String.Empty;
            switch (DiaSemana)
            {
                case 0:dia = "Domingo";
                        break;
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                
            }
            return dia;
        }
        static string ProximoDiaSemana(int DiaSemana,int numDias)
        {
            string diaFinal = String.Empty;
            

            int resto = (DiaSemana + numDias) % 7;

            diaFinal=NombreDiaSemana(resto);



            return diaFinal;
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
                else if (numero<=0)
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
