using System;

public class Program {
  public static void Main() {

    Console.Write("Informe o primeiro número: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.Write("Informe o segundo número: ");
    int n2 = int.Parse(Console.ReadLine());

    if (n1 == n2) {
      Console.WriteLine("Igual");
    }
    else {
      Console.WriteLine("Não igual");
      if (n1 > n2) {
        Console.WriteLine("Maior");
        Console.WriteLine("Maior ou igual");
        Console.WriteLine("Menor");
        Console.WriteLine("Menor ou igual");
      }
      else {
        Console.WriteLine("Menor");
        Console.WriteLine("Menor ou igual");
        Console.WriteLine("Maior");
        Console.WriteLine("Maior ou igual");
      }
    }
  }
}