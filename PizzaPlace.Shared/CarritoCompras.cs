using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class CarritoCompras
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool HaPagado { get; set; }

        public void AgregarOrden(int pizzaId)
        => Ordenes.Add(pizzaId);

        public void QuitarOrden(int pos)
            => Ordenes.RemoveAt(pos);
    }
}
