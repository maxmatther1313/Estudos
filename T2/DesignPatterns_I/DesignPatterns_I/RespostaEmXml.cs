using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    class RespostaEmXml : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "<titular><saldo>" + conta.Saldo + "<saldo><conta>");
            }
            else
            {
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
