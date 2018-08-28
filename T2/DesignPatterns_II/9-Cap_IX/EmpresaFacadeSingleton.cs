using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_II._9_Cap_IX
{
    class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();
        public EmpresaFacade Instancia
        {
            get
            {
                return facade;
            }
        }
    }
}
