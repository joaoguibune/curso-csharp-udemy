using System;
using System.Globalization;

namespace CadastroSimplesDeProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            Fornecedor f;
            int qtd;
            f = new Fornecedor("Samsung", "samsung@samsung.com", "(41) 99999-9999");

            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Preco:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque:");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            p = new Produto(nome, preco, f);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("");

            Console.WriteLine("Digite a quantidade de produtos que entraram em estoque:");
            qtd = int.Parse(Console.ReadLine());

            p.realizarEntrada(qtd);

            Console.WriteLine("Produto atualizado: " + p);

            Console.WriteLine("");


            Console.WriteLine("Digite a quantidade de produtos que sairam do estoque");
            qtd = int.Parse(Console.ReadLine());

            p.realizarSaida(qtd);

            Console.WriteLine("Produto atualizado: " + p);


            Console.ReadLine();


        }
    }
}
