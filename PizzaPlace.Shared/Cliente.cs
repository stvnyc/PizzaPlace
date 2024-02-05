using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo requerido para realizar el pedido.")]
        public string Nombre { get; set; } = default!;
        [Required(ErrorMessage = "Campo requerido para realizar el pedido.")]
        public string Calle { get; set; } = default!;
        [Required(ErrorMessage = "Campo requerido para realizar el pedido.")]
        public string Ciudad { get; set; } = default!;
    }
}
