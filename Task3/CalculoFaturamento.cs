using Newtonsoft.Json;

namespace Task3
{

    class Faturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    public class CalculoFaturamento
    {
        public void Calcular()
        {
            // Lê os dados de faturamento do arquivo JSON
            string jsonPath = "E:/TestesDeContratação/TargetSistemas/TaskTarguetSistemas/Task3/json.json";
            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(File.ReadAllText(jsonPath));

            // Filtra os dias com faturamento > 0 (desconsidera finais de semana/feriados)
            var diasComFaturamento = faturamentos.Where(f => f.valor > 0).ToList();

            // Calcula o menor e o maior valor de faturamento
            double menorFaturamento = diasComFaturamento.Min(f => f.valor);
            double maiorFaturamento = diasComFaturamento.Max(f => f.valor);

            // Calcula a média do faturamento diário
            double mediaMensal = diasComFaturamento.Average(f => f.valor);

            // Calcula o número de dias em que o faturamento foi superior à média mensal
            int diasAcimaMedia = diasComFaturamento.Count(f => f.valor > mediaMensal);

            // Exibe os resultados
            Console.WriteLine($"Menor faturamento: {menorFaturamento:C}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento:C}");
            Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaMedia}");
        }
       
    }

}
