using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectData.DataMethods;

namespace CrudWebNBA.Controllers
{
    public class JugadoresController : Controller
    {
        // GET: Jugadores
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        public ActionResult EveryJugador()
        {
            var jugador = dataMethodsRepo.GetJugadorMethods().SelectAllJugadores();

            return View();
        }
    }
}