using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }

        public ImpostoMuitoAlto() : base() { }

        protected override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + Calcula(orcamento);
        }
    }
}
