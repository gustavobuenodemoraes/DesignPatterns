using DesignPatterns.Domain;

namespace DesignPatterns.ChainOfResponsibility
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
