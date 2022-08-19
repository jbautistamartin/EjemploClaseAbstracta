namespace ejemploPoligonos
{
    internal abstract class Poligono : IArea
    {
        private int lados;

        public int Aristas
        {
            get
            {
                return lados;
            }
        }

        public int Lados
        {
            get
            {
                return lados;
            }

            private set
            {
                lados = value;
            }
        }

        public Poligono(int lados)
        {
            this.lados = lados;
        }

        public abstract double CalcularArea();
    }
}