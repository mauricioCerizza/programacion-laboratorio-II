using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private Vacuna[] vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void AgregarVacuna(Vacuna vacuna)
        {
            if (this.vacunas is null)
            {
                this.vacunas = new Vacuna[1];
            }
            else
            {
                int nuevaCapacidad = this.vacunas.Length + 1;
                Array.Resize(ref this.vacunas, nuevaCapacidad);
            }

            for (int i = 0; i < this.vacunas.Length; i++)
            {
                if (this.vacunas[i] is null)
                {
                    this.vacunas[i] = vacuna;
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"Nombre: {this.nombre}, Especie: {this.especie}, Fecha Nacimiento: {this.fechaNacimiento.ToShortDateString()}\n";

            if (this.vacunas != null)
            {
                retorno += "Vacunas: \n";
                foreach (Vacuna vacuna in this.vacunas)
                {
                    if (vacuna != null)
                    {
                        retorno += vacuna.ObtenerNombre();
                    }
                }
            }
            return retorno;
        }
    }
}
