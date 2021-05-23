using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class SerializadorBinario<T>
        where T : class, new()
    {
        private readonly string ruta;

        public SerializadorBinario(string ruta)
        {
            this.ruta = ruta;
        }

        public void Guardar(T objeto)
        {
            Stream stream = null;
            try
            {
                stream = new FileStream(this.ruta, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, objeto);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        public T Leer()
        {
            using (Stream stream = new FileStream(this.ruta, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (T) formatter.Deserialize(stream);
            }
        }
    }
}
