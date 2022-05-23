using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //int quantidade = 0;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade no estoque: ");
            //int quantidadeInicial = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco);

            // Get e Set
            //produto.SetNome("TV 4K");
            //Console.WriteLine(produto.GetNome());
            //Console.WriteLine("Preço: " + produto.GetPreco());
            //Console.WriteLine("Quantidade: " + produto.GetQuantidade());

            // properties
            produto.Nome = "T";
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);


            // sintaxe alternativa para inicializacao
            //Produto produto2 = new Produto
            //{
            //    Nome = "TV",
            //    Preco = 500.00,
            //    Quantidade = 20
            //};

            //Console.WriteLine();
            //Console.WriteLine("Produto 2: " + produto2);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //quantidade = int.Parse(Console.ReadLine());
            //produto.AdicionarProdutos(quantidade);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + produto);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //quantidade = int.Parse(Console.ReadLine());
            //produto.RemoverProdutos(quantidade);


            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
