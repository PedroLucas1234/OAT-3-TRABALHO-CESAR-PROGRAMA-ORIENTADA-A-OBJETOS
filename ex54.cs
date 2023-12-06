using System;
public class Program
{
  public static void Main()
  {
    int[] A = { 1, 2, 3, 4, 5 };
    int[] B = { 4, 5, 6, 7, 8, 9, 10, 11 };

    for (int i = 0; i < A.Length; i++)
    {
      for (int j = 0; j < B.Length; j++)
      {
        if (A[i] == B[j])
        {
          Console.WriteLine(A[i]);
        }
      }
    }
  }
}