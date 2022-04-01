using System;
using System.Text;

namespace Biblioteca
{
    public class Perro : Mascota
    {
        public Perro(string nombre, DateTime fechaNacimiento) 
            : base(nombre, fechaNacimiento)
        {
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.MostrarDatos());
            stringBuilder.AppendLine("Woof woof");

            return stringBuilder.ToString();
        }
    }
}
