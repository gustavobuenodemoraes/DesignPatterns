using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class RespostaEmXml : IResposta
    {
        public IResposta _outraResposta { get; set; }

        public RespostaEmXml(IResposta OutraResposta)
        {
            _outraResposta = OutraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                _outraResposta.Responde(req, conta);
            }
        }
    }
}
