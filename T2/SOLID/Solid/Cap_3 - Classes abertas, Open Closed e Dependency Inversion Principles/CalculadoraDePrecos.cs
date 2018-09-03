using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_3___Classes_abertas__Open_Closed_e_Dependency_Inversion_Principles
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePreco tabela;
        private IServicoDeEntrega entrega;

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            this.tabela = tabela;
            this.entrega = entrega;
        }
        public double Calcula(Compra produto)
        {
            TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
            Frete correios = new Frete();

            double desconto = this.tabela.Desconto(produto.Valor);
            double frete = this.entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
