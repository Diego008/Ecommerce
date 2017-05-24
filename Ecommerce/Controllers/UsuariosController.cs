using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class UsuariosController : Controller
    {
        private Context db = new Context();
        // GET: Usuarios
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult SaveContact(string[] contatos)
        {
            Usuario usuario = new Usuario();
            if (contatos != null)
            {
                foreach (string item in contatos)
                {
                    usuario.Contato += item;
                }

                RedirectToAction("CreateUser");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUser([Bind(Include = "UsuarioID,Nome,Cpf,Rg,Cep,Endereco,Numero,Bairro,Cidade,Contato,Email,Senha,Imagem")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(usuario);
        }
    }
}