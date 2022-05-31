using System;

namespace Clase_18
{
    public class EjemploNotificacion
    {
        public static void EjecutarEjemplo()
        {
            Receptor carpinchoReceptor = new Receptor("Carpincho Receptor");
            Receptor lautiReceptor = new Receptor("Lauti");
            Receptor lucasReceptor = new Receptor("Lucas");

            // El delegado apunta al método "RecibirNotificacion" del objeto "carpinchoReceptor" (y solo ese). 
            // Encapsula también al objeto. 
            Action delegadoConNew = new Action(carpinchoReceptor.RecibirNotificacion);
            Emisor.destinatarios.Add(delegadoConNew);

            // Las dos formas de instanciar un delegado son iguales, con o sin "new Delegado()".
            Action delegadoSinNew = lautiReceptor.RecibirNotificacion;
            Emisor.destinatarios.Add(delegadoSinNew); // Instancia de manera automática

            // Si paso la referencia a un método como argumento, se instancia el delegado automáticamente. 
            Emisor.destinatarios.Add(lucasReceptor.RecibirNotificacion);
            Emisor.destinatarios.Add(() => Console.BackgroundColor = ConsoleColor.Red);

            // Delegados multicast
            Action<int> delegadoMulticast = new Perro().Ladrar;
            delegadoMulticast += t => Console.WriteLine($"SE ENVIÓ UNA NOTIFICACIÓN DESPUÉS DE {t} milisegundos...");

            Emisor.destinatariosConTiempo.Add(delegadoMulticast);

            Emisor.ProducirNotificacion();
        }
    }
}
