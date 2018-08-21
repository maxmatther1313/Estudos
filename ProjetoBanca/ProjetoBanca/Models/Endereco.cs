using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }

        public String TipoEndereco { get; set; }

        public String Pais { get; set; }

        public Logradouro Cidade { get; set; }

        public String Estado { get; set; }

        public int NumeroCasa { get; set; }

        public String Complemento { get; set; }

        public Logradouro Cep { get; set; }
    }
}