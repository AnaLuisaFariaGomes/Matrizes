using System;
using System.IO;
using System.Numerics;
using Biblioteca_Matriz;

class Exercicio_2
{
    static int menor(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int menor_valor = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < menor_valor)
                {
                    menor_valor = matriz[i, j];
                }
            }//fim for j  
        }//fim for i

        return menor_valor;
    }
    static void Main()
    {
        int N, M;
        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas: ");
        N = int.Parse(Console.ReadLine());
        M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M]; //criando

        Matriz.gera(matrix);
        Console.WriteLine("\nDados da matriz: \n");
        Matriz.mostra(matrix);

        Console.Write(Exercicio_2.menor(matrix));

        Console.ReadKey();
    }
}
