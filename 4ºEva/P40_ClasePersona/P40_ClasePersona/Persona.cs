using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40_ClasePersona
{
    internal class Persona
    {
        //Atributos
        public string nombre,apellidos;
        private int año, mes, dia;
        //Get and Set
        public string Nombre 
        {
            get { return nombre; } 
            set { nombre = value; }
        }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Año { get => año; set => año = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Dia { get => dia; set => dia = value; }

        //Propiedad Edad
        public int Edad
        {
            get
            {
                int edad = 0;
                int diaHoy = DateTime.Now.Day;
                int mesHoy = DateTime.Now.Month;
                int añoHoy = DateTime.Now.Year;
                int fechaNacimiento = mes * 100 + dia;
                int fechaHoy = mesHoy * 100 + diaHoy;
                if (fechaHoy < fechaNacimiento)
                {
                    edad = añoHoy - año - 1;
                }
                else
                    edad = añoHoy - año;

                return edad;
            }
            
        }
        //Constructores
        public Persona(string nombre,string apellidos,int dia,int mes,int año)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dia = dia;
            this.mes = mes;
            this.año = año;
        }
        public Persona(string nombre,string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            dia = 1;
            mes = 2;
            año = 2000;
        }
        public Persona()
        {

        }

        
    }
}
