using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class Program
{
	static void Main(string[] args)
	{
		// Construyo una lista donde guardar las líneas del fichero (registros)
		List<string> listaReg = new List<string>();
		List<string> listaOrdenada;

		// el StreamReader para leer los datos
		StreamReader sr = new StreamReader(@".\Datos\Pacientes.txt", Encoding.Default);
		
		//Para mostrar antes de la cabecera cómo se están mostrando los datos
		string[] nombreCamposOrdenacion = { " ", "por orden de id", "por orden de Apellidos, Nombre", "por orden de Edad", "por orden de altura", "por orden de peso", "Sin ordenar" };



		// Leemos todas las líneas del fichero y las guardamos en la listas
		string registro;
		string[] vCampos; // <-- tabla donde guardaremos los campos de cada registro
						  // colocamos el campo de ordenación delante del registro

		while (!sr.EndOfStream)
			listaReg.Add(sr.ReadLine());
		// ya hemnos leído todas las líneas, por lo tanto cierro el stream
		sr.Close();

		int opcion = Menu();

		while (opcion != 0)
		{
			listaOrdenada = new List<string>(listaReg);
			//Añade delante de cada registro el campo por el que quiere ordenar y lo separa ocn punto y coma.
			for (int i = 0; i < listaOrdenada.Count; i++)
			{
				registro = listaOrdenada[i]; // sólo lo hago así para que tengas en cuenta que cada elemento es un registro

				vCampos = registro.Split(';');
				switch (opcion)
				{
					case 1: // Por id
						registro = CuadraTexto(4, vCampos[0]) + ';' + registro;
						break;
					case 2: // Por Apellidos, Nombre
						registro = vCampos[1] + ';' + registro;
						break;
					case 3: // Por Edad
						registro = vCampos[3] + ';' + registro;
						break;
					case 4: // Por Estatura
						registro = vCampos[4] + ';' + registro;
						break;
					case 5: // Por Peso
						registro = CuadraNumero(Convert.ToDouble(vCampos[5]), 6) + ';' + registro;
						break;
					case 6: // sin ordenar
						registro = " " + ';' + registro;
						break;
				}
				listaOrdenada[i] = registro;
			}

			//Ordenamos la Lista
			listaOrdenada.Sort();
			// Si se ordena por la edad, de menor a mayor, 
			// hay que invertir la el orden porque la fecha debe estar de mayor a menor
			if (opcion == 3)
				listaOrdenada.Reverse();

			Console.WriteLine("    ------ Pacientes de la consulta {0} ------", nombreCamposOrdenacion[opcion]);

			// Cabecera
			Console.WriteLine("\n  Id  Paciente                     Movil      Fecha Nac.  Alt.  Peso");
			Console.WriteLine("  --- ---------------------------- ---------  ----------  ---- -----");

			double peso, sumaPeso = 0;
			int cont = 0;
			string fechaSP;
			// necesitamos el vector de campos

			for (int i = 0; i < listaOrdenada.Count; i++)
			{
				vCampos = listaOrdenada[i].Split(';');
				Console.WriteLine("{1}{2}{3}{4}{5}{6}",vCampos[1],vCampos[2],vCampos[3],vCampos[4],vCampos[5],vCampos[6]);
			}

			Console.Write("\n\n\t*** El peso medio de todos los pacientes es {0} kg ***", (sumaPeso / cont).ToString("0.0"));
			Console.WriteLine("\n\n\t Pulsa una tecla para volver al menú");
			Console.ReadKey();
			opcion = Menu();
		}
		Console.WriteLine("\n\n\t Pulsa una tecla para salir");
		Console.ReadKey();
	}


	static int Menu()
	{
		int opcion = 0;
		Console.Clear();
		Console.WriteLine("\n\n\t\t╔═════════════════════════╗");
		Console.WriteLine("\t\t║   Ordenar datos por...  ║");
		Console.WriteLine("\t\t╠═════════════════════════╣");
		Console.WriteLine("\t\t║   1) id                 ║");
		Console.WriteLine("\t\t║                         ║");
		Console.WriteLine("\t\t║   2) Apellidos, Nombre  ║");
		Console.WriteLine("\t\t║                         ║");
		Console.WriteLine("\t\t║   3) Edad (creciente)   ║");
		Console.WriteLine("\t\t║                         ║");
		Console.WriteLine("\t\t║   4) Altura             ║");
		Console.WriteLine("\t\t║                         ║");
		Console.WriteLine("\t\t║   5) Peso               ║");
		Console.WriteLine("\t\t║                         ║");
		Console.WriteLine("\t\t║   6) Sin ordenar        ║");
		Console.WriteLine("\t\t║_________________________║");
		Console.WriteLine("\t\t║                         ║");
		Console.WriteLine("\t\t║      0)  Salir          ║");
		Console.WriteLine("\t\t╚═════════════════════════╝");

		//		Console.WriteLine("\t\t║   7) Nombre Apellidos   ║");


		Console.Write("\t\tIntroduce una opción: ");
		// guardamos el valor numérico de la tecla pulsada
		opcion = Console.ReadKey().KeyChar - '0';
		// Comprobamos que se ha pulsado una opción correcta
		while (opcion < 0 || opcion > 6)
		{
			Console.WriteLine("\n\t\t\t*ERROR*");
			Console.Write("\t\tIntroduce una opción: ");
			opcion = Console.ReadKey().KeyChar - '0';
		}
		Console.Clear();
		return opcion;
	}
	
	static string CuadraTexto(string texto, int numCaracteres)
	{
		texto += "                                  ";
		return texto.Substring(0, numCaracteres);
	}

	
	static string CuadraTexto(int numCaracteres, string texto)
	{
		texto += "                                  " + texto;
		return texto.Substring(texto.Length - numCaracteres);
	}

	
	static string CuadraNumero(double num, int numCharacteres)
	{
		string texto = "                    " + num.ToString("0.0");
		return texto.Substring(texto.Length - numCharacteres);
	}

}

