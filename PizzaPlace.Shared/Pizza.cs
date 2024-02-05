using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class Pizza
    {
        public Pizza (int id, string nombre, decimal precio,
            Picante picante)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Picante = picante;
        }
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public Picante Picante { get; }
    }
}
