using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto
{
    internal class Product
    {
        int id;
        string description;
        double price;
        int quantity;

        public Product(int id, string description, double price, int quantity)
        {
            this.Id = id;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{id};{Description};{Price};{Quantity}";
        }
    }
}
