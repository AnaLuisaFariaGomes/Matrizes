using System;
using Biblioteca_Matriz;
class Program
{
    static void Main ()
    {
        int linhas, colunas;
        Console.WriteLine("*** Matrizes ***");
        Console.WriteLine("Quantidade de linhas e colunas: ");
        linhas = int. Parse(Console.ReadLine());
        colunas = int. Parse(Console.ReadLine());
        int[,] matrix = new int[linhas, colunas]; //criando

        //Console.WriteLine("Entre com os dados para a matriz: ");
        Matriz.gera(matrix);
        Console.WriteLine("Dados da matriz: ");
        Matriz.mostra(matrix);

        Console.ReadKey();
    }
}