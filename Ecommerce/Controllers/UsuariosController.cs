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
        IList<string> contatos;
        // GET: Usuarios
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IList<string> SaveContact(string[] todosContatos)
        {
            contatos = new List<string>(todosContatos.Length);

            foreach (string itens in todosContatos)
            {
                contatos.Add(itens);
            }

            return contatos;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID,Nome,Cpf,Rg,Cep,Endereco,Numero,Bairro,Cidade,Contato,Email,Senha,Imagem")] Usuario usuario)
        {
            foreach (string item in contatos)
            {
                usuario.Contato += item + ", ";
            }

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