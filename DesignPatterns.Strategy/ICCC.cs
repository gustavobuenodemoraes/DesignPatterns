namespace DesignPatterns.Strategy
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            var valorComImposto = 0.0;

            if (orcamento.Valor > 3000)
                valorComImposto = orcamento.Valor * 0.8;

            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                valorComImposto = orcamento.Valor * 0.7;

            else if (orcamento.Valor < 1000)
                valorComImposto = orcamento.Valor * 0.5;


            return valorComImposto;
        }
    }
}
