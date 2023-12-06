using System;

public class Program {
    public static void Main() {
        for (int i = 1; i <= 100; i++) {
            Console.Write(i + " ");
            if (i % 10 == 0) {
                Console.WriteLine("Múltiplo de 10");
            }
        }
        Console.ReadKey();
    }
}