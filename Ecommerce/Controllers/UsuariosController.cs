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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario, HttpPostedFileBase foto)
        {
            string jsonData = JsonConvert.SerializeObject(usuario);

            Usuario deserializeUsuario = JsonConvert.DeserializeObject<Usuario>(jsonData);

            try
            {
                string fileName = "";
                string contentType = "";
                string path = "";
                if (foto != null && foto.ContentLength > 0)
                {
                    fileName = System.IO.Path.GetFileName(foto.FileName);
                    contentType = foto.ContentType;
                    path = System.Configuration.ConfigurationManager.AppSettings["PathFiles"] + "\\Usuarios\\" + fileName;
                    foto.SaveAs(path);
                    deserializeUsuario.Imagem = fileName;
                }
            }
            catch
            {
                ViewBag.MessageFoto = "Não foi possível salvar a foto";
            }
            if (ModelState.IsValid)
            {

                db.Usuarios.Add(deserializeUsuario);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(deserializeUsuario);
        }
    }
}