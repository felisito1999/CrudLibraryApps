using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectData.DataMethods;
using ProjectData;
using CrudWeb;

namespace CrudWeb.Controllers
{
    public class JugadoresController : Controller
    {
        // GET: Jugadores
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        public ActionResult AllJugadores()
        {
            var jugadores = dataMethodsRepo.GetJugadorMethods().SelectViewJugador();
            return View(jugadores);
        }
        [HttpPost]
        public ActionResult CreateJugadores(Jugador jugador)
        {
            dataMethodsRepo.GetJugadorMethods().InsertJugador(jugador);
            return View(jugador);
        }
        public ActionResult UpdateJugador(int id)
        {
            var jugador = dataMethodsRepo.GetJugadorMethods().SelectJugadorById (id);
            //jugador.Nombre = ViewBag.Nombre;
            //jugador.Apellido = ViewBag.Apellido;
            //jugador.FechaNacimiento
            var estado = dataMethodsRepo.GetEstadoMethods().SelectAllEstados();
            var sexo = dataMethodsRepo.GetSexoMethods().SelectAllSexos();

            ViewBag.Pais = new SelectList(dataMethodsRepo.GetPaisMethods().SelectAllPaises(), "CodigoPais", "NombrePais");
            ViewBag.Estado = new SelectList(dataMethodsRepo.GetEstadoMethods().SelectAllEstados(), "CodigoEstado", "DescripcionEstado");
            ViewBag.Sexo = new SelectList(dataMethodsRepo.GetSexoMethods().SelectAllSexos(), "CodigoSexo", "NombreSexo");
            //ViewBag.estado = estado;
            //ViewBag.sexo = sexo;
            
            return View(jugador);
        }
        [HttpPost]
        public ActionResult UpdateJugador(Jugador jugador)
        {

            dataMethodsRepo.GetJugadorMethods().UpdateJugador(jugador);

            return View(jugador);
        }
    }
}