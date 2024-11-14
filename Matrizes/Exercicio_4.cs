using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio_4
{
    static void diagonal_principal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);

        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"{matriz[i, i]} | ");
        }
        Console.WriteLine();
    }
    static void Main ()
    {
        int N, M;
        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas: ");
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());

        if (N == M) 
        {
            int[,] matrix = new int[N, M]; //criando
            Matriz.gera(matrix);
            Console.WriteLine("\nDados da matriz: \n");
            Matriz.mostra(matrix);
            Console.WriteLine("\nDados da diagonal principal (da esquerda p/ direita): \n");
            Exercicio_4.diagonal_principal(matrix);
        }
        else
        {
            Console.WriteLine("\nNÃO é possivel apresentar dados para essa dimensão.\n");
        }

        Console.ReadKey();
    }
}