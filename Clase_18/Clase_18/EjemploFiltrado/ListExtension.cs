using System;
using System.Collections.Generic;

namespace Clase_18
{
    public static class ListExtension
    {
        //public static List<T> Filtrar<T>(this List<T> lista, Func<T, bool> criterioDeFiltrado)
        //{
        //    List<T> listaFiltrada = new List<T>();
        //    foreach (T item in lista)
        //    {
        //        if (criterioDeFiltrado(item))
        //        {
        //            listaFiltrada.Add(item);
        //        }
        //    }

        //    return listaFiltrada;
        //}

        public static List<T> Filtrar<T>(this List<T> lista, Predicate<T> criterioDeFiltrado)
        {
            List<T> listaFiltrada = new List<T>();
            foreach (T item in lista)
            {
                if (criterioDeFiltrado(item))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

        //public static List<T> Filtrar<T>(this List<T> lista, DelegadoCriterio<T> criterioDeFiltrado)
        //{
        //    List<T> listaFiltrada = new List<T>();
        //    foreach (T item in lista)
        //    {
        //        if (criterioDeFiltrado(item))
        //        {
        //            listaFiltrada.Add(item);
        //        }
        //    }

        //    return listaFiltrada;
        //}
    }
}
