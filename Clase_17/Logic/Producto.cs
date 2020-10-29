using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Producto
    {
        private string titulo;
        private double precio;

        protected Producto(double precio, string titulo)
        {
            this.precio = precio;
            this.titulo = titulo;
        }

        public virtual string Titulo { 
            get
            {
                return this.titulo;
            }
        }

        public virtual double Precio 
        { 
            get
            {
                return this.precio;
            }
        }

        public abstract string MostrarDatos();
    }
}
