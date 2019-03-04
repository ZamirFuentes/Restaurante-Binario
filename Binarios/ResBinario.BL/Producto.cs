using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBinario.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la Descripcion")]
        [MinLength (3, ErrorMessage = "Ingrese Minino 3 Caracteres")]
        [MaxLength(20, ErrorMessage = "Ingrese un Maximo de 20 Caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese el Precio")]
        [Range(0, 1000, ErrorMessage = "Ingrese un precion entre 0 y 1000")]
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }
        public int CategoriaId { get; set; }
    }
}
