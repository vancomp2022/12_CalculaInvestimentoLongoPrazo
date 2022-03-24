namespace _CalculaInvestimento_LongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12 - Calcula Investimento Longo Prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
                
            }
            Console.WriteLine("Ao termino do investimento, voce tera R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}