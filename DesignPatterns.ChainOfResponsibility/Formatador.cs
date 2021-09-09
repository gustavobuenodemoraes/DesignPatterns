using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
   public class Formatador
    {
        public Formatador(string titular, int saldo, Formato formato)
        {
            var conta = new Conta(titular, saldo);
            var requisicao = new Requisicao(formato);

            var semResposta = new SemResposta();
            var respostaEmPorcento = new RespostaEmPorcento(semResposta);
            var respostaEmXml = new RespostaEmXml(respostaEmPorcento);
            var respostaEmCsv = new RespostaEmCsv(respostaEmXml);

            respostaEmCsv.Responde(requisicao, conta);
        }
    }
}
