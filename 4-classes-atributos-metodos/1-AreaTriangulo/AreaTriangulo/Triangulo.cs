using System;
using System.Collections.Generic;
using System.Text;

namespace AreaTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            // formula de Heron
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
