using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Logic
{
    public class Serializador<T>
        where T : new()
    {
        public void SerializarXml(T objeto, string rutaCompleta)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;

            try
            {
                writer = new XmlTextWriter(rutaCompleta, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objeto);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public T DeserializarXml(string rutaCompleta)
        {
            using (XmlTextReader reader = new XmlTextReader(rutaCompleta))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T) serializer.Deserialize(reader);
            }
        }
    }
}
