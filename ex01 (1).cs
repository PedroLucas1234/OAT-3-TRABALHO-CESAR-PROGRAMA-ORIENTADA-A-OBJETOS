using System;
public class Program
{
    public static void Main()
    {
        Console.Write("QUANTIDADE MÍNIMA: ");
        int qtdMinima = int.Parse(Console.ReadLine());

        Console.Write("QUANTIDADE MÁXIMA: : ");
        int qtdMaxima = int.Parse(Console.ReadLine());

        double estoqueMedio = (qtdMinima + qtdMaxima) / 2.0;

        Console.WriteLine($"O ESTOQUE MÉDIO É: {estoqueMedio}");
    }
}
