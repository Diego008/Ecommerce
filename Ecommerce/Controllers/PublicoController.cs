using Ecommerce.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class PublicoController : Controller
    {
        
        public ActionResult Logar()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Logar(string login, string email, string senha){
            if (login == "2")
            {
                if (Funcoes.AutenticarAdmin(email, senha) == false)
                {
                    ViewBag.Message = "OpenModal";
                    return View();
                }
                return RedirectToAction("Index", "Admins");
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logoff()
        {
            Ecommerce.Repositories.Funcoes.DeslogarAdmin();
            return RedirectToAction("Index", "Home");
        }
    }
}