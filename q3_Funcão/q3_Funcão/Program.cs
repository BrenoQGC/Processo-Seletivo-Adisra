
using System;
/*
        int ff(int n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0) return ff(n / 2);
            return ff((n - 1) / 2) + ff((n + 1) / 2);
        }
        void main()
        {
            printf("%d", ff(7));
            return;
        }



         * O programa apresenta uma função recursiva que recebe um número n como entrada e retorna um valor inteiro. 
        O programa executa cálculos recursivos a partir de n verificando se n é igual a 1 ou par. Se n for igual a 1, a função retorna 1. 
        Se n for par, a função chama recursivamente a si mesma com n dividido por 2 como entrada. 
        Se n for ímpar, a função chama recursivamente a si mesma com (n-1)/2 e (n+1)/2 como entradas, e retorna a soma dos valores retornados por essas chamadas recursivas.
 
        Portanto, ao executar ff(7), o programa retorna o valor 3.
*/

class Program
{
    static int ff(int n)
    {
        if (n == 1) return 1;
        if (n % 2 == 0) return ff(n / 2);
        return ff((n - 1) / 2) + ff((n + 1) / 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ff(7));
        return;
    }
}
