using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Figura : Producto
    {
        private float altura;

        public Figura(string titulo, double precio, float altura) : base(precio, titulo)
        {
            this.altura = altura;
        }

        public override string MostrarDatos()
        {
            return $"Es una figura. De titulo {this.Titulo} y mide {this.altura}";
        }
    }
}
