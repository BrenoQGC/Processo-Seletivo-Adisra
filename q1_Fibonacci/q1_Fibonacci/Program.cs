using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class q1_Fibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Digite a posição desejada na sequência de Fibonacci: ");
        int posicao = int.Parse(Console.ReadLine());

        int fibonacci = Fibonacci(posicao);

        Console.WriteLine("O número correspondente à posição {0} na sequência de Fibonacci é  {1}.\n\n\n", posicao, fibonacci);
        Console.Write("Pressione qualquer tecla para sair... ");
        Console.ReadKey();
        ;
    }

    static int Fibonacci(int posicao)
    {
        if (posicao == 0)
        {
            return 0;
        }
        else if (posicao == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(posicao - 1) + Fibonacci(posicao - 2);
        }
    }
}