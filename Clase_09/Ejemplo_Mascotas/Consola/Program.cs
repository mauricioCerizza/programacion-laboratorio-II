using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();

            veterinaria.AddMascota(new Gato("Salem", new DateTime(1990, 01, 01)));
            veterinaria.AddMascota(new Perro("Fatiga", new DateTime(2005, 03, 05)));

            foreach (Mascota mascota in veterinaria.Mascotas)
            {
                Console.WriteLine(mascota.CalcularEdad());
                                
                //if (mascota.GetType() == typeof(Gato))
                if (mascota is Gato)
                {
                    Gato gato = (Gato)mascota;
                    Console.WriteLine(gato.MostrarDatos());
                    Console.WriteLine(gato.SaltarSobreMicrofono());
                }
                else
                {
                    Console.WriteLine(mascota.MostrarDatos());
                }
            }            

            Console.ReadKey();
        }
    }
}
