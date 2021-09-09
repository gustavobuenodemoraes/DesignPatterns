using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class SemResposta : IResposta
    {
        public void Responde(Requisicao req, Conta conta)
        {
            Console.WriteLine("Formato sem tratamento!");
        }
    }
}
