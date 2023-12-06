using System;

public class Program {
  public static void Main() {
    Random random = new Random();
    int numeroSorteado = random.Next(101);
    int tentativas = 0;
    int tentativaUsuario;
    bool acertou = false;

    Console.WriteLine("Tente adivinhar o número sorteado [0 - 100]");
    while (!acertou) {
      Console.Write("Digite sua tentativa: ");
      tentativaUsuario = int.Parse(Console.ReadLine());
      tentativas++;

      if (tentativaUsuario == numeroSorteado) {
        acertou = true;
        Console.WriteLine("Parabéns, você acertou em {0} tentativas!", tentativas);
      }
      else {
        Console.WriteLine("Tente novamente! O número sorteado é {0}.", 
                          tentativaUsuario < numeroSorteado ? "maior" : "menor");
      }
    }
  }
}