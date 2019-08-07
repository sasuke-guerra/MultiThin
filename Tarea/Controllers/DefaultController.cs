using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea.Models;
namespace Tarea.Controllers
{
    public class DefaultController : Controller
    {
        List<Tareas> lastTarras;
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcesarFormulario(Tareas tareas)
        {
            if (ModelState.IsValid)
            {
                Algo.LTareas.Add(new Tareas()
                {

                    Descripcion = Request["des"],
                    Fecha = DateTime.Parse(Request["fecha"]),
                    Materia = Request["materia"]
                });
                return RedirectToAction("RegistroTarea");
            }
            else
            {
                return View("RegistroTarea");
            }
        }


        public ActionResult RegistroTarea()
        {


            return View(Algo.LTareas);
        }

   
        public ActionResult Calculadora()
        {
            return View();
        }

        public ActionResult Acerca()
        {
            return View();
        }

        public ActionResult Conversor()
        {
            return View();
        }

        public ActionResult Lector()
        {
            return View();
        }

    }
}