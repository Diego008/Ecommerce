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
        public ActionResult Create(string user)
        {
            //string json = JsonConvert.SerializeObject(user);

            Usuario deserializeUsuario = JsonConvert.DeserializeObject<Usuario>(user);
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