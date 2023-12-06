using System;

public class Program {
  public static void Main() {
    double pi = 3.14159;

    Console.Write("Digite o raio da base da lata de óleo: ");
    double raio = double.Parse(Console.ReadLine());

    Console.Write("Digite a altura da lata de óleo: ");
    double h = double.Parse(Console.ReadLine());

    double v = pi * Math.Pow(raio, 2) * h;

    Console.WriteLine("O volume da lata de óleo é: " + v.ToString("F2"));
  }
}
