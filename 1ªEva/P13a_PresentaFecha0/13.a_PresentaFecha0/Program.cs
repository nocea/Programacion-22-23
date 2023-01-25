using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.a_PresentaFecha0
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.Write("Introduzca un año: ");
            int anyo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Introduzca un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (mes < 1 || mes > 12) { Console.WriteLine("Error: el mes introducido es incorrecto"); }
            else
            {
                Console.Write("Introduzca un dia: ");
                int dia = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                //CONTROL DE DIAS

                //GENERAL          //MESES DE 30 DIAS                           //FEBRERO

                if ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2)) Console.Write("Dia fuera de Rango");
                //OTRA FORMA DE HACERLO CON EL ELSE IF QUE SE SUSTITUYE POR ||
                //SE PUEDE PERSONALIZAR EL MENSAJE PARA CADA ERROR.
                /*if ((dia<1||dia > 31)Console.Write("Dia fuera de Rango");
                else if (dia>30&&(mes==4||mes==6||mes==9||mes==11))Console.Write("Este mes solo tiene 30 dias");
                else if (dia>28&&mes==2)Console.Write("Febrero solo tiene 28 dias");
                */
                else
                {
                    Console.Write("{0} de ", dia);
                    switch (mes)
                    {
                        case 1: Console.Write("Enero");
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
                }
            }
            Console.WriteLine("\n\n\tPulse Intro para salir");
            Console.ReadLine();
        }
    }
}
