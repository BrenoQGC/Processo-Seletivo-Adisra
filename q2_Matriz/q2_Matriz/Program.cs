using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = GerarMatriz();
        ImprimirMatriz(matriz);

        int quantidadePares = 0;
        int quantidadeImpares = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    quantidadePares++;
                }
                else
                {
                    quantidadeImpares++;
                }
            }
        }

        string mensagem;

        if (quantidadePares > quantidadeImpares)
        {
            mensagem = "A matriz tem mais números pares do que ímpares.";
        }
        else if (quantidadeImpares > quantidadePares)
        {
            mensagem = "A matriz tem mais números ímpares do que pares.";
        }
        else
        {
            mensagem = "A matriz tem a mesma quantidade de números pares e ímpares.";
        }

        Console.WriteLine("\n\n" + mensagem);

        Console.WriteLine("\n\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static int[,] GerarMatriz()
    {
        Random random = new Random();
        int linhas = random.Next(2, 6);
        int colunas = random.Next(2, 6);

        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = random.Next(1, 101);
            }
        }

        return matriz;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("Matriz gerada:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("{0,3} ", matriz[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
