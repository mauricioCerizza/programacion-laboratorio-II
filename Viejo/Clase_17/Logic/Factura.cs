using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Factura<TProducto>
         where TProducto : Producto, new()
    {
        private TProducto miatributo;

        public U GenerarFactura<U>(TProducto producto, int unidades) 
        {
            double precioFinal = producto.Precio + producto.Precio * 0.21;
            return $"Compraste {unidades} unidades de {producto.MostrarDatos()}. Precio final: {precioFinal}";
        }
    }
}
