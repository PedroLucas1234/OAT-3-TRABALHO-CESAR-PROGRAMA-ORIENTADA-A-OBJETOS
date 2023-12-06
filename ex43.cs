using System;

public class Program {
  public static void Main() {
    int numQuadros = 64;
    double numGraos = Math.Pow(2, numQuadros) - 1;

    Console.WriteLine($"O ESPERAVA RECEBER " + numGraos + " GRÃOS DE TRIGO");
  }
}