using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Repaso
{
    public class Bar
    {
        private List<Gente> gente;
        private List<Empleado> empleados;
        private static Bar singleton;

        public List<Gente> Gente
        {
            get
            {
                return gente;
            }
        }

        public List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }
        }

        private Bar()
        {
            this.gente = new List<Gente>();
            this.empleados = new List<Empleado>();
        }

        public static Bar GetBar()
        {
            if (Bar.singleton is null)
            {
                Bar.singleton = new Bar();
            }

            return Bar.singleton;
        }

        public static bool operator + (Bar bar, Empleado empleado)
        {
            bar.empleados.Add(empleado);
            return true;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            if (bar.gente.Count < bar.empleados.Count * 10)
            {
                bar.gente.Add(gente);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Cantidad empleados: {this.empleados.Count} Cantidad gente: {this.gente.Count}";
        }
    }
}