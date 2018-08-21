using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem descontos extra!");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Ocamento ja esta em estado de aprovação");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento esta em aprovado, não pode ser reprovado agora");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
