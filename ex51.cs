using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Quantidade de alunos: ");
        int n = int.Parse(Console.ReadLine());

        double[] notas = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nota do aluno {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double media = 0;
        int acimaDeSete = 0;

        foreach (double nota in notas)
        {
            media += nota;

            if (nota > 7.0)
            {
                acimaDeSete++;
            }
        }

        media /= n;

        Console.WriteLine($"Média das notas: {media:F2}");

        if (acimaDeSete == 0)
        {
            Console.WriteLine("Não há nenhum aluno com nota acima de 7.0");
        }
        else
        {
            Console.WriteLine($"Alunos com nota acima de 7.0: {acimaDeSete}");
        }
    }
}