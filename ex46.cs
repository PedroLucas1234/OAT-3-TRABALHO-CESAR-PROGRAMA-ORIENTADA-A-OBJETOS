using System;

public class Program
{
    public static void Main()
    {

        int[] x = { 1, 2, 3 };
        int[] y = { 4, 5, 6 };
        int n = x.Length; 

        int produto = 0;
        for (int i = 0; i < n; i++)
        {
            produto += x[i] * y[i];
        }

        Console.WriteLine("O produto escalar entre x e y é " + produto);
    }
}