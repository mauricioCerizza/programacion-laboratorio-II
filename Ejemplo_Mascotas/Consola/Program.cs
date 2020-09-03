using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar las 4 mascotas
            Mascota salem = new Mascota("Salem", new DateTime(1990, 1, 1), "Gato");
            Mascota buddy = new Mascota("Buddy", new DateTime(1989, 2, 9), "Perro");
            Mascota perry = new Mascota("Perry", new DateTime(2005, 6, 5), "Ornitorrinco");
            Mascota fatiga = new Mascota("Fatiga", new DateTime(2005, 11, 11), "Perro");
            


            // Mostrar en consola utilizando el método MostrarDatos que devuelve un string, los datos de mascota.
            Console.WriteLine(salem.MostrarDatos());
            Console.WriteLine(buddy.MostrarDatos());
            Console.WriteLine(perry.MostrarDatos());
            Console.WriteLine(fatiga.MostrarDatos());

            // Realizar un método que devuelva la edad de la mascota. Usando DateTime (Devuelve un int).
            // Mostrar "{nombre} tiene {edad} años", usando un getter para el nombre y el método que calcula la edad.
            Console.WriteLine($"{salem.GetNombre()} tiene {salem.CalcularEdad()} años.");
            Console.WriteLine($"{buddy.GetNombre()} tiene {buddy.CalcularEdad()} años.");
            Console.WriteLine($"{perry.GetNombre()} tiene {perry.CalcularEdad()} años.");
            Console.WriteLine($"{fatiga.GetNombre()} tiene {fatiga.CalcularEdad()} años.");
            
            Console.ReadKey();
            Console.Clear();
            
            // Cambiar el nombre con un setter y mostrar sus datos antes y despues.
            Mascota gato = new Mascota("Simba", new DateTime(2015, 10, 8), "Gato");
            Console.WriteLine(gato.MostrarDatos());
            gato.SetNombre("Nala");
            Console.WriteLine(gato.MostrarDatos());


            Console.ReadKey();
        }
    }
}
