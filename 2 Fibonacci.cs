using System;

/*
class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (VerificaSequenciaFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificaSequenciaFibonacci(int numero)
    {
        int fibo1 = 0, fibo2 = 1;

        if (numero == 0 || numero == 1)
            return true;

        while (fibo2 < numero)
        {
            int temp = fibo2;
            fibo2 = fibo1 + fibo2;
            fibo1 = temp;
        }

        return fibo2 == numero;
    }
}

*/



// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
//ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

//IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
