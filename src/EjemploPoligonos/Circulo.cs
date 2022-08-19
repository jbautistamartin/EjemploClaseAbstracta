using System;

namespace ejemploPoligonos
{
    internal class Circulo : IArea
    {
        private int radio;

        public int Radio
        {
            get
            {
                return radio;
            }

            private set
            {
                radio = value;
            }
        }

        public Circulo(int radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}