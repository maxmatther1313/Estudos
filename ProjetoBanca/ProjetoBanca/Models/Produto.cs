using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public UnidadeMedida UnidadeMedida { get; set; }

        public DateTime PrazoEntrega { get; set; }

        public Double ValoraUnitario { get; private set; }

        public int Quantidade { get; set; }
    }
}