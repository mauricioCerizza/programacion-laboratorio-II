using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NewsletterEventArgs : EventArgs
    {
        private string contenido;

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

    }
}
