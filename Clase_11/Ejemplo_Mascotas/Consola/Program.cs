using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();

            veterinaria.AddMascota(new Gato("Salem", new DateTime(1990, 01, 01), "Sisal"));
            veterinaria.AddMascota(new Perro("Fatiga", new DateTime(2005, 03, 05)));
            veterinaria.AddMascota(new Gatito("Tito", DateTime.Today));

            foreach (Mascota mascota in veterinaria.Mascotas)
            {
                Console.WriteLine(mascota.CalcularEdad());

                //if (mascota.GetType() == typeof(Gato))
                if (mascota is Gato)
                {
                    Gato gato = (Gato)mascota;
                    Console.WriteLine(gato.SaltarSobreMicrofono());
                    Console.WriteLine(gato.PlanificarDominacionMundial());
                }

                Console.WriteLine(mascota.MostrarDatos());
            }            

            Console.ReadKey();
        }
    }
}
