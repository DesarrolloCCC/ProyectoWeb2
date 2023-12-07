using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model;

namespace ProyectoWeb2.Controllers
{
    public class HomeController : Controller
    {
        private ConfigTipos pTipos = new ConfigTipos();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tipos()
        {
            return View(pTipos.Listar());
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult UsuariosGeneral()
        {
            return View();
        }

        public ActionResult UsuariosRegistrar()
        {
            return View();
        }

        public ActionResult UsuariosEliminar()
        {
            return View();
        }
    }
}