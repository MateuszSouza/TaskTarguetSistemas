namespace Task4
{
    public class Distribuicao
    {
        const double SP = 67836.43;
        const double RJ = 36678.66;
        const double MG = 29229.88;
        const double ES = 27165.48;
        const double Outros = 19849.53;
        double total;
        public void CalcularPercentuais()
        {
            total = SP + RJ + MG + ES + Outros;
            Console.WriteLine("Percentual em SP: " + Math.Ceiling(Perscentual(SP)) + "%");
            Console.WriteLine("Percentual em RJ: " + Math.Ceiling(Perscentual(RJ)) + "%");
            Console.WriteLine("Percentual em MG: " + Math.Ceiling(Perscentual(MG)) + "%");
            Console.WriteLine("Percentual em ES: " + Math.Ceiling(Perscentual(ES)) + "%");
            Console.WriteLine("Percentual em Outros lugares: " + Math.Ceiling(Perscentual(Outros)) + "%");
        }

        private double Perscentual(double valor)
        {
            return (valor * 100) / total;
        }

    }
}
