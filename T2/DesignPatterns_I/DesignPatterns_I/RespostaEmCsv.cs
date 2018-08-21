using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    class RespostaEmCsv : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public void Responde (Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
