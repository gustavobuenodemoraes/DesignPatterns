using DesignPatterns.Domain;
using System;

namespace DesignPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var calculador = new CalculadorDeDescontos();

            //var orcamento = new Orcamento(500.0);
            //orcamento.AdicionarItem(new Item("CANETA", 250.0));
            //orcamento.AdicionarItem(new Item("LAPIS", 250.0));

            //double desconto = CalculadorDeDescontos.Calcula(orcamento);

            //Console.WriteLine(desconto);

            var titular = "Gustavo";
            var saldo = 1200;
            var formato = Formato.PORCENTO;
            _ = new Formatador(titular, saldo, formato);

        }

    }
}
