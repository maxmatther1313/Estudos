using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Resposta
    {
        void Responde(Requisicao requisicao, Conta conta);
        Resposta OutraResposta { get; set; }
    }
}
