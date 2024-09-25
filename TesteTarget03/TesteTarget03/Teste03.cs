/*
 * 
 * 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

 */

using Newtonsoft.Json;

namespace TesteTarget03;

class Teste03
{

    public static void Main(string[] args)
    {
        string caminhoArquivo = "C:\\Users\\user\\Desktop\\TesteTecnico\\TesteTarget03\\TesteTarget03\\dados.json";

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine($"O arquivo {caminhoArquivo} não foi encontrado.");

            return;
        }

        string jsonFile = File.ReadAllText(caminhoArquivo);

        List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(jsonFile);

        var diasComFaturamento = faturamentos.Where(f => f.Valor > 0).ToList();

        double menorFaturamento = diasComFaturamento.Min(f => f.Valor);
        double maiorFaturamento = diasComFaturamento.Max(f => f.Valor);

        double mediaMensal = diasComFaturamento.Average(f => f.Valor);

        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
        Console.WriteLine($"Média de faturamento (dias úteis): {mediaMensal}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

