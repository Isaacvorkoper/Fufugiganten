using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FufugigantenModels
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }
        public Manufacturer Manufacturer { get; set; }

        // Constructor, takes name
        [JsonConstructor]
        public Product(string name, decimal price, ProductType producttype, Manufacturer manufacturer)
        {
            Name = name;
            Price = price;
            ProductType = producttype;
            Manufacturer = manufacturer;
        }

        // Constructor overload, takes id, name
        public Product(int productid, string name, decimal price, ProductType producttype, Manufacturer manufacturer)
        {
            ProductId = productid;
            Name = name;
            Price = price;
            ProductType = producttype;
            Manufacturer = manufacturer;
        }
        public void SetId(int id)
        {
            ProductId = id;
        }
    }
}
