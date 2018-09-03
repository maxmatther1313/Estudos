using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_2___Acoplamento_e_a_estabilidade
{
    class NotaFiscal
    {
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public double ValorLiquido
        {
            get
            {
                return this.ValorBruto - this.Impostos;
            }
        }

        public NotaFiscal(double valor, double impostos)
        {
            this.ValorBruto = valor;
            this.Impostos = impostos;
        }
    }
}
