using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }
        protected override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
