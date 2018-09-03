using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_3___Classes_abertas__Open_Closed_e_Dependency_Inversion_Principles
{
    class TabelaDePrecoPadrao : ITabelaDePreco
    {
        public double Desconto(double valor)
        {
            if (valor > 5000) return 0.03;
            if (valor > 1000) return 0.05;
            return 0;
        }
    }
}
