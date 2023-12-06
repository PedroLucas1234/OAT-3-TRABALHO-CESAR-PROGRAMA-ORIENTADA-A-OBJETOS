using System;

public class Program {
    public static void Main() {
        Console.Write("Informe a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Informe a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Informe a idade em dias: ");
        int dias = int.Parse(Console.ReadLine());

        int idadeEmDias = (anos * 365) + (meses * 30) + dias;

        Console.WriteLine($"A idade em dias é: {idadeEmDias}");
    }
}