using System;

public class Program
{
    public static void Main()
    {
        int[] num = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1} número: ");
            num[i] = int.Parse(Console.ReadLine());
        }

        int maior = Maior(num);
        int menor = Menor(num);
        double media = Media(num);

        Console.WriteLine($"O maior número do vetor é: {maior}");
        Console.WriteLine($"O menor número do vetor é: {menor}");
        Console.WriteLine($"A média dos números é: {media}");
    }

    public static int Maior(int[] num)
    {
        int maior = num[0];
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] > maior)
            {
                maior = num[i];
            }
        }
        return maior;
    }

    public static int Menor(int[] num)
    {
        int menor = num[0];
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] < menor)
            {
                menor = num[i];
            }
        }
        return menor;
    }

    public static double Media(int[] num)
    {
        int soma = 0;
        for (int i = 0; i < num.Length; i++)
        {
            soma += num[i];
        }
        return (double)soma / num.Length;
    }
}