using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        private double media = 60;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            return NotaFinal() >= media;
        }

        public double NotaFaltante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return media - NotaFinal();
            }
        }
    }
}
