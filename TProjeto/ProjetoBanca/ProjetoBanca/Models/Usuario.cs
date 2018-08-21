using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Login { get; set; }
        public String Senha { get; private set; }
        public String Email { get; set; }
        
    }
}