using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_II.Cap_IV
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;
        private IExpressao expressao;

        public RaizQuadrada(IExpressao esquerdo, IExpressao direito, IExpressao expressao)
        {
            this.esquerda = esquerdo;
            this.direita = direito;
            this.expressao = expressao;
        }

        public int Avalia()
        {
            int valorEsquerdo = esquerda.Avalia();
            int valorDireito = direita.Avalia();
            return (int) Math.Sqrt(expressao.Avalia());
        }
    }
}
