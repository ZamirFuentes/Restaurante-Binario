using ResBinario.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResBinario.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listaProductos = productosBL.ObtenerProductos();

            return View(listaProductos);
        }
    }
}