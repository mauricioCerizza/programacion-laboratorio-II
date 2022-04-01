using System;
using System.Collections;
using System.Collections.Generic;

namespace Clase_07
{
    class Program
    {
        static void Main(string[] args)
        {
            ProbarStack();

            Console.ReadKey();
        }

        static void ProbarStack()
        {
            // LIFO - Último en entrar , primero en salir.
            Stack<string> pila = new Stack<string>();
            pila.Push("Juan Perez"); // Agregar
            pila.Push("Fede"); // Agregar
            pila.Push("Griselda");

            // No altera la colección
            foreach (string nombre in pila)
            {
                Console.WriteLine(nombre);
            }

            // El método Peek devuelve el siguiente elemento sin eliminarlo. 
            Console.WriteLine(pila.Peek());

            // Saca un elemento de la pila en orden lifo.
            string elemento = pila.Pop();

            Console.WriteLine("----------");
            foreach (string nombre in pila)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("----------");
            // Saca un elemento de la cola en orden fifo.
            pila.Pop();

            Console.WriteLine("----------");
            foreach (string nombre in pila)
            {
                Console.WriteLine(nombre);
            }
        }

        static void ProbarQueue()
        {
            // FIFO - Primero en entrar , primero en salir.
            Queue<string> colaDeAtencion = new Queue<string>();
            colaDeAtencion.Enqueue("Juan Perez"); // Agregar
            colaDeAtencion.Enqueue("Fede"); // Agregar
            colaDeAtencion.Enqueue("Griselda");

            // No altera la colección
            foreach (string nombre in colaDeAtencion)
            {
                Console.WriteLine(nombre);
            }
            
            Console.WriteLine("----------");

            // El método Peek devuelve el siguiente elemento sin eliminarlo. 
            Console.WriteLine(colaDeAtencion.Peek());

            Console.WriteLine("----------");
            // Saca un elemento de la cola en orden fifo.
            string nombreSiguiente = colaDeAtencion.Dequeue();

            foreach (string nombre in colaDeAtencion)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("----------");
            // Saca un elemento de la cola en orden fifo.
            colaDeAtencion.Dequeue();

            foreach (string nombre in colaDeAtencion)
            {
                Console.WriteLine(nombre);
            }
        }

        static void ProbarDictionary()
        {
            // Declaro e instancio.
            Dictionary<string, int> guiaTelefonica = new Dictionary<string, int>();
            guiaTelefonica.Add("Oggioni", 12345676); // Agregar
            guiaTelefonica.Add("Dávila", 78945612);
            guiaTelefonica.Add("Cerizza", 78945612);

            // Recorro cada KeyValuePair en el diccionario
            foreach (KeyValuePair<string, int> parClaveValor in guiaTelefonica)
            {
                Console.WriteLine($"Apellido: {parClaveValor.Key} Teléfono: {parClaveValor.Value}");
            }

            // Leer
            Console.WriteLine($"Busco por clave 'Dávila' y devuelve {guiaTelefonica["Dávila"]}"); 
            guiaTelefonica["Dávila"] = 55554444; // Asignar

            Console.WriteLine($"Busco por clave 'Dávila' y devuelve {guiaTelefonica["Dávila"]}");

            Console.WriteLine("Muestro llaves (keys)");
            foreach (string key in guiaTelefonica.Keys) // Propiedad Keys devuelve todas las llaves.
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Muestro valores");
            foreach (int value in guiaTelefonica.Values) // Propiedad Values devuelve todos los valores
            {
                Console.WriteLine(value);
            }

            // Cantidad de pares clave-valor en el diccionario
            Console.WriteLine($" cantidad: {guiaTelefonica.Count}"); 
            
            // Verificar si contiene una clave.
            Console.WriteLine($"¿Contiene la clave Perez? {guiaTelefonica.ContainsKey("Perez")}");
            
            // Verificar si contiene un determinado valor.
            Console.WriteLine($"¿Contiene el valor 78945612? {guiaTelefonica.ContainsValue(78945612)}");

            guiaTelefonica.Remove("Cerizza"); // Remuevo por clave

            guiaTelefonica.Clear(); // Limpiar la colección
        }

