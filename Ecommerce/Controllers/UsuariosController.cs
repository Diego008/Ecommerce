using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult SaveContact(string[] contatos)
        {
            if (contatos != null)
            {
                return PartialView("Sucesso");
            }
            return PartialView("deu ruim");
        }
    }
}