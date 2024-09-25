/*
 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
*/

namespace TesteTarget02;

class Teste02
{
    public static void Main(string[] args)
    {

        int input;

        Console.WriteLine("Pressione \"Esc\" para encerrar");

        while (true)
        {

            Console.WriteLine("Digite um número inteiro: ");
            input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input; ++i)
            {
                Console.WriteLine(Fibonacci(i));
            }


            var teclaPressionada = Console.ReadKey(true);

            if (teclaPressionada.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\n Programa encerrado");
                break;

            }
        }


    }
    public static int Fibonacci(int n)
    {
        if (n <= 1) { return n; }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

}


