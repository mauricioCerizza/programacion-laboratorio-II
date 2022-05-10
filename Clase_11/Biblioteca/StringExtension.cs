using System;
using System.Linq;

namespace Biblioteca
{
    public static class StringExtension
    {
        public static int ContarVocales(this string texto)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            return ContarCaracteres(texto, vocales);
        }

        public static int ContarCaracteres(this string texto, char caracter)
        {
            return ContarCaracteres(texto, new char[] {caracter});
        }

        private static int ContarCaracteres(string texto, char[] caracteres)
        {
            if (texto is null)
            {
                throw new BusinessException("El texto es nulo.");
            }

            texto = texto.ToLower();
            int contador = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
