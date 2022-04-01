using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{

    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            }
        }

        public bool FileExists(string nombreArchivo)
        {
            return File.Exists($"{this.GetDirectoryPath}{nombreArchivo}");
        }

        public void Guardar(string nombreArchivo, T objeto)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter($"{this.GetDirectoryPath}{nombreArchivo}", Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, objeto);
                }
            }
            catch(Exception ex)
            {
                throw new ErrorArchivosException("Ocurrió un error al serializar.", ex);
            }
        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            this.Guardar(nombreArchivo, objeto);
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            try
            {
                if (nombreArchivo.Contains('\\') || !FileExists(nombreArchivo))
                {
                    throw new ErrorArchivosException("Ruta inválida.");
                }

                using (XmlTextReader reader = new XmlTextReader($"{this.GetDirectoryPath}{nombreArchivo}"))
                {                    
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    objeto = (T) serializer.Deserialize(reader);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("Ocurrió un error al deserializar.", ex);
            }
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            return this.Leer(nombreArchivo, out objeto);
        }
    }
}
