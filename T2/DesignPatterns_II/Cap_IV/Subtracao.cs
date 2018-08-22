using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_II.Cap_IV
{
    class Subtracao : IExpressao
    {
        private IExpressao direita;
        private IExpressao esquerda;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
