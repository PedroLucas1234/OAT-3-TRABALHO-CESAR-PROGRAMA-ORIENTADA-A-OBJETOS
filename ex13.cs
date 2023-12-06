using System;

public class Program {
    public static void Main() {
        Console.WriteLine("Digite três números inteiros:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int maior, segundoMaior, menor;

        if (a >= b && a >= c) {
            maior = a;
            if (b >= c) {
                segundoMaior = b;
                menor = c;
            } else {
                segundoMaior = c;
                menor = b;
            }
        } else if (b >= a && b >= c) {
            maior = b;
            if (a >= c) {
                segundoMaior = a;
                menor = c;
            } else {
                segundoMaior = c;
                menor = a;
            }
        } else {
            maior = c;
            if (a >= b) {
                segundoMaior = a;
                menor = b;
            } else {
                segundoMaior = b;
                menor = a;
            }
        }
        
        Console.WriteLine(maior + " " + segundoMaior + " " + menor);
    }
}