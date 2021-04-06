using System;
using System.Text;

namespace Business
{
    public class BarajaArray
    {
        private Carta[] cartas;
        private const int cantidadMaximaCartas = 48;
        private Random random;

        public BarajaArray()
        {
            this.random = new Random();
            int indice = 0;
            this.cartas = new Carta[cantidadMaximaCartas];

            for (int palo = 0; palo < 4; palo++)
            {
                for (int valor = 1; valor <= 12; valor++)
                {
                    this.cartas[indice++] = new Carta((Carta.Valor)valor, (Carta.Palo)palo);
                }
            }
        }

        public Carta RemoverUltimaCarta()
        {
            if (this.cartas.Length == 0)
            {
                return null;
            }

            Carta ultimaCarta = this.cartas[this.cartas.Length - 1];
            Array.Resize(ref this.cartas, this.cartas.Length - 1);

            return ultimaCarta;
        }

        public bool AgregarCarta(Carta carta)
        {
            if (this.cartas.Length == cantidadMaximaCartas)
            {
                return false;
            }

            Array.Resize(ref this.cartas, this.cartas.Length + 1);
            this.cartas[this.cartas.Length - 1] = carta;

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
            int cantidad = this.cartas.Length;

            for (int k = cantidad - 1; k >= 1; k--)
            {
                int posicionAleatoria = this.random.Next(0, k); // El máximo no es inclusivo.
                this.Intercambiar(posicionAleatoria, k);
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
            bool huboIntercambio;

            do {
                huboIntercambio = false;

                for (int i = 1; i < this.cartas.Length; i++)
                {
                    if (Carta.Comparar(this.cartas[i - 1], this.cartas[i]) > 0)
                    {
                        this.Intercambiar(i - 1, i);
                        huboIntercambio = true;
                    }
                }

            } while (huboIntercambio);
        }

        private void Intercambiar(int indiceOrigen, int indiceDestino)
        {
            Carta cartaAleatoria = this.cartas[indiceOrigen];
            this.cartas[indiceOrigen] = this.cartas[indiceDestino];
            this.cartas[indiceDestino] = cartaAleatoria;
        }
    }
}
