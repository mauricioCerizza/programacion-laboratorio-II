using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Veterinaria
    {
        private List<Mascota> mascotas;

        public List<Mascota> Mascotas
        {
            get { return mascotas; }
        }

        public Veterinaria()
        {
            mascotas = new List<Mascota>();
        }

        public void AddMascota(Mascota mascota)
        {
            this.mascotas.Add(mascota);
        }
    }
}
