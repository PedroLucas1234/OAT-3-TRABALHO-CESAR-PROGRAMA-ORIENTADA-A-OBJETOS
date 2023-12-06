using System;

public class Program {
  public static void Main() {
    Console.Write("Digite 2 caracteres [EM ORDEM ALFABÉTICA] ");
    string entrada = Console.ReadLine();

    if (entrada.Length != 2 || entrada[0] >= entrada[1]) {
      Console.WriteLine("ERRO: caracteres inválidos.");
      return;
    }

    int numeroDeCaracteres = entrada[1] - entrada[0] - 1;

    Console.WriteLine("O número de caracteres entre os dois é: " + numeroDeCaracteres);
  }
}