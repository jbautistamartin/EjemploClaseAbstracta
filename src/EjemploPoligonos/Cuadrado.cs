namespace ejemploPoligonos
{
    internal class Cuadrado : Rectangulo
    {
        public int TamanoLado
        {
            get
            {
                return Largo;
            }
        }

        public Cuadrado(int tamanoLado) : base(tamanoLado, tamanoLado)
        {
        }
    }
}