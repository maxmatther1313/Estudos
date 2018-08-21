using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Logradouro
    {
        public int Id { get; set; }
        public String Cidade { get; set; }

        public String Cep { get; set; }

        public String Bairro { get; set; }

        public String Rua { get; set; }

        public String TipoLogradouro { get; set; }

    }
}