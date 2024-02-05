using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class Estado
    {
        public Menu Menu { get; } = new Menu();
        public CarritoCompras Carrito { get; } = new CarritoCompras();
        public UI UI { get; set; } = new UI();

        public decimal PrecioTotal
            => Carrito.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}
