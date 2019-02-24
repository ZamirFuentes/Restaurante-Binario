using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBinario.BL
{
    public class ProductosBL
    {
        Contexto _contexto;
        public List<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new List<Producto>();

        }
        public List<Producto> ObtenerProductos()
        {

            ListaProductos = _contexto.Productos.ToList();
            return ListaProductos;

        }

        public void GuardarProducto(Producto producto)
        {
            _contexto.Productos.Add(producto);
            _contexto.SaveChanges();
        }

    }
}
