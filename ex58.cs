using System;
public class Program
{
  public static void Main()
  {
    Console.Write("Informe a quantidade de números a serem lidos: ");
    int qtd = int.Parse(Console.ReadLine());

    int[] numeros = new int[qtd];

    for (int i = 0; i < qtd; i++)
    {
      Console.Write($"Digite o {i + 1} número: ");
      numeros[i] = int.Parse(Console.ReadLine());
    }

    int soma = 0;
    for (int i = 0; i < qtd; i++)
    {
      soma += numeros[i];
    }
    double media = (double)soma / qtd;

    int maior = numeros[0];
    for (int i = 1; i < qtd; i++)
    {
      if (numeros[i] > maior)
      {
        maior = numeros[i];
      }
    }
    Console.WriteLine($"A média é {media:F2}");
    Console.WriteLine($"O maior número é {maior}");
  }
}
