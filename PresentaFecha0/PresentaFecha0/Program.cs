//Alumno:Nocea,Mario.
//Enunciado en classroom

using System;
                                                                                    /*REEMPLAZAR PALABRAS CTRL+H*/

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentaFecha0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un año: ");
            int anyo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Introduzca un mes: ");
            int mes=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (mes < 1 || mes > 12) { Console.WriteLine("Error: el mes introducido es incorrecto"); }
            else { 
                Console.Write("Introduzca un dia: ");
                int dia=Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                //CONTROL DE DIAS

                     //GENERAL          //MESES DE 30 DIAS                           //FEBRERO

                if ((dia<1||dia > 31)||(dia>30&&(mes==4||mes==6||mes==9||mes==11))||(dia>28&&mes==2)) Console.Write("Dia fuera de Rango");

                //OTRA FORMA DE HACERLO CON EL ELSE IF QUE SE SUSTITUYE POR ||
                //SE PUEDE PERSONALIZAR EL MENSAJE PARA CADA ERROR.
                /*if ((dia<1||dia > 31)Console.Write("Dia fuera de Rango");
                else if (dia>30&&(mes==4||mes==6||mes==9||mes==11))Console.Write("Este mes solo tiene 30 dias");
                else if (dia>28&&mes==2)Console.Write("Febrero solo tiene 28 dias");
                */



                else
                { 
                    Console.Write("{0} de ", dia);
                    if (mes == 1) Console.Write("Enero");
                    else if (mes == 2) Console.Write("Febrero");
                    else if (mes == 3) Console.Write("Marzo");
                    else if (mes == 4) Console.Write("Abril");
                    else if (mes == 5) Console.Write("Mayo");
                    else if (mes == 6) Console.Write("Junio");
                    else if (mes == 7) Console.Write("Julio");
                    else if (mes == 8) Console.Write("Agosto");
                    else if (mes == 9) Console.Write("Septiembre");
                    else if (mes == 10) Console.Write("Octubre");
                    else if (mes == 11) Console.Write("Noviembre");
                    else if (mes == 12) Console.Write("Diciembre");
                    Console.WriteLine(" de {0}",anyo);


                    //Inicializar siempre la variable si esta dentro de un if.Para poder mostrarla más tarde.
                    //Una inicializacion siempre debe hacerse fuera de cualquier condicional por ejemplo en la declaración.


                }
            }
            Console.WriteLine("\n\n\tPulse Intro para salir");
            Console.ReadLine();
        }
        
    }
}
