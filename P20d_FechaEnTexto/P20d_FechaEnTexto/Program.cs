using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20d_FechaEnTexto
{
    internal class Program
    {
        static void Main(string[] args)
        { int mes, anyo, dia;
            Console.Write("Introduzca un año: ");
             anyo = Captura();
            Console.Clear();
            do {
                Console.Write("Introduzca un mes: ");
                 mes = Captura();
                if(mes>12||mes<=0)
                    Console.WriteLine("El mes es incorrecto");
            }while(mes>=12||mes<0);
            Console.Clear();
            do
            {
                Console.Write("Introduzca un dia: ");
                dia = Captura();
                if((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2))
                    Console.WriteLine("Dia fuera de rango");
            } while ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2));
                Console.Clear();
                
                
                
                    Console.Write("{0} de ", dia);
                    switch (mes)
                    {
                        case 1:
                            Console.Write("Enero");
                            break;
                        case 2:
                            Console.Write("Febrero");
                            break;
                        case 3:
                            Console.Write("Marzo");
                            break;
                        case 4:
                            Console.Write("Abril");
                            break;
                        case 5:
                            Console.Write("Mayo");
                            break;
                        case 6:
                            Console.Write("Junio");
                            break;
                        case 7:
                            Console.Write("Julio");
                            break;
                        case 8:
                            Console.Write("Agosto");
                            break;
                        case 9:
                            Console.Write("Septiembre");
                            break;
                        case 10:
                            Console.Write("Octubre");
                            break;
                        case 11:
                            Console.Write("Noviembre");
                            break;
                        case 12:
                            Console.Write("Diciembre");
                            break;
                    }
                    Console.WriteLine(" de {0}", anyo);
                    //Inicializar siempre la variable si esta dentro de un if.Para poder mostrarla más tarde.
                    //Una inicializacion siempre debe hacerse fuera de cualquier condicional por ejemplo en la declaración.
                
            
            Console.WriteLine("\n\n\tPulse Intro para salir");
            Console.ReadLine();
            //int dia, mes, año;
            //Console.Write("Introduzca el dia: ");
            //dia = Captura();
            //Console.Write("Introduzca el mes: ");
            //mes = Captura();
            //Console.Write("Introduzca el año: ");
            //año = Captura();
            //Console.Write( FechaEnTexto(dia, mes, año));

            //Console.WriteLine("\nPulse intro para salir");
            //Console.ReadLine();

        }
        static int Captura()
        {
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
        static string FechaEnTexto(int dia, int mes, int año) 
        {
            string fecha = dia + " del " + mes + " del " + año;
            return fecha;
        }
    }
}
