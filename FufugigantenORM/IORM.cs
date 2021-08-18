using System;
using System.Collections.Generic;
using FufugigantenModels;

namespace FufugigantenORM
{
    public interface IORM
    {
        public List<Customer> GetCustomer();
        public Customer GetCustomer(int id);
        public List<Product> GetProduct();
        public Product GetProduct(int id);
        public Product CreateProduct(Product product);
        public Manufacturer GetManufacturer(int id);
        public Manufacturer GetManufacturers();
        public Manufacturer CreateManufacturers(Manufacturer manufacturer);
    }
}
