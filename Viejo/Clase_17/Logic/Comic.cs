using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Comic : Producto
    {
        private int cantidadPaginas;

        public Comic(string titulo, double precio, int cantidadPaginas) : base(precio, titulo)
        {
            this.cantidadPaginas = cantidadPaginas;
        }

        public override string MostrarDatos()
        {
            return $"Es un comic. De titulo {this.Titulo} y tiene {this.cantidadPaginas} páginas.";
        }
    }
}
