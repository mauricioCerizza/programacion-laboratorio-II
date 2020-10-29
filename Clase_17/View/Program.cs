using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Comic comic = new Comic("Un comic", 250.99, 150);
            Factura<Comic> factura = new Factura<Comic>();
            string text = factura.GenerarFactura<Producto>(comic, 2);
            Console.WriteLine(text);

            Console.ReadKey();
        }


    }
}
