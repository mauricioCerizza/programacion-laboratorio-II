using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BarajaLista
    {
        private List<Carta> cartas;
        private const int cantidadMaximaCartas = 48;
        private Random random;

        public BarajaLista()
        {
            this.random = new Random();
            this.cartas = new List<Carta>();

            for (int palo = 0; palo < 4; palo++)
            {
                for (int valor = 1; valor <= 12; valor++)
                {
                    this.cartas.Add(new Carta((Carta.Valor)valor, (Carta.Palo)palo));
                }
            }
        }

        public Carta RemoverUltimaCarta()
        {
            Carta ultimaCarta = this.cartas.LastOrDefault();
            this.cartas.Remove(ultimaCarta);

            return ultimaCarta;
        }

        public bool AgregarCarta(Carta carta)
        {
            if (this.cartas.Count == cantidadMaximaCartas)
            {
                return false;
            }

            this.cartas.Add(carta);

            return true;
        }

        /*
          Algoritmo BarajadoAleatorio:
             Entrada:
                  Un Array(0,1,2,3,4... Cantidad-1) de valores.
             Salida:
                  El mismo array con sus valores en posiciones aleatorias.
             Definición de variables:
                  Cantidad: Un entero que señala la cantidad total de ítems que tiene el array.
                  k: Un entero, que rige la cuenta del bucle.
                  az: Un entero, elegido por una función Random en el rango 0-k (nótese que k se va reduciendo).
                  tmp: Un entero, que ha de contener un valor para intercambiar valores entre 2 posiciones.
             Funciones auxiliares:
                  Tamaño: Una función que devuelve la cantidad de elementos que contiene el array.
                  Random: Una función que devuelve un número aleatorio de un rango de valores.
 
             Cantidad = Tamaño(Array)  
             Recorrer con k desde Cantidad-1 hasta 1 Regresivamente
                az = Random(entre 0 y k)
         
                tmp = Array(az)
                Array(az) = Array(k)
                Array(k) = tmp
             Siguiente
         */
        public void MezclarCartas()
        {
            int cantidad = this.cartas.Count;

            for (int k = cantidad - 1; k >= 1; k--)
            {
                int posicionAleatoria = this.random.Next(0, k); // El máximo no es inclusivo.
                Carta cartaAleatoria = this.cartas[posicionAleatoria];
                this.cartas[posicionAleatoria] = this.cartas[k];
                this.cartas[k] = cartaAleatoria;
            }
        }

        public string ImprimirCartas()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Cartas en la baraja:");

            foreach (Carta carta in this.cartas)
            {
                stringBuilder.AppendLine(carta.ObtenerNombre());
            }

            return stringBuilder.ToString();
        }

        public void OrdenarCartas()
        {
            this.cartas.Sort(Carta.Comparar);
        }
    }
}
