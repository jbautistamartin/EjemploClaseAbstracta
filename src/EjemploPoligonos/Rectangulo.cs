namespace ejemploPoligonos
{
    internal class Rectangulo : Poligono
    {
        private int ancho;
        private int largo;

        public Rectangulo(int ancho, int largo) : base(4)
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        public int Ancho
        {
            get
            {
                return ancho;
            }

            private set
            {
                ancho = value;
            }
        }

        public int Largo
        {
            get
            {
                return largo;
            }

            private set
            {
                largo = value;
            }
        }

        public override double CalcularArea()
        {
            return ancho * largo;
        }
    }
}