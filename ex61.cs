using System;

public class Program
{
    public static double REAJUSTE(double salario, double indice)
    {
        double newSalario = salario * (1 + indice / 100);
        return newSalario;
    }

    public static void Main()
    {
        Console.Write("Informe o valor do salário atual: ");
        double salarioAtual = double.Parse(Console.ReadLine());

        Console.Write("Informe o índice de reajuste (em %): ");
        double indiceReajuste = double.Parse(Console.ReadLine());

        double newSalario = REAJUSTE(salarioAtual, indiceReajuste);

        Console.WriteLine("O novo salário é R$ {0:F2}", newSalario);
    }
}