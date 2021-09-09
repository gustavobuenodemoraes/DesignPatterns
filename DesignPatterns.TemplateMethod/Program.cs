using DesignPatterns.Domain;
using System;

namespace DesignPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var orcamento = new Orcamento(1200);
            orcamento.AdicionarItem(new Item("Fone", 300));
            orcamento.AdicionarItem(new Item("mouse", 300));
            orcamento.AdicionarItem(new Item("teclado", 400));

            var impostoIKCV = new IKCV();
            var cal = impostoIKCV.Calcula(orcamento);
            var maxit = impostoIKCV.DeveUsarMaximaTaxacao(orcamento);
            var max = impostoIKCV.MaximaTaxacao(orcamento);
            var min = impostoIKCV.MinimaTaxacao(orcamento);

            Console.WriteLine($"Teste {cal}  , {maxit} , {max}, {min}");
        }
    }
}
