using System.IO;

namespace Biblioteca
{
    public class Archivador
    {
        private readonly string ruta;

        public Archivador(string ruta)
        {
            this.ruta = ruta;
        }

        public void Guardar(string texto)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(this.ruta, false);

                writer.WriteLine(texto);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public string Leer()
        {
            using (StreamReader reader = new StreamReader(this.ruta))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