        static void ProbarList()
        {
            // Declarar e Instanciar
            List<int> numeros = new List<int>();
            numeros.Add(1); // Agregar elementos.
            numeros[0] = 2; // Asignar
            int UnNumero = numeros[0]; // Leer
            numeros.Add(5);
            numeros.Add(3);

            // Recorro con un for. Count devuelve la cantidad de elementos en la lista.
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("----------");
            // Invierte el orden de los elementos de la lista.
            numeros.Reverse();
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("----------");

            // Sort ordena la lista a partir de un criterio ubicado en otro método.
            // El método que determina el criterio de comparación debe devolver un entero
            // y recibir 2 parámetros del tipo que contenga la lista. 
            numeros.Sort(Comparar); // ORDENA

            // Recorro con un foreach
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("----------");
            // Obtener el índice del primer objeto que matchee (==)
            int indice = numeros.IndexOf(5);

            // Eliminar un elemento de un índice especificado
            numeros.RemoveAt(indice); 
            
            // Eliminar el primer elemento que matchee (==).
            numeros.Remove(3);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Clear(); // Limpia la colección
        }

        /// <summary>
        /// Si a es mayor a b, devuelve un número positivo.
        /// Si a es menor a b, devuelve un número negativo.
        /// Si a es igual a b, devuelve cero.
        /// </summary>
        static int Comparar (int a, int b)
        {
            return b - a;
        }

        static void ProbarArray()
        {
            // Declarar array unidimensional
            string[] nombres;

            // Instanciar array unidimensional
            nombres = new string[4];

            // Inicializar / Asignar valores
            nombres[0] = "Fede";
            nombres[1] = "Claudia";
            nombres[2] = "Paula";
            nombres[3] = "Mauricio";

            // Recorrer
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            // Genera una copia del array
            nombres.Clone(); 

            // Número de dimensiones del array
            Console.WriteLine($"Dimensiones: {nombres.Rank}");

            // Genera un nuevo array con el nuevo tamaño, migrando los elementos del array original.
            Array.Resize(ref nombres, 5);

            foreach (string nombre in nombres)
            {
                if (nombre != null)
                {
                    Console.WriteLine(nombre);
                }
                else
                {
                    Console.WriteLine("ES NULL");
                }
            }

            // -----------------------------------------------------------------
            // Arrays Multi-dimensionales
            string[,] personas = new string[3, 2]; // Instanciar y declarar
            personas[0, 0] = "Eze"; // Asignar
            personas[0, 1] = "1232345";
            personas[1, 0] = "Mau";
            personas[1, 1] = "15646596";
            personas[2, 0] = "Matias";
            personas[2, 1] = "987654656";

            // Instanciar e inicializar en una línea.
            string[,] personas2 = { { "1", "2" }, { "3", "4" } }; 

            // Propiedad Rank: Cantidad de dimensiones.
            Console.WriteLine($"Dimensiones: {personas2.Rank}"); 

            // Propiedad Length: Cantidad de posiciones (multiplicación de tamaño de las dimensiones).
            Console.WriteLine($"Posiciones: {personas2.Length}");

            // Obtener el tamaño de una dimensión en particular con GetLength.
            Console.WriteLine($"Tamaño dimensión 1: {personas2.GetLength(0)}");

            // Recorrer
            for (int i = 0; i < personas.GetLength(0); i++)
            {
                Console.WriteLine($"Nombre: {personas[i, 0]} DNI: {personas[i, 1]}");
            }

            // -----------------------------------------------------------------
            // JAGGED ARRAYS - Arrays escalonados - Arrays de arrays
            string[][] arrayDeArrays = new string[2][]; // Declaro e instancio

            // Asigno, cada elemento es otro array.
            arrayDeArrays[0] = new string[1] { "Casa" }; 
            arrayDeArrays[1] = nombres;

            // Acceder a uno de los arrays.
            Console.WriteLine(arrayDeArrays[0]);

            // Acceder a la posición cero del array anidado 
            // ubicado en la posición cero de "arrayDeArrays". 
            Console.WriteLine(arrayDeArrays[0][0]);
        }
    }
}
