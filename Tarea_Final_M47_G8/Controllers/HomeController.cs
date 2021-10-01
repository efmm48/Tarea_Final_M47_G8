/*Tarea Final

Crea una aplicación que permita hacer mantenimiento a las entidades que 
se mencionan más abajo. Cada entidad debe tener su CRUD.
Entidades: 

a) Pais(IdPais, Nombre)

b) Cliente(IdCliente, Nombre, IdPais, FechaNac)

El usuario debe tener un menú inicial que le permita elegir cual de los 
mantenimiento va a ejecutar.

En la captura del cliente se debe poder elegir el país mediante un 
ComboBox que muestre la lista de países.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea_Final_M47_G8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}