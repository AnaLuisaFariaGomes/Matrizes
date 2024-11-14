using System;
using System.Data.Common;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio_5
{
    static void diagonal_secun(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int j = linhas - 1;

        for (int i = 0; i < linhas; i++,j--)
        {
            Console.Write($"{matriz[i, j]} | ");
        }
        Console.WriteLine();
    }
    static void Main()
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
            Console.WriteLine("\nDados da diagonal secundaria (da direita p/ esquerda): \n");
            Exercicio_5.diagonal_secun(matrix);
        }
        else
        {
            Console.WriteLine("\nNÃO é possivel apresentar dados para essa dimensão.\n");
        }

        Console.ReadKey();
    }
}