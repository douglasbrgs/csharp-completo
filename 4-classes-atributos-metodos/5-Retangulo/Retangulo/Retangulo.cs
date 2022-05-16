﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Retangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "AREA = " +
                Area().ToString("F2", CultureInfo.InvariantCulture) +
                "\nPERIMETRO = " +
                Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
                "\nDIAGONAL = " +
                Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}