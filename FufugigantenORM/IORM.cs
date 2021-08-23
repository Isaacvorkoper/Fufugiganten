using System;
using System.Collections.Generic;
using FufugigantenModels;

namespace FufugigantenORM
{
    public interface IORM
    {
        public Manufacturer GetManufacturer(int id);
        public Manufacturer GetManufacturers();
        public Manufacturer CreateManufacturers(Manufacturer manufacturer);
        public Manufacturer UpdateManufacturer(Manufacturer manufacturer);
        public Manufacturer DeleteManufacturer(Manufacturer manufacturer);
    }
}
