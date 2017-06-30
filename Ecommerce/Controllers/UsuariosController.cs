using E_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Models;
using Newtonsoft.Json;

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

        public JsonResult Contatos(string dataJson)
        {
            JsonResult json = new JsonResult();
            return json;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID, Nome, Cpf, Rg, Cep, Endereco, Numero, Bairro, Cidade, Contato, Email, Senha, Imagem")] Usuario usuario, HttpPostedFileBase imagem, string contatos)
        {
            
            try
            {
                string fileName = "";
                string contentType = "";
                string path = "";                

                if (imagem != null && imagem.ContentLength > 0)
                {
                    fileName = System.IO.Path.GetFileName(imagem.FileName);
                    contentType = imagem.ContentType;
                    path = System.Configuration.ConfigurationManager.AppSettings["PathFiles"] + "\\Usuarios\\" + fileName;
                    imagem.SaveAs(path);
                    usuario.Imagem = fileName;
                }
            }
            catch
            {
                ViewBag.MessageFoto = "Não foi possível salvar a foto";
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