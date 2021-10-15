using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Producto
    {
        [Key]
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public float precio { get; set; }
        public int cantidad { get; set; }
        public string descricpcion { get; set; }

    }
}
