using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                return double.MinValue;
            }

            return dividendo/divisor;
        }
    }
}
