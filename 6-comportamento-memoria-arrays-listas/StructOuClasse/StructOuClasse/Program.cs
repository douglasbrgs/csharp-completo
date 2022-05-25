using System;

namespace StructOuClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRUCT
            ObjetoStruct triangulo;
            triangulo.Cor = "Amarela";

            UtilStruct utilStruct = new UtilStruct();
            utilStruct.MudarCorParaAzul(triangulo);

            Console.WriteLine(triangulo);

            // CLASSE
            ObjetoClasse retangulo = new ObjetoClasse();
            retangulo.Cor = "Amarela";

            UtilClasse utilClasse = new UtilClasse();
            utilClasse.MudarCorParaAzul(retangulo);

            Console.WriteLine(retangulo);

            /* A cor não muda ao usar STRUCT pois o que é passado para a Util é uma cópia do objeto
             * e não a referência do objeto já existente (como ocorre ao usar CLASSE)
            */
        }
    }
}
