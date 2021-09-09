﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class RespostaEmCsv : IResposta
    {
        public IResposta _outraResposta { get; set; }

        public RespostaEmCsv(IResposta OutraResposta)
        {
            _outraResposta = OutraResposta;
        }


        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                _outraResposta.Responde(req, conta);
            }
        }
    }

}
