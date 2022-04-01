using System;
using System.Text;

namespace Veterinaria
{
    // CLASE
    public class Gato
    {
        // ATRIBUTOS
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;

        // CONSTRUCTOR
        public Gato(string nombre, DateTime fechaNacimiento)
        {
            SetNombre(nombre);
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetFechaNacimiento(int dia, int mes, int anio)
        {
            fechaNacimiento = new DateTime(dia, mes, anio);
        }

        // MÉTODO
        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = "Sin nombre";
            }

            this.nombre = nombre.Trim();
        }

        public void AsignarPeso(double peso)
        {
            if (peso < 0)
            {
                peso = 0;
            }

            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return peso;    
        }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del gato:");
            sb.AppendLine($"Nombre: {nombre.ToUpper()}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Peso: {peso}");

            return sb.ToString();
        }
    }
}
