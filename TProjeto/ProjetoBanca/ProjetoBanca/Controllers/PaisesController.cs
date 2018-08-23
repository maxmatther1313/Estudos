using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class PaisesController : Controller
    {
        // GET: Paises
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica (String nome)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.BuscaPorNome(nome);
            if(usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Paises");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}