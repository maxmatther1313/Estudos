using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_II.Cap_VI
{
    class MensagemDoCliente : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }
        public MensagemDoCliente(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o cliente {0}", nome);
        }
    }
}
