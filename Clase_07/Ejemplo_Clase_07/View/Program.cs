using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Program
    {
        /// <summary>
        /// ATENCIÓN
        /// Para descomentar agregar una barra / al bloque de comentarios.
        /// /* Comentario de bloque activado.
        /// //* Comentario de bloque desactivado.
        /// </summary>
        static void Main(string[] args)
        {
            #region Arrays-Matrices
            /*
                // Tienen tamaño fijo.
                // Indexados numéricamente por posición del elemento.

                string[] nombres = new string[3];
                nombres[0] = "Fede";
                nombres[1] = "Claudia";
                nombres[2] = "Paula";
                nombres[3] = "Mauricio"; // Si agregamos un elemento fuera del tamaño da un error en tiempo de ejecución. 
            //*/
            #endregion

            #region Listas
            /*
                // Crecen y decrecen dinámicamente como todas las colecciones (no tienen tamaño fijo).
                // Tienen seguridad de tipos como todas las colecciones GENÉRICAS. (todos los elementos son del mismo tipo).
                // Indexadas numéricamente por posición del elemento.

                // Importante instanciar las colecciones, de otra forma fallarán.
                List<string> listaDeNombres = new List<string>();

                // El método ADD agrega un nuevo elemento en la posición siguiente.
                listaDeNombres.Add("Fede");
                listaDeNombres.Add("Claudia");
                listaDeNombres.Add("Mauricio");

                // Puedo insertar directamente en una posición determinada y la lista se ordenará automáticamente. 
                listaDeNombres[0] = "Paula";

                // Puedo recorrer con un foreach (OJO, no eliminar ni agregar elementos dentro de un foreach).
                foreach (string nombre in listaDeNombres)
                {
                    Console.WriteLine(nombre);
                }

                // El método REMOVE elimina un elemento de la colección utilizando la comparación por defecto del tipo del objeto. 
                listaDeNombres.Remove("Mauricio");

                // Puedo recorrer con un for tradicional. 
                for (int i = 0; i < listaDeNombres.Count; i++)
                {
                    string nombre = listaDeNombres[i];
                    Console.WriteLine(listaDeNombres[i]);
                }

                // El método RemoveAt elimina un elemento de la colección que esté en la posición o índice indicado en el argumento.
                listaDeNombres.RemoveAt(0);

                // La lista se ordenará automáticamente, y ahora el elemento en la posición 1 pasará a la posición 0. 
                Console.WriteLine(listaDeNombres[0]);
            //*/
            #endregion

            #region Diccionarios
            /*
                // Crecen y decrecen dinámicamente como todas las colecciones (no tienen tamaño fijo).
                // Tienen seguridad de tipos como todas las colecciones GENÉRICAS. (todos los elementos son del mismo tipo).
                // Se componen de PARES CLAVE-VALOR (sus elementos van siempre de a pares). 
                // Indexadas por valor de la CLAVE, la cual es única (irrepetible).
                Dictionary<int, string> agenda = new Dictionary<int, string>(); // Indico el tipo de la clave, y luego el del valor.

                // El método Add permite agregar un nuevo par clave-valor al diccionario. 
                agenda.Add(12345678, "Juan Perez");
                agenda.Add(87654321, "Pedro Sanchez");
                agenda.Add(12345679, "Griselda");
                agenda.Add(123479, "Juan Perez");
            
                // Puedo recorrerlo con un foreach accediendo a cada KeyValuePair (par clave-valor).
                foreach (KeyValuePair<int, string> contacto in agenda)
                {
                    Console.WriteLine($"La clave es {contacto.Key} y el valor es {contacto.Value}");
                }

                // El método ContainsKey compara el valor del argumento con las claves y devuelve TRUE si la clave existe.
                if (agenda.ContainsKey(0))
                { // En este caso no existe, no entra al if.
                    Console.WriteLine(agenda[0]);
                }

                if (agenda.ContainsKey(12345679))
                { // En este caso SÍ existe la clave, entra al if. 
                    Console.WriteLine(agenda[12345679]);
                }
            //*/
            #endregion

            #region Colas
            /*
                // Crecen y decrecen dinámicamente como todas las colecciones (no tienen tamaño fijo).
                // Pueden ser genéricas (con seguridad de tipos) o no-genéricas (elementos de tipo Object).
                // No están indexadas, ni pueden ser ordenadas o utilizadas para búsquedas. 
                // Su orden de procesamiento es FIFO (primero en entrar primero en salir). Para esos casos están optimizadas y para esos casos se deben usar.
                Queue<string> colaDeAtencion = new Queue<string>();

                // El método Enqueue agrega elementos a la cola.
                colaDeAtencion.Enqueue("Juan Perez");
                colaDeAtencion.Enqueue("Griselda");
                colaDeAtencion.Enqueue("Fede");
                
                // Se pueden recorrer con un foreach, los elementos se leen en orden FIFO pero no se eliminan.
                foreach (string cliente in colaDeAtencion)
                {
                    Console.WriteLine(cliente);
                }

                // El método Peek devuelve el siguiente elemento sin eliminarlo. 
                Console.WriteLine(colaDeAtencion.Peek());
                
                // Se puede usar un for para ir retirando los elementos de forma segura. 
                for (int i = 0; i < colaDeAtencion.Count; i++)
                {
                    // El método Dequeue devuelve el siguiente elemento de acuerdo al orden FIFO y lo elimina de la cola. 
                    Console.WriteLine(colaDeAtencion.Dequeue());
                }
            //*/
            #endregion

            #region Pilas
            /*
                // Crecen y decrecen dinámicamente como todas las colecciones (no tienen tamaño fijo).
                // Pueden ser genéricas (con seguridad de tipos) o no-genéricas (elementos de tipo Object).
                // No están indexadas, ni pueden ser ordenadas o utilizadas para búsquedas. 
                // Su orden de procesamiento es LIFO (último en entrar primero en salir). Para esos casos están optimizadas y para esos casos se deben usar.
                Stack<char> letras = new Stack<char>();
                
                // El método Push agrega elementos a la pila.
                letras.Push('B');
                letras.Push('G');
                letras.Push('Z');

                // Método peek devuelve el siguiente sin eliminarlo.
                Console.WriteLine(letras.Peek());
                
                // Se puede recorrer con for y foreach. Mismo criterio que colas pero con orden LIFO.
                foreach (char letra in letras)
                {
                    Console.WriteLine(letra);
                }

                // El método Pop devuelve el siguiente elemento de acuerdo al orden LIFO y lo elimina de la pila. 
                Console.WriteLine(letras.Pop());
                Console.WriteLine(letras.Pop());
                Console.WriteLine(letras.Pop());
            //*/
            #endregion

            #region SortedList
            /*
                // Crecen y decrecen dinámicamente como todas las colecciones (no tienen tamaño fijo).
                // Tienen seguridad de tipos como todas las colecciones GENÉRICAS. (todos los elementos son del mismo tipo).
                // Se componen de PARES CLAVE-VALOR (sus elementos van siempre de a pares)
                // Se ordenan automáticamente por clave de acuerdo al criterio por defecto. 

                SortedList<string, Persona> personasOrdenada = new SortedList<string, Persona>();
                // Add igual que en diccionarios.
                personasOrdenada.Add("Juan", new Persona(123, "Juan"));
                personasOrdenada.Add("Paula", new Persona(321, "Paula"));
                personasOrdenada.Add("Claudia", new Persona(13, "Claudia"));
                
                // Recorro igual que en diccionarios
                foreach (KeyValuePair<string, Persona> persona in personasOrdenada)
                {
                    Console.WriteLine($"DNI: {persona.Value.Dni} Nombre: {persona.Value.Nombre}");
                }

                // Si agrego un nuevo elemento, automáticamente ordena la lista de acuerdo al criterio y lo ubica donde corresponda. 
                personasOrdenada.Add("Fede", new Persona(231, "Fede"));
                foreach (KeyValuePair<string, Persona> persona in personasOrdenada)
                {
                    Console.WriteLine($"DNI: {persona.Value.Dni} Nombre: {persona.Value.Nombre}");
                }
            //*/
            #endregion

            #region ArrayList
            /*
                // Crecen y decrecen dinámicamente como todas las colecciones (no tienen tamaño fijo).
                // Son NO-GENÉRICAS, NO tienen seguridad de tipos. (Los elementos son todos de tipo object, pueden ser cualquier tipo).
                // Indexadas numéricamente por posición del elemento.
                ArrayList lista = new ArrayList();
                lista.Add("Griselda");
                lista.Add(123134);
                lista.Add(new Persona(123, "Brian"));

                foreach (object item in lista)
                {
                    Console.WriteLine(item.GetType().Name);
                }
            //*/
            #endregion

            #region Ordenar listas (método SORT)
            /*
                // El método sort recibe un método (sólo el nombre, sin paréntesis) que contiene la lógica para el criterio de ordenamiento.
                // El método debe devolver un entero y recibir dos elementos del mismo tipo que los elementos que contiene la lista. 
                // Compara los elementos y devuelve -1 si el elemento comparado debe ir antes, 1 si debe ir después o 0 si son iguales. 

                List<Persona> personas = new List<Persona>();
                personas.Add(new Persona(123, "Juan"));
                personas.Add(new Persona(321, "Paula"));
                personas.Add(new Persona(13, "Claudia"));
                personas.Add(new Persona(231, "Fede"));

                // 123. 321. 13. 231. 
                foreach (Persona persona in personas)
                {
                    Console.WriteLine($"DNI: {persona.Dni} Nombre: {persona.Nombre}");
                }

                // Ordenar de forma ascendente
                // 13. 123. 231. 321.
                personas.Sort(OrdenarPersonasAscendente);
                foreach (Persona persona in personas)
                {
                    Console.WriteLine($"DNI: {persona.Dni} Nombre: {persona.Nombre}");

                }

                // Ordenar de forma descendente
                // 321. 231. 123. 13.
                personas.Sort(OrdenarPersonasDescendente);
                foreach (Persona persona in personas)
                {
                    Console.WriteLine($"DNI: {persona.Dni} Nombre: {persona.Nombre}");
                }
            //*/
            #endregion

            Console.ReadKey();
        }

        private static int OrdenarPersonasDescendente(Persona elementoSiguiente, Persona elementoActual)
        {
            int criterio = 0;

            if (elementoActual.Dni < elementoSiguiente.Dni)
            {
                criterio = -1;
            }
            else if (elementoActual.Dni > elementoSiguiente.Dni)
            {
                criterio = 1;
            }

            return criterio;
        }

        private static int OrdenarPersonasAscendente(Persona elementoSiguiente, Persona elementoActual)
        {
            int criterio = 0;

            if (elementoActual.Dni > elementoSiguiente.Dni)
            {
                criterio = -1;
            }
            else if (elementoActual.Dni < elementoSiguiente.Dni)
            {
                criterio = 1;
            }

            return criterio;
        }
    }
}
