using System.Text;

namespace Entidades
{
    public interface IFiles<T>
    {
        void Guardar(string nombreArchivo, T objeto);
        void Guardar(string nombreArchivo, T objeto, Encoding encoding);
        bool Leer(string nombreArchivo, out T objeto);
        bool Leer(string nombreArchivo, out T objeto, Encoding encoding);
    }
}
