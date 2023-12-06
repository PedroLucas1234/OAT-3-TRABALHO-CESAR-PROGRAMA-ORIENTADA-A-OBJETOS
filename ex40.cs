using System;

public class Program
{
  public static void Main()
  {
    double indPoluicao;
    char continuar;

    do
    {
      Console.WriteLine("Digite o índice de poluição medido:");
      indPoluicao = double.Parse(Console.ReadLine());

      if (indPoluicao >= 0.05 && indPoluicao <= 0.25)
      {
        Console.WriteLine("Índice aceitável!");
      }
      else if (indPoluicao > 0.25 && indPoluicao < 0.3)
      {
        Console.WriteLine("Indústrias do 1 grupo devem suspender suas atividades.");
      }
      else if (indPoluicao >= 0.3 && indPoluicao < 0.4)
      {
        Console.WriteLine("Indústrias do 1 e 2 grupo devem suspender suas atividades.");
      }
      else if (indPoluicao >= 0.4 && indPoluicao < 0.5)
      {
        Console.WriteLine("Indústrias do 1 2 3 grupo devem suspender suas atividades.");
      }
      else if (indPoluicao >= 0.5)
      {
        Console.WriteLine("Todas as indústrias devem suspender suas atividades.");
      }

      Console.WriteLine("Deseja encerrar o programa? [S/N]");
      continuar = char.Parse(Console.ReadLine());
    } while (continuar != 'S' && continuar != 's');
  }
}