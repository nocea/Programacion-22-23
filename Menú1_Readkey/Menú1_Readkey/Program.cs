using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menú1_Readkey
{
    internal class Program
    {
        const double PI = 3.14159;
        static void Main(string[] args)
        {
            //Comentario git
            int opcion;
            Console.WriteLine("\n\n\n\n\t\t\t\t   Mario Nocea");
            Console.WriteLine("\t\t\t╔════════════════════════════════════╗");
            Console.WriteLine("\t\t\t║             MENU                   ║");
            Console.WriteLine("\t\t\t╠════════════════════════════════════╣");
            Console.WriteLine("\t\t\t║                                    ║");
            Console.WriteLine("\t\t\t║    1.Perímetro y Área del Círculo  ║");
            Console.WriteLine("\t\t\t║    2. Desglosa Euros               ║");
            Console.WriteLine("\t\t\t║    3. Presenta Fecha               ║");
            Console.WriteLine("\t\t\t║    4. Presenta Día Semana          ║");
            Console.WriteLine("\t\t\t║                                    ║");
            Console.WriteLine("\t\t\t║            0) Salir                ║");
            Console.WriteLine("\t\t\t║                                    ║");
            Console.WriteLine("\t\t\t╚════════════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");
            opcion = Console.ReadKey().KeyChar - '0';//Para capturar un caracter y no tener que pulsar intro

            Console.Clear();
            if (opcion > 0 || opcion <= 4)
                Console.Write("\t\tHa elegido la opción nº ");

            switch (opcion)
            {

                case 0:Console.WriteLine("Ha elegido salir");
                    
                    break;
                case 1:
                    Console.WriteLine("1: “Perímetro y Área del Círculo”");
                    int radio;
                    double perimetro, area;

                    Console.Write("\n\tHola, introduce el radio de la circunferencia: ");
                    radio = Convert.ToInt32(Console.ReadLine());
                    perimetro = 2 * PI * radio;
                    area = PI * radio * radio;
                    Console.Write("\n\tLa longitud de la circunferencia es: {0}", perimetro);
                    Console.WriteLine("\n\tEl área de la circunferencia es: {0}", area);
                    break;
                case 2:
                    Console.WriteLine("2: “Desglosa Euros”");
                    int dinero, b20, b5, m1, resto;//me ahorro la variable resto aunque despues en la solucion no se podra poner la primera cantidad introducida.
                                                   //Se crea una variable para introdu
                                                   //cir el dinero que se ira actualizando.
                                                   //y las variables para guardar la cantidad de billetes y de monedas.

                    Console.Write("\n\tIntroduce una cantidad de dinero: ");
                    dinero = Convert.ToInt32(Console.ReadLine());
                    //Para saber los billetes de 20 que tengo los divido entre 20.
                    b20 = dinero / 20;
                    //El dinero que me queda lo se al obtener el resto del dinero entre los billetes de 20.
                    resto = dinero % 20;
                    //Para saber los billetes de 5 divido el resto que he obtenido antes entre 5.
                    b5 = resto / 5;
                    //El resto que me queda de los billetes de 5 son las monedas de 1 euro.
                    m1 = resto % 5;
                    //Control si ha billetes de 20,billetes de 5 o monedas de 1.
                    if (dinero == 0) Console.WriteLine("NO ha introducido dinero");

                    else
                    {
                        Console.Write("\n\tLa cantidad desglosada es de : ");
                        if (b20 > 0)
                        {

                            if (b20 > 1) Console.Write("{0} billetes de 20 euros", b20);/*Aqui se controla que haya mas de un billete de 20*/
                            else Console.Write("{0} billete de 20 euros", b20);
                            //comprobamos que hay después
                            if (m1 > 0 && b5 > 0) Console.Write(",");/*SI hay monedas de 1 y billetes de 5 se pone coma*/
                            else if (m1 > 0 || b5 > 0) Console.Write(" y ");/*Si hay monedas de uno O billetes de cinco*/
                            else Console.Write(".");

                        }
                        if (b5 > 0)
                        {
                            if (b5 > 1) Console.Write("{0} billetes de 5 euros", b5);/*Aqui se controla que haya mas de un billete de 5*/
                            else Console.Write("{0} billete de 5 euros", b5);
                            if (m1 > 0) Console.Write(" y ");
                            else Console.Write(".");

                        }
                        if (m1 > 0)
                        {
                            if (m1 > 1) Console.Write("{0} monedas de 1 euro.", m1);/*Aqui se controla que haya mas de una moneda de 1 euro*/
                            else Console.Write("una moneda de un euro.");

                        }
                    }
                    break;
                case 3:
                    
                    Console.WriteLine("3: “Presenta Fecha”");
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


                        if ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2)) Console.Write("Dia fuera de Rango");


                        else
                        {
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
                        }
                    }
                        break;
                    
                case 4:
                    Console.WriteLine("4: “Presenta Día Semana”");
                    Console.WriteLine("Introduce un dia del 0 al 6 siendo 0 el domingo y 6 el sabado: ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    if (dia < 0 || dia > 6) Console.WriteLine("ERROR:El dia esta fuera de rango.");
                    else
                    {
                        Console.WriteLine("Introduce el numero de dias que quieres avanzar: ");
                        int numDias = Convert.ToInt32(Console.ReadLine());
                        if (numDias < 0) Console.WriteLine("Debe introducir un numero mayor que 0.");

                        int resto = (dia + numDias) % 7;
                        //El else if significa que si es esa opcion que ejecute esa y ya no lea mas el if if if if hace que lea todas las opciones.
                        else
                        {

                            int resto = (dia + numDias) % 7;
                            switch (resto)
                            {
                                case 0:
                                    Console.WriteLine("Dentro de {0} dia/s será Domingo", numDias);
                                    break;
                                case 1:
                                    Console.WriteLine("Dentro de {0} dia/s será Lunes", numDias);
                                    break;
                                case 2:
                                    Console.WriteLine("Dentro de {0} dia/s será Martes", numDias);
                                    break;
                                case 3:
                                    Console.WriteLine("Dentro de {0} dia/s será Miércoles", numDias);
                                    break;
                                case 4:
                                    Console.WriteLine("Dentro de {0} dia/s será Jueves", numDias);
                                    break;
                                case 5:
                                    Console.WriteLine("Dentro de {0} dia/s será Viernes", numDias);
                                    break;
                                case 6:
                                    Console.WriteLine("Dentro de {0} dia/s será Sábado", numDias);
                                    break;
                            }
                        }
                    }
                        break;
                default:
                    Console.WriteLine("\t\t*-ERROR:HA ELEGIDO UNA OPCIÓN NO VÁLIDA-*");
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("\t\tPulsa intro para salir");
            Console.ReadLine();
        }
    }
}
