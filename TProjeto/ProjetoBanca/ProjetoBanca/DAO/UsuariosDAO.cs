﻿using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class UsuariosDAO
    {
       public void Adiciona(Usuario usuario)
        {
            using (var context = new ImplasticContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using (var contexto = new ImplasticContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            using (var contexto = new ImplasticContext())
            {
                return contexto.Usuarios.Find(id);
            }
        }

        //public void Atualiza(Usuario usuario)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
                
        //    }
        //}

            public Usuario BuscaPorNome(string nome)
        {
            using (var contexto = new ImplasticContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Nome == nome);
            }
        }

        public Usuario Busca(string login, string senha)
        {
            using (var contexto = new ImplasticContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }
    }
}