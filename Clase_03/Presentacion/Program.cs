using System;
using Veterinaria;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancio Garfield
            Gato garfield = new Gato("  Garfield", new DateTime(2018, 03, 28));
            Gato garfieldElTercero = garfield;
            Gato garfield2 = new Gato("Garfield", new DateTime(2018, 03, 28));
            
            // Instancio Felix
            Gato felix = new Gato(null, new DateTime(1,1,1));

            // Invoco métodos de instancia
            garfield.AsignarPeso(5);
            garfield2.AsignarPeso(5);
            felix.AsignarPeso(3);

            // Console.WriteLine --> Método estático (de clase)
            // NO SE NECESITA INSTANCIAR UN OBJETO PARA INVOCARLO
            Console.WriteLine(garfield.ObtenerDatos());
            Console.WriteLine(felix.ObtenerDatos());
            Console.ReadKey();

            // Llama a ToString() que viene del tipo padre Object.
            Console.WriteLine(garfield);

            // Operador ==. Por defecto compara si apuntan
            // a la misma dirección de memoria (son la misma instancia).
            // Da false porque no son el mismo objeto en memoria.
            Console.WriteLine("¿Son iguales? {0}", garfield == garfield2);
            
            // Da true porque son el mismo objeto en memoria.
            Console.WriteLine("¿Son iguales? {0}", garfield == garfieldElTercero);

            // Equals es un método de instancia que sirve para comparar un objeto con otro.
            // Por defecto, compara si son la misma instancia en memoria. 
            Console.WriteLine("¿Son iguales? {0}", garfield.Equals(garfield2));

            // Método estático para comparar si dos objetos son la misma instancia en memoria.
            Console.WriteLine("¿Son iguales? {0}", ReferenceEquals(garfield, garfield2));

            Console.Clear();
            // GetHashCode es un método de instancia que devuelve un código único
            // para identificar a una instancia en memoria. 
            Console.WriteLine($"{nameof(garfield)}: {garfield.GetHashCode()}");
            Console.WriteLine($"{nameof(garfield2)}: {garfield2.GetHashCode()}");
            Console.WriteLine($"{nameof(garfieldElTercero)}: {garfieldElTercero.GetHashCode()}");
        }
    }
}
