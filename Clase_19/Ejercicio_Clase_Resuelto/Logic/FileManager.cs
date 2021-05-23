using System.IO;

namespace Logic
{
    public class FileManager
    {
        public void EscribirArchivoTexto(string ruta, string nombre, string texto, bool anexar)
        {
            StreamWriter streamWriter = null;
            try
            {
                string rutaCompleta = ruta + @"\"+ nombre + ".txt";
                streamWriter = new StreamWriter(rutaCompleta, anexar);
                streamWriter.WriteLine(texto);
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
            }
        }

        public string LeerArchivoTexto(string ruta, string nombre)
        {
            StreamReader streamReader = null;
            try
            {
                string rutaCompleta = ruta + @"\" + nombre + ".txt";
                streamReader = new StreamReader(rutaCompleta);

                string text = string.Empty;
                string newLine = streamReader.ReadLine();

                while (newLine != null)
                {
                    text += newLine + "\n";
                    newLine = streamReader.ReadLine();
                }

                return text;
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
            }
        }
    }
}
