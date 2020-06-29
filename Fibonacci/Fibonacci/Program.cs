using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

/*# Fibonacci

Retorna uma lista `List<decimal>` com os primeiros números de* Fibonacci* até *350*.

Faça um segundo método `IsFibonnaci` que recebe um parâmetro e retorne `bool`.
Caso o número recebido por parâmetro esteja entre os números da sequência de* Fibonnaci* do `Fibonnaci` retorne `true`, senão, `false`.*/
namespace Fibonacci
{
    class Program
    {
        public const decimal LimitFibonacciSequence = 350;

        static void Main(string[] args)
        {

            List<decimal> fibonacciSequence = Fibonacci();

            for (int i = 0; i < fibonacciSequence.Count; i++)
            {
                Console.WriteLine($"posicao: {i} => {fibonacciSequence[i]}");
            }

            Console.WriteLine($"{IsFibonacci(4)}");

        }
                
        public static List<decimal> Fibonacci()
        {

            List<decimal> fibonacciSequence = new List<decimal>() { 0, 1 };
            int position = 1;
            decimal nextValue = 0;

            do
            {
                decimal previousValue = fibonacciSequence[position - 1];
                decimal currentValue = fibonacciSequence[position];
                nextValue = currentValue + previousValue;

                if (nextValue > LimitFibonacciSequence)
                    break;

                fibonacciSequence.Add(nextValue);
                position++;
            } while (nextValue < LimitFibonacciSequence);

            return fibonacciSequence;
        }

        public static bool IsFibonacci(decimal numberToTest)
        {
            return Fibonacci().Contains(numberToTest);
        }
    }
}
