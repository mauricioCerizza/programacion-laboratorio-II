using Logic;
using System;
using System.Collections.Generic;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            //EjemploSerializacionXml();
            //EjemploArchivos();
        }

        private static void EjemploSerializacionXml()
        {
            try
            {
                List<Persona> personas = new List<Persona>();
                personas.Add(new Persona("Fede", "Dávila", new DateTime(1984, 03, 14)));
                personas.Add(new Persona("Mauricio", "Cerizza", new DateTime(1992, 02, 09)));
                Serializador<List<Persona>> serializador = new Serializador<List<Persona>>();

                serializador.SerializarXml(personas, "Profes.xml");

                List<Persona> personas2 = new List<Persona>();
                personas2 = serializador.DeserializarXml("Profes.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OCURRIÓ UN ERROR: {ex.ToString()}");
            }
            Console.ReadKey();
        }

        private static void EjemploArchivos()
        {
            try
            {
                string texto = "Hola mundo";
                string nombreArchivo = "clase_19";
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                FileManager fileManager = new FileManager();
                fileManager.EscribirArchivoTexto(ruta, nombreArchivo, texto, false);
                fileManager.EscribirArchivoTexto(ruta, nombreArchivo, "Chau Mundo", true);

                Console.WriteLine(fileManager.LeerArchivoTexto(ruta, nombreArchivo));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OCURRIÓ UN ERROR: {ex.ToString()}");
            }
            Console.ReadKey();
        }




    }
}
