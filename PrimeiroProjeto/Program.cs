using PrimeiroProjeto;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("entre os dados do produto:");
            Console.Write("nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto:" + p);

            // Segunda Parte

            Console.WriteLine();
            Console.Write("Digite o numero do produto a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados autualizados:" + p);



            Console.WriteLine();
            Console.Write("Digite o numero do produto a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine(); 
            // print dados atualizados
            Console.WriteLine("Dados autualizados:" + p);
            
        }
    }
}