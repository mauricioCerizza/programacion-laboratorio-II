using System;
using System.Collections.Generic;
using System.Threading;

namespace Clase_18
{
    public class Emisor
    {
        public static Random random = new Random();
        public static List<Action> destinatarios = new List<Action>();
        public static List<Action<int>> destinatariosConTiempo = new List<Action<int>>();


        public static void ProducirNotificacion()
        {
            //destinatarios.Sort(new Comparison<DelegadoDestinatario>(Comparar));
            //destinatarios = destinatarios.Where(ObtenerCriterioParaFiltrar).ToList();
            destinatarios.Sort(Comparar);

            Console.WriteLine("¡Produciendo notificación!");

            foreach (Action delegadoDestinatario in destinatarios)
            {
                int tiempo = random.Next(2000, 5000);
                Thread.Sleep(tiempo);
                // Dos formas de invocar / usar la instancia del delegado.
                //delegadoDestinatario.Invoke();
                delegadoDestinatario();
            }

            foreach (Action<int> delegadoDestinatarioConTiempo in destinatariosConTiempo)
            {
                int tiempo = random.Next(2000, 5000);
                Thread.Sleep(tiempo);
                // Dos formas de invocar / usar la instancia del delegado.
                //delegadoDestinatarioConTiempo.Invoke(tiempo);
                delegadoDestinatarioConTiempo(tiempo);
            }
        }

        public static bool ObtenerCriterioParaFiltrar(DelegadoDestinatario delegadoDestinatario)
        {
            return delegadoDestinatario.Method.Name.StartsWith('N') || delegadoDestinatario.Method.Name.StartsWith('L');
        }

        public static int Comparar(Action elemento1, Action elemento2)
        {
            return string.Compare(elemento1.Method.Name, elemento2.Method.Name);
        }
    }
}
