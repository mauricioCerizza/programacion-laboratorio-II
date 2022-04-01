using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorArchivosException : Exception
    {
        public ErrorArchivosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ErrorArchivosException(string message) : base(message)
        {
        }
    }
}
