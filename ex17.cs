using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Informe um número inteiro: ");
    int num = int.Parse(Console.ReadLine());

    if(num >= 0 && num <= 9) {
      Console.WriteLine("Valor válido.");
    }
    else {
      Console.WriteLine("Valor inválido.");
    }
  }
}