using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class SerializadorXml<T>
        where T : class, new()
    {
        private readonly string ruta;

        public SerializadorXml(string ruta)
        {
            this.ruta = ruta;
        }

        public void Guardar(T objeto)
        {
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(xmlTextWriter, objeto);
            }
        }

        public T Leer()
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader(ruta))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T) serializer.Deserialize(xmlTextReader);
            }
        }
    }
}
