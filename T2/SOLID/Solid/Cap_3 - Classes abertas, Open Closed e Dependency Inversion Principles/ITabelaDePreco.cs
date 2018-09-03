using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_3___Classes_abertas__Open_Closed_e_Dependency_Inversion_Principles
{
    public interface ITabelaDePreco
    {
        double Desconto(double valor);
    }
}
