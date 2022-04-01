using Biblioteca;
using System;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Ezequiel", "Oggioni");
            Mascota perro = new Mascota("Perro", "Merry", new DateTime(2010, 08, 16));
            Vacuna vacunaRabia = new Vacuna("Rabia");
            
            perro.AgregarVacuna(vacunaRabia);
            Mascota gato = new Mascota("Gato", "Nala", new DateTime(2020, 01, 07));

            cliente.AgregarMascota(gato);
            cliente.AgregarMascota(perro);

            Console.WriteLine(cliente.MostrarDatos());
        }
    }
}
