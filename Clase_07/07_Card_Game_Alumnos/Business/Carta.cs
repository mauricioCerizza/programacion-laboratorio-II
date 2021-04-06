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
    }
}
