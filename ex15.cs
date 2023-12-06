using System;

public class Program {
    public static void Main() {
        Console.Write("Informe a primeira nota: ");
        double nt1 = double.Parse(Console.ReadLine());

        Console.Write("Informe a segunda nota: ");
        double nt2 = double.Parse(Console.ReadLine());

        Console.Write("Informe a terceira nota: ");
        double nt3 = double.Parse(Console.ReadLine());

        Console.Write("Informe a quarta nota: ");
        double nt4 = double.Parse(Console.ReadLine());

        double media = (nt1 + nt2 + nt3 + nt4) / 4.0;

        if (media >= 7.0) {
            Console.WriteLine($"O aluno foi aprovado com média {media:F2}");
        } else {
            Console.Write("Informe a nota da recuperação: ");
            double notaRecuperacao = double.Parse(Console.ReadLine());

            double novaMedia = (media + notaRecuperacao) / 2.0;

            if (novaMedia >= 7.0) {
                Console.WriteLine($"O aluno foi aprovado na recuperação com média {novaMedia:F2}");
            } else {
                Console.WriteLine($"O aluno não foi aprovado, média final {novaMedia:F2}");
            }
        }
    }
}