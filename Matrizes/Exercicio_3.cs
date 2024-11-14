using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio_3
{
    static void repeticao(int[,] matriz, int X)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int cont = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] == X)
                {
                    cont++;
                }
            }//fim for j  
        }//fim for i
        
        Console.Write(cont);
    }
    static void Main()
    {
        int N, M;
        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas: ");
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M]; //criando
        
        int X;
        Console.WriteLine("Escolha um número para vermos quantas vezes ele se repete na matriz: ");
        X = int.Parse(Console.ReadLine());

        Matriz.gera(matrix);
        Console.WriteLine("\nDados da matriz: \n");
        Matriz.mostra(matrix);

        Console.WriteLine($"\nO número {X} aparece ");
        Exercicio_3.repeticao (matrix, X);
        Console.Write(" vezes. ");

        Console.ReadKey();
    }
}