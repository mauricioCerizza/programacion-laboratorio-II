namespace Biblioteca
{
    // Los objetos Newsletter son los emisores del evento.
    public class Newsletter // Control
    {
        public delegate void NovedadHandler (Newsletter sender, NewsletterEventArgs eventArgs);
        // Declarar un evento
        public event NovedadHandler NovedadEnviada; // Click

        private string tema;

        public Newsletter(string tema)
        {
            this.tema = tema;
        }

        public string Tema
        {
            get { return tema; }
        }

        public void EnviarNovedades() // Acción de hacer click
        {         
            // Lanzo el evento.
            if (NovedadEnviada is not null)
            {
                NewsletterEventArgs eventArgs = new NewsletterEventArgs();
                eventArgs.Contenido = "TEST";

                //NovedadEnviada.Invoke(this, "TEST");
                NovedadEnviada(this, eventArgs);
            }
        }
    }
}
