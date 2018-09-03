using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_3___Classes_abertas__Open_Closed_e_Dependency_Inversion_Principles
{
    class Transportadora : IServicoDeEntrega
    {
        public double Para(string cidade)
        {
            return 5;
        }
    }
}
