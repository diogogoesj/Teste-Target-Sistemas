/*
 5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
 */

namespace TesteTarget05;

class Teste05
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();

        Console.WriteLine(Inverter(input));

    }

    public static string Inverter(string str)
    {
        string resultado = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            resultado += str[i];
        }
        return resultado;
    }
}

