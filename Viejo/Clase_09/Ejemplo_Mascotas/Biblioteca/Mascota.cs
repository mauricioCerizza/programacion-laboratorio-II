using System;
using System.Text;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        protected DateTime fechaNacimiento;

        public Mascota(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        } 

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
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

        public static void Metodo()
        {

        }
    }
}
