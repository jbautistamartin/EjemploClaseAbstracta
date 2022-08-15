using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPoligonos
{
    class Pentagono : Poligono
    {
        private int longitud;
        private int apotema;
        
        public Pentagono (int longitud, int apotema) : base(5)
        {
            this.longitud = longitud;
            this.apotema = apotema;
        }

        public int Longitud
        {
            get
            {
                return longitud;
            }

            private set
            {
                longitud = value;
            }
        }

        public int Apotema
        {
            get
            {
                return apotema;
            }

            private set
            {
                apotema = value;
            }
        }
        public override double CalcularArea()
        {
            return ((5 * longitud) * apotema) / 2;
        }
    }
}
