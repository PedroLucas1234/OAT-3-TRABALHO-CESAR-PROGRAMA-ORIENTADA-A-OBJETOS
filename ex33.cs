using System;

public class Aluno {
    public int matric;
    public double nota;

    public Aluno(int matric, double nota) {
        this.matric = matric;
        this.nota = nota;
    }
}

public class Program {
    public static void Main() {
        double sNotas = 0;
        int contadorAlunos = 0;

        while (true) {
            Console.Write("Informe a matrícula do aluno (ou um número negativo para sair): ");
            int matric = int.Parse(Console.ReadLine());

            if (matric < 0) {
                break;
            }

            Console.Write("Informe a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(matric, nota);
            sNotas += nota;
            contadorAlunos++;
        }

        double mediaNotas = sNotas / contadorAlunos;

        Console.WriteLine("Média das notas dos alunos: " + mediaNotas);
    }
}
