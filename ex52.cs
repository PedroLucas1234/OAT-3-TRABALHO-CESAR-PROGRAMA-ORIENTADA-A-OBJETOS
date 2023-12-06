using System;

public class Program {
    public static void Main() {
        Console.Write("Qtd de alunos: ");
        int qtd = int.Parse(Console.ReadLine());

        double[] notas = new double[qtd];
        double soma = 0.0;

        for (int i = 0; i < qtd; i++) {
            Console.Write($"Nota do aluno {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma += notas[i];
        }

        double media = soma / qtd;
        Console.WriteLine($"Média aritmética: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        int acimaSete = 0;
        for (int i = 0; i < qtd; i++) {
            if (notas[i] > 7.0) {
                acimaSete++;
            }
        }

        if (acimaSete > 0) {
            Console.WriteLine($"Alunos com nota acima de 7.0: {acimaSete}");
        } else {
            Console.WriteLine("Não há nenhum aluno com nota acima de 7.0");
        }
    }
}