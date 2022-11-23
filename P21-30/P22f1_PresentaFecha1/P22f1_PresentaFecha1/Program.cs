
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P22f1_PresentaFecha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            CapturaFechaString();
            Console.WriteLine("Pulse para el siguinte metodo");
            Console.ReadKey();
            año = CapturaEntero("Introduce un año");
            do
            {
                mes = CapturaEntero("Introduce un mes");
                if (mes < 1 || mes > 12)
                {
                    Console.WriteLine("Error el mes debe ser correcto");
                }
            } while (mes < 1 || mes > 12);
            do
            {
                dia = CapturaEntero("Introduce un dia");
                if ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2))
                    Console.WriteLine("Dia fuera de rango");
            } while ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2));
            
            FechaString(dia, mes, año);
            Console.ReadKey();


        }
        static void CapturaFechaString()
        {
            string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int dia, mes, año;
            año = CapturaEntero("Introduce un año");
            do
            {
                mes = CapturaEntero("Introduce un mes");
                if (mes < 1 || mes > 12)
                {
                    Console.WriteLine("Error el mes debe ser correcto");
                }
            } while (mes < 1 || mes > 12);
            do
            {
                dia = CapturaEntero("Introduce un dia");
                if ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2))
                    Console.WriteLine("Dia fuera de rango");
            } while ((dia < 1 || dia > 31) || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia > 28 && mes == 2));
            Console.WriteLine("{0} de {1} de {2}", dia, meses[mes - 1], año);
            
        }
        static void FechaString(int año,int mes,int dia)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Console.WriteLine("{0} de {1} de {2}", dia, meses[mes - 1], año);
        }
        static int CapturaEntero(string txt)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0}: ", txt);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                Console.Clear();
                if (!ok)
                    Console.WriteLine("**Error de Formato**");
            } while (!ok);
            //comentario
            return numero;
        }
    }
}
