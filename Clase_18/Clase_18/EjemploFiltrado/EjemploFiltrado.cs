using System;
using System.Collections.Generic;

namespace Clase_18
{
    public class EjemploFiltrado
    {
        private static List<int> list;

        public static void EjecutarEjemplo()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            list = new List<int>()
            {
                3, 45, 6, -9, 70, -134, 247, 17
            };

            MostrarNumeros();

            list = list.Filtrar(n => n % 2 == 0);

            MostrarNumeros();

            list = list.Filtrar(n => n < 0);

            MostrarNumeros();
        }

        public static void MostrarNumeros()
        {
            string numeros = "";
            foreach (int numero in list)
            {
                numeros += $"{numero} | ";
            }
            Console.WriteLine($"Numeros antes de filtrar: {numeros}");
        }
    }
}
