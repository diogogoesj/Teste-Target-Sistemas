/* 
 * 1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA? 

R: 91 */


namespace TesteTarget;

class Teste01
{
    public static void Main(string[] args)
    {
        int indice = 13, soma = 0, k = 0;

        for (int i = 0; k < indice; i++)
        {
            k += 1;
            soma += k;
            Console.WriteLine(soma);
        }
    }
}