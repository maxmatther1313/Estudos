using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_II.Cap_VI
{
    class MensagemAdministrador : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }
        public MensagemAdministrador(string nome)
        {
            this.nome = nome;
        }       
        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}", nome);
        }
    }
}
