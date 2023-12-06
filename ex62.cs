using System;

public class Program
{
    public static void Main()
    {
        double bTriangulo, aTriangulo;
        Console.Write("Digite o valor da base do triângulo: ");
        bTriangulo = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor da altura do triângulo: ");
        aTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine($"A hipotenusa do triângulo é {Hipotenusa(bTriangulo, aTriangulo):F2}");
    }

    public static double Hipotenusa(double bTriangulo, double aTriangulo)
    {
        double hipotenusa = Math.Sqrt(Math.Pow(bTriangulo, 2) + Math.Pow(aTriangulo, 2));
        return hipotenusa;
    }
}