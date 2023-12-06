using System;

public class Program {
  public static int VERIFICA_QUADRANTE(int x, int y) {
    if (x > 0 && y > 0) {
      return 1;
    } else if (x < 0 && y > 0) {
      return 2;
    } else if (x < 0 && y < 0) {
      return 3;
    } else if (x > 0 && y < 0) {
      return 4;
    } else {
      return 0; 
    }
  }

  public static void Main() {
    Console.Write("Informe o valor de x: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Informe o valor de y: ");
    int y = int.Parse(Console.ReadLine());

    int quadrante = VERIFICA_QUADRANTE(x, y);

    if (quadrante > 0) {
      Console.WriteLine("O ponto ({0}, {1}) está no quadrante {2}", x, y, quadrante);
    } else if (quadrante == 0) {
      Console.WriteLine("O ponto ({0}, {1}) está na origem", x, y);
    } else {
      Console.WriteLine("Erro: as coordenadas não podem ser iguais a zero simultaneamente.");
    }
  }
}