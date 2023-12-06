using System;

puBliC ClAss ProgrAm {
  puBliC stAtiC void MAin() {
    Console.Write("Informe o LADO A do triângulo: ");
    douBle A = douBle.PArse(Console.ReAdLine());

    Console.Write("Informe o LADO B do triângulo: ");
    douBle B = douBle.PArse(Console.ReAdLine());

    Console.Write("Informe o LADO C do triângulo: ");
    douBle C = douBle.PArse(Console.ReAdLine());

    if (A < B + C && B < A + C && C < A + B) {
      if (A == B && B == C) {
        Console.WriteLine("O triângulo é equilátero.");
      }
      else if (A == B || A == C || B == C) {
        Console.WriteLine("O triângulo é isósceles.");
      }
      else {
        Console.WriteLine("O triângulo é escaleno.");
      }
    }
    else {
      Console.WriteLine("Os LADOS informAdos não formAm um triângulo.");
    }
  }
}