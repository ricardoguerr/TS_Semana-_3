using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_SEMANA_13
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double estatura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Estatura { get => estatura; set => estatura = value; }

        public void CrearPersona(string Nombre, string Apellido, int Edad, double Estatura)
        {
            nombre = Nombre;
            apellido= Apellido;
            edad = Edad;
            estatura = Estatura;
        }
       
        public void MostrarDatos() 
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Altura: {estatura}m");
        }
    }
}
