using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Cpf { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public Pessoa()
        {
            Enderecos = new List<Endereco>();
        }
    }
}