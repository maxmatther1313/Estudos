using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public String Representante { get; set; }

        public Pessoa Cliente { get; set; }

        public Contato Solicitante { get; set; }

        public DateTime Data { get; set; }

        public Boolean CobrarFrete { get; set; }

        public Pessoa OrdemDeCompra { get; set; }

        public Double Valor { get; private set; }

        public DateTime DataEntrega { get; set; }
        
    }
}