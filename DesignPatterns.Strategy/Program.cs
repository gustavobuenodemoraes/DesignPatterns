using DesignPatterns.Domain;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();
            var orcamento = new Orcamento(1500.0);
            var calculador = new CalculadorDeImpostos();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);

            // Calculando o ICCC        
            calculador.RealizaCalculo(orcamento, iccc);
        }
    }
}
