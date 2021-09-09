using DesignPatterns.Domain;
using System;

namespace DesignPatterns.ChainOfResponsibility
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            var exiteCaneta = Existe("CANETA", orcamento);
            var exiteLapis = Existe("LAPIS", orcamento);

            if (exiteCaneta || exiteLapis)
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
