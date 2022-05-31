using System;

namespace Clase_18
{
    public class Receptor
    {
        string nombre;

        public Receptor(string nombre)
        {
            this.nombre = nombre;
        }

        public void RecibirNotificacion()
        {
            Console.WriteLine($"Yo {nombre} recibí una notificación a las {DateTime.Now}.");
        }
    }
}
