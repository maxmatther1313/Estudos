using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<String> nvoOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (nvoOrcamento.Contains(item.Nome)) return true;
                else
                    nvoOrcamento.Add(item.getNome);
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
