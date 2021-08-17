using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FufugigantenModels
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        public string Name { get; set; }

        // Constructor, takes name
        public Manufacturer(string name)
        {
            Name = name;
        }

        // Constructor overload, takes id, name
        public Manufacturer(int manufacturerid, string name)
        {
            ManufacturerId = manufacturerid;

            Name = name;

        }
    }
}
