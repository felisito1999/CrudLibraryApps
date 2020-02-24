using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectData.DataMethods;

namespace CrudWeb.Controllers
{
    public class EstadisticasController : Controller
    {
        // GET: Estadisticas
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        public ActionResult Index(int id)
        {
            var estadisticas = dataMethodsRepo.GetEstadisticasJugadorMethods().SelectEstadisticasByIdJugador(id);
            return View(estadisticas);
        }
    }
}