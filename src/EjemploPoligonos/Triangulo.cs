using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPoligonos
{
    internal class Triangulo : Poligono
    {
        private int altura;
        private int tamanoBase;

        public Triangulo(int tamanoBase, int altura) : base(3)
        {
            this.tamanoBase = tamanoBase;
            this.altura = altura;
        }

        public int Base
        {
            get
            {
                return tamanoBase;
            }

            private set
            {
                tamanoBase = value;
            }
        }

        public int Altura
        {
            get
            {
                return altura;
            }

            private set
            {
                altura = value;
            }
        }


        public override double CalcularArea()
        {
            return (tamanoBase * altura) / 2;
        }
    }
}
