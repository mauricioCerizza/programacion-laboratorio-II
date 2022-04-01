using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private Mascota[] mascotas;

        /// <summary>
        /// Se llama igual que la clase.
        /// </summary>
        public Cliente(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void AgregarMascota(Mascota mascota)
        {
            if (this.mascotas is null)
            {
                this.mascotas = new Mascota[1];
            }
            else
            {
                int nuevaCapacidad = this.mascotas.Length + 1;
                Array.Resize(ref this.mascotas, nuevaCapacidad);
            }

            for (int i = 0; i < this.mascotas.Length; i++)
            {
                if (this.mascotas[i] is null)
                {
                    this.mascotas[i] = mascota;
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"Nombre: {this.nombre} {this.apellido}\n";

            if (this.mascotas != null)
            {
                retorno += "Mascotas: \n";
                foreach (Mascota mascota in this.mascotas)
                {
                    if (mascota != null)
                    {
                        retorno += mascota.MostrarDatos();
                    }
                }
            }
            return retorno;
        }
    }
}
