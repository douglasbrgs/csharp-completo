using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoMoeda
{
    class ConversorMoeda
    {
        private static double Iof = 6.0;

        public static double DolarParaReal(double cotacao, double quantia)
        {
            double montanteDolar = cotacao * quantia;
            return montanteDolar + montanteDolar * Iof / 100.0;
        }

    }
}
