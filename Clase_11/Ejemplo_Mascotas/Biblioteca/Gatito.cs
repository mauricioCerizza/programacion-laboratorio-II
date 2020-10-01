using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gatito : Gato
    {
        public Gatito(string nombre, DateTime fechaNacimiento) : base(nombre, fechaNacimiento, "No tiene")
        {
        }

        public override string SaltarSobreMicrofono()
        {
            return "No llego :(";
        }
    }
}
