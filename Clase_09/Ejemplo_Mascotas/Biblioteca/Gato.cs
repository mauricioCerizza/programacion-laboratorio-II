using System;
using System.Text;

namespace Biblioteca
{
    public class Gato : Mascota
    {
        string rascadorFavorito;
        public Gato(string nombre, DateTime fechaNacimiento) 
            : base(nombre, fechaNacimiento)
        {
        }

        public string PlanificarDominacionMundial()
        {
            return "Estoy planificando...";
        }

        public string SaltarSobreMicrofono()
        {            
            return "Soy muy buen cazador :3...";
        }

        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.MostrarDatos());
            stringBuilder.AppendLine("El tipo de rascador favorito es de cartón");

            return stringBuilder.ToString();
        }
    }
}
