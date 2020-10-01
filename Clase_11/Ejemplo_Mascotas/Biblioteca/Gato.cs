using System;
using System.Text;

namespace Biblioteca
{
    public class Gato : Mascota
    {
        private string rascadorFavorito;
        public Gato(string nombre, DateTime fechaNacimiento, string rascadorFavorito) 
            : base(nombre, fechaNacimiento)
        {
            this.rascadorFavorito = rascadorFavorito;
        }

        public string PlanificarDominacionMundial()
        {
            return "Estoy planificando...";
        }

        public virtual string SaltarSobreMicrofono()
        {            
            return "Soy muy buen cazador :3...";
        }

        public override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.MostrarDatos());
            stringBuilder.AppendLine($"El tipo de rascador favorito es de {this.rascadorFavorito}");

            return stringBuilder.ToString();
        }
    }
}
