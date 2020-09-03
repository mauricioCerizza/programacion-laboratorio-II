using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;

        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        } 

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            // Con AppendFormat() y \n
            stringBuilder.AppendFormat("Nombre: {0}\n", this.nombre.ToUpper());

            // Con AppendLine() y Template Strings
            stringBuilder.AppendLine($"Fecha de Nacimiento (custom): {this.fechaNacimiento.ToString("dd - MM - yyyy")}");
            stringBuilder.AppendLine($"Fecha de Nacimiento (corta): {this.fechaNacimiento.ToShortDateString()}");
            stringBuilder.AppendLine($"Fecha de Nacimiento (larga): {this.fechaNacimiento.ToLongDateString()}");
            
            // Con AppendLine() y string.Format()
            stringBuilder.AppendLine(String.Format("Especie: {0}", this.especie));

            return stringBuilder.ToString();
        }

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - this.fechaNacimiento.Year;

            if (this.fechaNacimiento.AddYears(edad) > fechaActual)
            {
                edad--;
            }

            return edad;
        }      
    }
}
