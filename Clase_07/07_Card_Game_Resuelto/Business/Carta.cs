using System;
using System.Collections;
using System.Collections.Generic;

namespace Business
{
    public class Carta
    {
        public enum Palo
        {
            Copas,
            Oros,
            Bastos,
            Espadas
        }

        public enum Valor
        {
            As = 1,
            Dos,
            Tres,
            Cuatro,
            Cinco,
            Seis,
            Siete,
            Ocho,
            Nueve,
            Sota = 10,
            Caballo,
            Rey
        }

        private Valor valor;
        private Palo palo;

        public Carta(Valor valor, Palo palo)
        {
            this.valor = valor;
            this.palo = palo;
        }

        public string ObtenerNombre()
        {
            return $"{this.valor} de {this.palo}";
        }

        public static int Comparar(Carta carta, Carta otraCarta)
        {
            int retorno = carta.palo - otraCarta.palo;

            if (retorno == 0)
            {
                retorno = carta.valor - otraCarta.valor;
            }

            return retorno;
        }
    }
}
