using System;

namespace Comissao
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Informe a identificação do vendedor: ");
            int vendedor = int.Parse(Console.ReadLine());

            Console.Write("Informe o código da peça: ");
            int codPeca = int.Parse(Console.ReadLine());

            Console.Write("Informe o preço unitário da peça: ");
            double precoPeca = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade vendida: ");
            int qtdvendida = int.Parse(Console.ReadLine());

            double totalVenda = precoPeca * qtdeVendida;
            double comissao = totalVenda * 0.05;

            Console.WriteLine("Vendedor: " + vendedor);
            Console.WriteLine("Código da peça: " + codPeca);
            Console.WriteLine("Preço unitário da peça: R$ " + precoPeca.ToString("F2"));
            Console.WriteLine("Quantidade vendida: " + qtdeVendida);
            Console.WriteLine("Total da venda: R$ " + totalVenda.ToString("F2"));
            Console.WriteLine("Comissão: R$ " + comissao.ToString("F2"));
        }
    }
}