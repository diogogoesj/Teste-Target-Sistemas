/*
4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
• SP – R$67.836,43
• RJ – R$36.678,66
• MG – R$29.229,88
• ES – R$27.165,48
• Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total 
mensal da distribuidora.  
 */

namespace TesteTarget04;

class Teste04
{
    public static void Main(string[] args)
    {

        const double Sp = 67836.43, Rj = 36678.66, Mg = 29229.88, Es = 27165.48, Outros = 19849.53;

        double total = Sp + Rj + Mg + Es + Outros;

        Console.WriteLine("Percentual de representação por estado:");

        double percentual = (Sp / total ) * 100;
        Console.WriteLine($"SP: {percentual:F2}%");

        percentual = (Rj / total) * 100;
        Console.WriteLine($"RJ: {percentual:F2}%");

        percentual = (Mg / total) * 100;
        Console.WriteLine($"MG: {percentual:F2}%");

        percentual = (Es / total) * 100;
        Console.WriteLine($"ES: {percentual:F2}%");

        percentual = (Outros / total) * 100;
        Console.WriteLine($"Outros: {percentual:F2}%");
    }

}
