using System;

public class Program {
    public static void Main() {
        int pares = 0, impares = 0;
        Console.WriteLine("Informe um número positivo ou um número negativo para sair:");
        
        do {
            int num = int.Parse(Console.ReadLine());
            if (num > 0) {
                if (num % 2 == 0) {
                    Console.WriteLine("O número {0} é par", num);
                    pares += num;
                }
                else {
                    Console.WriteLine("O número {0} é ímpar", num);
                    impares += num;
                }
            }
        } while (num >= 0);

        Console.WriteLine("A soma dos números pares é {0}", pares);
        Console.WriteLine("A soma dos números ímpares é {0}", impares);
    }
}
