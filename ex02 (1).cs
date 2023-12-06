using System;
public class Program 
{
    public static void Main() 
    {
        Console.Write("Informe a cotação do Dólar: ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor em dólares: ");
        double valorDolar = double.Parse(Console.ReadLine());

        double valorReal = valorDolar * cotacao;

        Console.WriteLine("O valor em reais é: " + valorReal);
    }
}
