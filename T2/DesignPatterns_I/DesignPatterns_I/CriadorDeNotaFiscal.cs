using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_1
{
    public class CriadorDeNotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }

        public CriadorDeNotaFiscal ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public CriadorDeNotaFiscal NaData(DateTime outraData)
        {
            this.Data = outraData;
            return this;
        }

        //public CriadorDeNotaFiscal NaDataAtual()
        //{
        //    this.Data = DateTime.Now;
        //    return this;
        //}

        public CriadorDeNotaFiscal ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;

            return this;
        }
    }
}
