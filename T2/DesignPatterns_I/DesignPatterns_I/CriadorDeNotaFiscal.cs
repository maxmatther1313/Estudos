using ConsoleApp1;
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

        private IList<AcaoAposGerarNotaFiscal> todasAcoesASeremExecutadas = new List<AcaoAposGerarNotaFiscal>();

        //private IList<AcaoAposGerarNotaFiscal> todasAcoesASeremExecutadas;

        //public CriadorDeNotaFiscal(IList<AcaoAposGerarNotaFiscal> lista)
        //{
        //    this.todasAcoesASeremExecutadas = lista;
        //}

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
            foreach(AcaoAposGerarNotaFiscal acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(AcaoAposGerarNotaFiscal novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        private void enviaPorEmail(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio de email");
        }

        private void salvaNoBanco(NotaFiscal nf)
        {
            Console.WriteLine("Simulando salvamento no Banco de Dados");
        }

        private void enviaPorSms(NotaFiscal nf)
        {
            Console.WriteLine("Simulando envio de Sms");
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

        public CriadorDeNotaFiscal NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

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
