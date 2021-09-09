using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class RespostaEmPorcento : IResposta
    {
        public IResposta _outraResposta { get; set; }

        public RespostaEmPorcento(IResposta OutraResposta)
        {
            _outraResposta = OutraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                _outraResposta.Responde(req, conta);
            }
        }
    }
}