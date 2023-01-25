using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22o_Tabla2DGente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vApellidos = {"Sánchez Elegante", "Arenas Mata", "García Solís","Rodríguez Vázquez","Hurtado Miranda", "Pinto Mirinda", "Barrios Garrobo", "Márquez Salazar", "Medina Gómez", "Alonso Pérez",
                                  "López Mora", "González Chaparro", "Ferrer Jiménez", "Morales Moncayo", "Fernández Perea", "Blanco Roldán", "Navarro Romero", "Aguilar Rubio", "Baena Fernández", "Barco Ramírez", "Delgado Rodríguez", "Duque Martínez" };
            string[] vNombres = {"Álvaro", "Daniel Luis", "Juan Manuel", "Agustín", "Fco. Javier", "José Manuel", 
                                "Tomás", "Carlos", "Jose Carlos", "Juan Luis", "Daniel", "Angel", "Jacobo", "Alejandro", "Francisco", "Alfredo", "Francisco", "Antonio", "Constantino", "Roberto", "Rafael", "Antonio" };

            string[,] tabla2dGente =new string [vNombres.Length, 2];
            for (int i = 0; i < vNombres.Length; i++)
            {
                tabla2dGente[i, 0] = vNombres[i];
                tabla2dGente[i, 1] = vApellidos[i];
            }
            for (int i = 0; i < vNombres.Length; i++)
            {               //Presentar los numeros con un cero delante
                    Console.WriteLine("{0}) {1},{2}", (i + 1).ToString("00"), tabla2dGente[i, 0], tabla2dGente[i, 1]);
            }
            Pausa("el siguiente paso");
            string[]vApellNomb=new string[vNombres.Length];
            
            for (int i = 0; i < vApellNomb.Length; i++)
            { 
                vApellNomb[i] = String.Format("{0}, {1}", tabla2dGente[i, 1], tabla2dGente[i, 0]);
                Console.WriteLine("{0}) {1}", (i + 1).ToString("00"), vApellNomb[i]);
            }
            Pausa("Mostrar el nombre y apellido mas largo");
            string masLargo=String.Empty;
            for (int i = 0; i < vApellNomb.Length; i++)
            {
                if (vApellNomb[i].Length > masLargo.Length)
                {
                    masLargo= vApellNomb[i];
                }
            }
            Console.WriteLine(masLargo);
            Pausa("salir");
        }
        static void Pausa(string texto)
        {
            Console.WriteLine("\nPulse una tecla para " + texto);
            Console.ReadKey(true);
        }
    }
}
