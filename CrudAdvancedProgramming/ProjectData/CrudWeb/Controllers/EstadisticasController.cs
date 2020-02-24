using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectData.DataMethods;
using ProjectData.Models;

namespace CrudWeb.Controllers
{
    public class EstadisticasController : Controller
    {
        // GET: Estadisticas
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        public ActionResult EstadisticasByJugadorId(int id)
        {
            var estadisticas = dataMethodsRepo.GetEstadisticasJugadorMethods().SelectEstadisticasByIdJugador(id);
            return View(estadisticas);
        }
        public ActionResult UpdateEstadisticas(int id, EstadisticasJugador estadisticasJugador)
        {
            var estadisticas = dataMethodsRepo.GetEstadisticasJugadorMethods().SelectEstadisticasByIdJugador(id);
            dataMethodsRepo.GetEstadisticasJugadorMethods().UpdateEstadisticasJugador(estadisticasJugador);
            return View(estadisticasJugador);
        }
    }
}