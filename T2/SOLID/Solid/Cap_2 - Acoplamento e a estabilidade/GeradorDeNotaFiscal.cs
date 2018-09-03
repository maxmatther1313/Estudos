using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_2___Acoplamento_e_a_estabilidade
{
    class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNotaFiscal> acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNotaFiscal> acoes)
        {
            this.acoes = acoes;                       
        }
         
        public NotaFiscal Gerar(Fatura fatura)
        {
            double valor = fatura.ValorMensal;
            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimples(valor));
            
            foreach (var acao in acoes)
            { 
                acao.Executa(nf);
            }

            return nf;
        }
        private double ImpostoSimples(double valor)
        {
            return valor * 0.06;
        }
    }
}
