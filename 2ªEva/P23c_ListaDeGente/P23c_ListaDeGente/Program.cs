using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P23c_ListaDeGente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posi1, posi2;
            string[] vApellidos = { "Sánchez Elegante", "Arenas Mata", "García Solís",
                "Rodríguez Vázquez", "Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo",
                "Márquez Salazar", "Medina Gómez", "Alonso Pérez", "López Mora", "González Chaparro",
                "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero",
                "Aguilar Rubio", "Baena Fernández", "Barco Ramírez", "Delgado Rodríguez", "Duque Martínez" };
            string[] vNombres = {"Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel",
                 "Tomás", "Carlos", "Jose Carlos", "Juan Luis", "Daniel", "Angel", "Jacobo", "Alejandro",
                 "Francisco", "Alfredo", "Francisco", "Antonio", "Constantino", "Roberto", "Rafael", "Antonio"};
            List<string> listaNombres = DevuelveListaGente(vApellidos, vNombres);
            
            MuestraColeccion(listaNombres, 0);
            Pausa("siguiente paso",25);
            posi1=CapturaEntero("Introduce la primera posición a intercambiar", 0, vNombres.Length);
            posi2= CapturaEntero("Introduce la segunda posición a intercambiar", 0, vNombres.Length);
            IntercambiaPos(listaNombres, posi1, posi2);
            
            MuestraColeccion(listaNombres, 40);

            Pausa("para salir del programa",30);



        }
        static int CapturaEntero(string txt, int min, int max)
        {
            int numero;
            bool ok;
            do
            {
                Console.Write("{0} [{1}...{2}]: ", txt, min, max);
                ok = Int32.TryParse(Console.ReadLine(), out numero);
                
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
        static List<string> DevuelveListaGente(string[] apellidos, string[] nombres)
        {
            List<string> listaCompleta = new List<string>();
            for (int i = 0; i < nombres.Length; i++)
            {
                listaCompleta.Add(nombres[i] + "," + apellidos[i]);
            }
            return listaCompleta;
        }
        static void MuestraColeccion(List<string> lista, int colum)
        {
            Console.SetCursorPosition(colum, 0);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.SetCursorPosition(colum, i);
                Console.Write("{0}) {1}", i, lista[i]);
                Console.WriteLine();

            }
            Console.SetCursorPosition(colum, lista.Count + 1);
        }
        static void IntercambiaPos(List<string> list, int pos1, int pos2)
        {
             string temp = list[pos1];
            list[pos1] = list[pos2];
            list[pos2] = temp;
        }
        static bool BorraElemento(List<string> lista, string persona)
        {
            bool verdaderoFalso = true;
            for (int i = 0; i < lista.Count; i++)
            {
                if (persona == lista[i])
                {
                    lista.RemoveAt(i);
                    verdaderoFalso = true;
                }
                else
                    verdaderoFalso = false;
            }
            return verdaderoFalso;
        }
        static void Pausa(string txt,int fila)
        {
            Console.SetCursorPosition(0, fila);
            Console.WriteLine("Pulse una tecla para {0}", txt);
            Console.ReadKey();
        }
    }
}
