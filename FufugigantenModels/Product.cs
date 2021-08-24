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
        // Constructor overload, takes id, name
        [JsonConstructor]
        public Product(int productId, string name, decimal price, ProductType productType, Manufacturer manufacturer)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            ProductType = productType;
            Manufacturer = manufacturer;
        }


        public void SetId(int id)
        {
            ProductId = id;
        }
    }
}
