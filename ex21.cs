using System;

public class Program {
    public static void Main() {
        bool cont = true;

        while (cont) {
            Console.Write("Digite um número inteiro [DIGITE 0 PARA SAIR]: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0) {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0) {
                Console.WriteLine("O número é negativo.");
            }
            else {
                cont = false;
            }
        }
    }
}