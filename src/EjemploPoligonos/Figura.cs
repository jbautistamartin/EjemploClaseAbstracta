using System.Collections.Generic;

namespace ejemploPoligonos
{
    internal class Figura : List<IArea>, IArea
    {
        public double CalcularArea()
        {
            double areaTotal = 0;
            foreach (IArea area in this)
            {
                //areaTotal = areaTotal + area.CalcularArea();
                areaTotal += area.CalcularArea();
            }

            return areaTotal;
        }
    }
}