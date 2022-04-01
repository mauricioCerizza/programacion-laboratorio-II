using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanetaEventArgs : EventArgs
    {
        private short avance;

        public short Avance
        {
            get { return avance; }
        }

        private short radioRespectoSol;

        public short RadioRespectoSol
        {
            get { return radioRespectoSol; }
        }

        public PlanetaEventArgs(short avance, short radioRespectoSol)
        {
            this.avance = avance;
            this.radioRespectoSol = radioRespectoSol;
        }
    }
}
