using System;

namespace Biblioteca
{
    public class BusinessException : Exception
    {
        public BusinessException(string mensaje) :base(mensaje)
        {
        }
    }
}
