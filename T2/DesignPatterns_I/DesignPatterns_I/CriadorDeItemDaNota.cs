using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    public class CriadorDeItemDaNota
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public CriadorDeItemDaNota ComDescricao(String descricao)
        {
            this.Descricao = descricao;
            return this;
        }

        public CriadorDeItemDaNota ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}
