using System;

namespace ejemploPoligonos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IArea r1 = new Rectangulo(2, 5);
            IArea c1 = new Cuadrado(8);
            IArea t1 = new Triangulo(10, 12);
            IArea pen1 = new Pentagono(2, 4);
            IArea cir1 = new Circulo(10);

            Console.WriteLine("El area es " + r1.CalcularArea());
            Console.WriteLine("El area es " + c1.CalcularArea());
            Console.WriteLine("El area es " + t1.CalcularArea());
            Console.WriteLine("El area es " + pen1.CalcularArea());
            Console.WriteLine("El area es " + cir1.CalcularArea());

            Figura figura1 = new Figura();

            figura1.Add(r1);
            figura1.Add(c1);
            figura1.Add(t1);

            Figura figura2 = new Figura();

            figura2.Add(pen1);
            figura2.Add(cir1);

            Figura figura3 = new Figura();

            figura3.Add(figura1);
            figura3.Add(figura2);

            Console.WriteLine("El area total es: " + figura3.CalcularArea());

            Console.ReadLine();
        }
    }
}