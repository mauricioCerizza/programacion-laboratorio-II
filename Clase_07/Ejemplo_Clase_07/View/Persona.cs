namespace View
{
    internal class Persona
    {
        private int dni;
        private string nombre;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public Persona(int dni, string nombre)
        {
            Dni = dni;
            this.nombre = nombre;
        }

    }
}